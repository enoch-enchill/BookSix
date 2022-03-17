using BookSix.Shared.Abstractions.Kernel.Exceptions;

namespace BookSix.Shared.Abstractions.Kernel.ValueObjects;
public record Name
{

    public string Value { get; set; }

    public Name(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new InvalidNameException(value);
        }

        if (string.IsNullOrWhiteSpace(value) || value.Length is > 50 or < 3)
        {
            throw new InvalidNameException(value);
        }


        Value = value;
    }

    public static implicit operator string(Name name) => name.Value;

    public static implicit operator Name(string name) => new(name);
}

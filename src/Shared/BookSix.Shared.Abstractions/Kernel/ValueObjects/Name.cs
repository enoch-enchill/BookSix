using BookSix.Shared.Abstractions.Kernel.Exceptions;
using System.Text.RegularExpressions;

namespace BookSix.Shared.Abstractions.Kernel.ValueObjects;
public record Name
{
    private static readonly Regex Regex = new("[^A-Za-z0-9]");
    public string Value { get; set; }

    public Name(string value)
    {

        if (string.IsNullOrWhiteSpace(value) || value.Length is > 50 or < 3)
        {
            throw new InvalidNameException(value);
        }

        if (Regex.IsMatch(value) || int.TryParse(value, out _))
        {
            throw new InvalidEmailException(value);
        }

        Value = value;
    }

    public static implicit operator string(Name name) => name.Value;

    public static implicit operator Name(string name) => new(name);
}

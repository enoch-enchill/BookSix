using BookSix.Shared.Abstractions.Exceptions;

namespace BookSix.Shared.Abstractions.Kernel.Exceptions;
public class InvalidNameException : BookSixException
{
    public string Name { get; }
    public InvalidNameException(string name) : base($"Name: '{name}' is invalid!")
    {
        Name = name;
    }
}

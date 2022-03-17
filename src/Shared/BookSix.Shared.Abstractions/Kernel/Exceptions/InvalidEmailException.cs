using BookSix.Shared.Abstractions.Exceptions;

namespace BookSix.Shared.Abstractions.Kernel.Exceptions;

public class InvalidEmailException : BookSixException
{
    public string Email { get;}
    public InvalidEmailException(string email) : base($"Email: '{email}' is invalid!")
    {
        Email = email;
    }
}

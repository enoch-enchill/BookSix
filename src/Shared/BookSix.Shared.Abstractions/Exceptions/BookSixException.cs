namespace BookSix.Shared.Abstractions.Exceptions;
public abstract class BookSixException : Exception
{
    protected BookSixException(string message) : base(message) { }
}

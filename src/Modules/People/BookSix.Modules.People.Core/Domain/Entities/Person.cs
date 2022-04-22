using BookSix.Shared.Abstractions.Kernel.ValueObjects;

namespace BookSix.Modules.People.Core.Domain.Entities;
internal class Person
{
    public Guid Id { get; private set; }

    public Email Email { get; private set; }

    public Name FirstName { get; private set; }

    public Name LastName { get; private set; }

    public bool IsActive { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime? UpdatedAt { get; private set; }

    private Person()
    {

    }

    public Person(Guid id, Email email, Name firstName, Name lastName, DateTime createdAt)
    {
        Id = id;
        Email = email;
        FirstName = firstName;
        LastName = lastName;
        CreatedAt = createdAt;
    }

    public void Complete(Email email, Name firstName, Name lastName)
    {

    }
}

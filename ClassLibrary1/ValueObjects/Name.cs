using Flunt.Validations;
using Shared.ValueObjects;

namespace Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract<Name>()
                .Requires()
                .IsGreaterThan(FirstName.Length, 2, "Name.FirstName", "Nome deve conter pelo menos 3 caracteres")
                .IsGreaterThan(LastName.Length, 2, "Name.LastName", "Sobrenome deve conter pelo menos 3 caracteres")
                .IsLowerOrEqualsThan(FirstName.Length, 40, "Name.FirstName", "Nome deve conter até 40 caracteres")
            );
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}

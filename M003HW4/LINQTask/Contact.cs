using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M003HW4.LINQTask.Validation;

namespace M003HW4.LINQTask
{
    internal class Contact : IContact
    {
        private static IContactValidator _validator;
        public Contact(string name, string phoneNumber, int age)
        {
            _validator.ValidateContact(number: phoneNumber, name, age);
            Name = name;
            PhoneNumber = phoneNumber;
            Age = age;
        }
        static Contact()
        {
            _validator = new ContactValidator();
        }

        public string Name { get; }
        public string PhoneNumber { get; }
        public int Age { get; }
        public override string ToString()
        {
            return $"{Name} of {Age}: {PhoneNumber}";
        }

        public bool Equals(IContact? other)
        {
            if (other == null)
            {
                return false;
            }

            if (ReferenceEquals(other, this))
            {
                return true;
            }

            return (other.PhoneNumber == PhoneNumber && other.Name == Name && other.Age == Age);
        }

    }
}

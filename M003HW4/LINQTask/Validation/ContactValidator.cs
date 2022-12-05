using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M003HW4.LINQTask.Validation
{
    internal class ContactValidator : IContactValidator
    {
        private void ValidateName(string name)
        {
            if (!char.IsUpper(name[0]) || !char.IsLetter(name[0]))
            {
                throw new ArgumentOutOfRangeException($"{nameof(name)} is invalid");
            }
        }

        private void ValidateNumber(string number)
        {
            if (!number.Except("+").All(x => char.IsDigit(x)) || number.Length != 13)
            {
                throw new ArgumentOutOfRangeException($"{nameof(number)} is invalid");
            }
        }

        private void ValidateAge(int age)
        {
            if (age < 0 || age > 130)
            {
                throw new ArgumentOutOfRangeException($"{nameof(age)} is out of range");
            }
        }

        public void ValidateContact(string number, string name, int age)
        {
            ValidateName(name);
            ValidateNumber(number);
            ValidateAge(age);
        }
    }
}

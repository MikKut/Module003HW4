using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M003HW4.LINQTask
{
    internal class Contacts
    {
        private List<IContact> _contacts;
        public Contacts()
        {
            _contacts = new List<IContact>();
        }

        public Contacts(List<IContact> contacts)
        {
            if (contacts == null)
            {
                throw new ArgumentNullException($"List of {nameof(contacts)} passed in {nameof(Contacts)} is null");
            }

            _contacts = contacts;
        }
        public void AddContact(IContact contact)
        {
            if (contact == null)
            {
                throw new ArgumentNullException($"The {nameof(contact)} is null");
            }

            if (_contacts.Contains(contact))
            {
                throw new ArgumentException("Adding the same elemetn");
            }

            _contacts.Add(contact);
        }
        public void AddStandartList()
        {
            AddContact(new Contact("A", "+380993392697", 15));
            AddContact(new Contact("And", "+380668792341", 17));
            AddContact(new Contact("B", "+380668792342", 17));
            AddContact(new Contact("Were", "+380668792343", 17));
            AddContact(new Contact("Sitting", "+380668792342", 10));
            AddContact(new Contact("On", "+380868792342", 9));
            AddContact(new Contact("The", "+380668793342", 19));
            AddContact(new Contact("Pipe", "+380768792342", 23));
            AddContact(new Contact("A", "+380688792342", 22));
            AddContact(new Contact("Fell", "+380661192342", 32));
            AddContact(new Contact("B", "+380668792311", 12));
            AddContact(new Contact("Disappered", "+380778792342", 27));
            AddContact(new Contact("Who", "+380001792342", 9));
            AddContact(new Contact("Remained", "+380661112342", 16));
            AddContact(new Contact("On", "+380668722422", 34));
            AddContact(new Contact("The", "+380644492342", 9));
            AddContact(new Contact("Pipe", "+380668644342", 54));
        }
        public IContact? GetTheFirstOrDefaultContactStartsWithUpperCase()
        {
            return _contacts.Where(x => char.IsUpper((x).Name[0])).FirstOrDefault();
        }
        public int GetQuantityOfAdultContacts(int adultAge = 18)
        {
            return _contacts.Select(x => x.Age).Count(x => x > adultAge);
        }
        public IEnumerable<IContact> GetCommonElements(IEnumerable<IContact> collectionToCompare)
        {
            return _contacts.Intersect(collectionToCompare, new ContactEqualityComparer());
        }
        public IEnumerable<(string Name1, string Name2, string PhoneNumber)> GetElementsWithCommonNumber(IEnumerable<IContact> collection)
        {
            return _contacts.Join(collection,
                x => x.PhoneNumber,
                y => y.PhoneNumber,
                (x, y) => (Name1: x.Name, Name2: y.Name, PhoneNumber: x.PhoneNumber));
        }
    }
}

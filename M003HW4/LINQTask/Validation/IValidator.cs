namespace M003HW4.LINQTask.Validation
{
    internal interface IContactValidator
    {
        void ValidateContact(string number, string name, int age);
    }
}
using M003HW4.DelegateTask;
using M003HW4.LINQTask;

#region LinqTasks
var commonContact1 = new Contact("Fell", "+380661192342", 32);
var commonContact2 = new Contact("The", "+380668793342", 19);
var commonOnlyNumberContact = new Contact("Shae", "+380668793342", 23);
var extraContact = new Contact("King", "+780668793342", 71);
var commonList = new List<Contact>();

commonList.Add(commonContact1);
commonList.Add(commonContact2);
commonList.Add(extraContact);
commonList.Add(commonOnlyNumberContact);

var contacts = new Contacts();
contacts.AddStandartList();

Console.WriteLine("Common elemetns:");
foreach (var contact in contacts.GetCommonElements(commonList))
{
    Console.WriteLine(contact.ToString());
}
Console.WriteLine();

Console.WriteLine("Common phone number:");
foreach (var contact in contacts.GetElementsWithCommonNumber(commonList))
{
    Console.WriteLine($"{contact.Name1} and {contact.Name2} have common number: {contact.PhoneNumber}");
}

Console.WriteLine();
Console.WriteLine($"{contacts.GetTheFirstOrDefaultContactStartsWithUpperCase()?.ToString()} - first starts with upper case");

Console.WriteLine();
Console.WriteLine($"There is {contacts.GetQuantityOfAdultContacts()} adult contacts");
#endregion LinqTasks


#region DelegateTask
try
{
    var x = new SumEventArgs(3, 4);
    Subscriber.Subscribe();
    Subscriber.Subscribe();
    Subscriber.OnInvoke(x);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
#endregion DeegateTask

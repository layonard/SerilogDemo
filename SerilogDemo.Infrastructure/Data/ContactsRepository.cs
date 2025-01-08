using SerilogDemo.Application.Abstractions;
using SerilogDemo.Domain;

namespace SerilogDemo.Infrastructure.Data;

public class ContactsRepository : IContactsRepository
{
    private static BusinessUnit Sales = new(1, "Sales");
    private static BusinessUnit Marketing = new(2, "Marketing");
    private static BusinessUnit It = new(3, "IT");

    private static List<Contact> Contacts = new()
    {
        new Contact(1, Sales, "John Doe", 30),
        new Contact(2, Marketing, "Jane Smith", 45),
        new Contact(3, It, "Alice Johnson", 25),
        new Contact(4, Sales, "Bob Brown", 35),
        new Contact(5, Marketing, "Charlie Davis", 40),
        new Contact(6, It, "Diana Evans", 50),
        new Contact(7, Sales, "Frank Green", 20),
        new Contact(8, Marketing, "Grace Harris", 55),
        new Contact(9, It, "Henry Jackson", 60),
        new Contact(10, Sales, "Ivy King", 15)
    };

    public ContactsRepository()
    { }

    public IEnumerable<Contact> GetContacts()
    {
        return Contacts;
    }

    public IEnumerable<Contact> GetContactsByBusinessUnit(int id)
    {
        return Contacts.Where(contact => contact.BusinessUnit.BuId == id);
    }

    public void AddContact(Contact contact)
    {
        Contacts.Add(contact);
    }

    public void RemoveContact(int id)
    {
        var contact = Contacts.Find(c => c.ContactId == id);
        if (contact != null)
        {
            Contacts.Remove(contact);
        }
    }
}

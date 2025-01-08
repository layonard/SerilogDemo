using SerilogDemo.Domain;

namespace SerilogDemo.Application.Abstractions;

public interface IContactsRepository
{
    public IEnumerable<Contact> GetContacts();
    public IEnumerable<Contact> GetContactsByBusinessUnit(int id);
}

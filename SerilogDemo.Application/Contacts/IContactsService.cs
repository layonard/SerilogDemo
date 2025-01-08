using SerilogDemo.Domain;

namespace SerilogDemo.Application.Contacts;

public interface IContactsService
{
    public List<Contact> GetAllContacts();
    public List<Contact> GetByBusinessUnit(int buId);
}

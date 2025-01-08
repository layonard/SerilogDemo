using SerilogDemo.Application.Abstractions;
using SerilogDemo.Domain;

namespace SerilogDemo.Application.Contacts;

public sealed class ContactsService : IContactsService
{
    private readonly IContactsRepository _contactsRepository;

    public ContactsService(IContactsRepository contactsRepository)
    {
        _contactsRepository = contactsRepository;
    }
    public List<Contact> GetAllContacts()
    {
        return _contactsRepository.GetContacts().ToList();
    }

    public List<Contact> GetByBusinessUnit(int buId)
    {
        if (buId <= 0)
        {
            throw new ArgumentException("Business Unit Id must be greater than 0", nameof(buId));
        }

        return _contactsRepository.GetContactsByBusinessUnit(buId).ToList();
    }
}

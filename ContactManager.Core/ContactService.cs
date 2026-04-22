using System;
namespace ContactManager.Core;

public class ContactService
{
    private InMemoryContactRepository _repository;
    public ContactService(InMemoryContactRepository repository)
    {
        _repository = repository;
    }
    public void AddContact(string name)
    {
        var contact = new Contact();
        contact.Name = name;
        _repository.Add(contact);

    }

}

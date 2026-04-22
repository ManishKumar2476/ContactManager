using System;
using System.ComponentModel;
namespace ContactManager.Core;

public class InMemoryContactRepository
{
    private List<Contact> _contacts = new List<Contact>();
    private int _nextId = 1;
    public void Add(Contact contact)
    {
        contact.Id = _nextId;
        _nextId++;
        _contacts.Add(contact);
    }

    public IReadOnlyList<Contact> GetAll()
    {
        return _contacts.AsReadOnly();

    }

}





using BlazorAppDemo.Models;
using System.Collections.Generic;

namespace BlazorAppDemo
{
    public class ContactService: IContactService
    {
        public List<Contact> ContactList { get; set; } = new List<Contact>();

        public void AddContact(Contact contact)
        {
            ContactList.Add(contact);
        }

        public List<Contact> GetContacts()
        {
            return ContactList;
        }
    }
}

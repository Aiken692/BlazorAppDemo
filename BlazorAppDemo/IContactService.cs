using BlazorAppDemo.Models;
using System.Collections.Generic;

namespace BlazorAppDemo
{
    public interface IContactService
    {
        List<Contact> GetContacts();

        void AddContact(Contact contact);
    }
}

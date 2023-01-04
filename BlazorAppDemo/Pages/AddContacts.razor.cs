using BlazorAppDemo.Models;

namespace BlazorAppDemo.Pages
{
    public partial class AddContacts
    {
        private string firstName, lastName, email;

        private void AddContact()
        {
            var contact = new Contact
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email
            };

            contactService.AddContact(contact);
        }
    }
}

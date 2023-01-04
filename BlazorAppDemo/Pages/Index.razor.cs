using BlazorAppDemo.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorAppDemo.Pages
{
    public partial class Index
    {
        [Inject]
        IContactService ContactService { get; set; }

        private List<Contact> contacts;
        private Dictionary<string, object> MyTextboxAttributes = new Dictionary<string, object>
        {
            {"placeholder", "FirstName"},
            {"disabled", "disabled"},

        };
        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(5000);

            contacts = ContactService.GetContacts();

            base.OnInitializedAsync();
        }

    }
}

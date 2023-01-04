using BlazorAppDemo.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorAppDemo.Pages.ContactComponents
{
    public partial class ContactComponent1
    {
        [Parameter]
        public Contact CurrentContact { get; set; }

        [Parameter]
        public bool displayEmail { get; set; }

        [Parameter]
        public EventCallback<Contact> DeleteCurrentContact { get; set; }

        private bool displayInfo = false;
    }
}

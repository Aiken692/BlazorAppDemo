using BlazorAppDemo.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorAppDemo.Shared
{
    public partial class DeleteConfirmation
    {
        private bool showPopup = false;

        public string BodyContent { get; set; }
        public Contact ContactToDelete { get; set; }

        [Parameter]
        public EventCallback<Contact> OnConfirmed { get; set; }

        public void Show() => showPopup = true;
        public void Hide() => showPopup = false;

        private async Task Confirm()
        {
            await OnConfirmed.InvokeAsync(ContactToDelete);
        }
    }
}

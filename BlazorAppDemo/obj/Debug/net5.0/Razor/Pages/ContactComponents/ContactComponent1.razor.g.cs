#pragma checksum "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\Pages\ContactComponents\ContactComponent1.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9abc632223439821dc7714bf56568a636f550c28"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAppDemo.Pages.ContactComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\_Imports.razor"
using BlazorAppDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\_Imports.razor"
using BlazorAppDemo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\_Imports.razor"
using BlazorAppDemo.Models;

#line default
#line hidden
#nullable disable
    public partial class ContactComponent1 : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __builder.AddAttribute(1, "b-6wrapybxv6");
            __builder.AddMarkupContent(2, "<b b-6wrapybxv6>Name:</b>");
            __builder.OpenElement(3, "span");
            __builder.AddAttribute(4, "b-6wrapybxv6");
#nullable restore
#line 3 "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\Pages\ContactComponents\ContactComponent1.razor"
__builder.AddContent(5, CurrentContact.FirstName);

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, " ");
#nullable restore
#line 3 "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\Pages\ContactComponents\ContactComponent1.razor"
__builder.AddContent(7, CurrentContact.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "<br b-6wrapybxv6>");
#nullable restore
#line 5 "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\Pages\ContactComponents\ContactComponent1.razor"
     if (displayEmail)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "<b b-6wrapybxv6>Email: </b>");
            __builder.OpenElement(10, "i");
            __builder.AddAttribute(11, "b-6wrapybxv6");
#nullable restore
#line 9 "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\Pages\ContactComponents\ContactComponent1.razor"
__builder.AddContent(12, CurrentContact.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "<br b-6wrapybxv6>");
#nullable restore
#line 12 "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\Pages\ContactComponents\ContactComponent1.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\Pages\ContactComponents\ContactComponent1.razor"
     if (displayInfo)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "span");
            __builder.AddAttribute(15, "b-6wrapybxv6");
            __builder.AddMarkupContent(16, "\r\n            The Email Address of the ");
#nullable restore
#line 19 "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\Pages\ContactComponents\ContactComponent1.razor"
__builder.AddContent(17, CurrentContact.FirstName);

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, " ");
#nullable restore
#line 19 "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\Pages\ContactComponents\ContactComponent1.razor"
__builder.AddContent(19, CurrentContact.LastName);

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, " is ");
#nullable restore
#line 19 "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\Pages\ContactComponents\ContactComponent1.razor"
__builder.AddContent(21, CurrentContact.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 21 "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\Pages\ContactComponents\ContactComponent1.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "<br b-6wrapybxv6>\r\n\r\n    ");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "class", "show");
            __builder.AddAttribute(25, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\Pages\ContactComponents\ContactComponent1.razor"
                                     () => {displayInfo = !displayInfo; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "b-6wrapybxv6");
            __builder.AddContent(27, "Show Info");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n  \r\n    ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "class", "delete");
            __builder.AddAttribute(31, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\Pages\ContactComponents\ContactComponent1.razor"
                                       () => DeleteCurrentContact.InvokeAsync(CurrentContact)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "b-6wrapybxv6");
            __builder.AddContent(33, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

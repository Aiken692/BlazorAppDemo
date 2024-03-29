#pragma checksum "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\Pages\SampleJavascript.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "424d410fc4d4019366d268d18662ff3c2acc02fc"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAppDemo.Pages
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/sample-javascript")]
    public partial class SampleJavascript : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>SampleJavascript</h3>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\Pages\SampleJavascript.razor"
                  ShowAlert

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, "Alert");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n<br><br>\r\n\r\n");
            __builder.OpenElement(5, "span");
#nullable restore
#line 9 "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\Pages\SampleJavascript.razor"
__builder.AddContent(6, confirmResult);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n<br>\r\n");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\Pages\SampleJavascript.razor"
                  ShowConfirm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "Confirm");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n<br>\r\n");
            __builder.AddMarkupContent(12, "<button onclick=\"callMethod()\">Call Method</button>");
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "D:\Personal_Projects\BlazorAppDemo\BlazorAppDemo\Pages\SampleJavascript.razor"
       
    private string confirmResult;

    private void ShowAlert()
    {
        jsRuntime.InvokeVoidAsync("alert", "Hello World, from C# method");
    }

    private async Task ShowConfirm()
    {
        var result = await jsRuntime.InvokeAsync<bool>("confirm", "Would you love to proceed ?");

        confirmResult = result.ToString();
    }

    [JSInvokable]
    public static Task<string> GetValueFromMethod()
    {
        return Task.FromResult<string>("Hello World");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591

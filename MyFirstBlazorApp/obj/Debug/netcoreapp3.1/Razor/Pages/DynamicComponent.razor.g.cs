#pragma checksum "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\Pages\DynamicComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1e701af2e609cfca763d7cc0dbcb84c330bca1e"
// <auto-generated/>
#pragma warning disable 1591
namespace MyFirstBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using MyFirstBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using MyFirstBlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using eShop.UseCases.SearchProductScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using eShop.CoreBusiness.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using MyFirstBlazorApp.Controls;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dynamic")]
    public partial class DynamicComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Our first Dynamic Component</h3>\n\n<br>\n<br>\n\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\Pages\DynamicComponent.razor"
                  HandleBlazorServerClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, "Blazor Server");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\Pages\DynamicComponent.razor"
                  HandleBlazorWebAssemblyClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, "Blazor WebAssembly");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n<br>\n<br>\n");
            __builder.OpenElement(9, "h3");
            __builder.AddContent(10, 
#nullable restore
#line 12 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\Pages\DynamicComponent.razor"
     title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n<br>\n");
            __builder.OpenElement(12, "div");
            __builder.AddMarkupContent(13, "\n    ");
            __builder.AddContent(14, 
#nullable restore
#line 15 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\Pages\DynamicComponent.razor"
     content

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(15, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\Pages\DynamicComponent.razor"
       

    private string title;
    private string content;

    private void HandleBlazorServerClick()
    {
        title = "Blazor Server";
        content = "Blazor Server generates dynamic contents on the server and sends the contents to the browser through the SignalR channel that is estalished between the page in the browser and the server.";
    }

    private void HandleBlazorWebAssemblyClick()
    {
        title = "Blazor WebAssembly";
        content = "Blazor WebAssembly runs completely within the web browser and generates dynamic contents directly at the front end.";
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
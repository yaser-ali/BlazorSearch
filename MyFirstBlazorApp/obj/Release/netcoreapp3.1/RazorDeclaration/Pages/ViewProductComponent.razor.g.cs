#pragma checksum "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\Pages\ViewProductComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "266445fc384d935503098f07ff8b77a22d8fded6"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/product/{id:int}")]
    public partial class ViewProductComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\Pages\ViewProductComponent.razor"
       
    private Product product;

    [Parameter]
    public int Id { get; set; }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        if (Id > 0)
            product = viewProduct.Execute(Id);

    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IViewProduct viewProduct { get; set; }
    }
}
#pragma warning restore 1591

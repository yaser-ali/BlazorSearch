#pragma checksum "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\Controls\ProductItemComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a6fd185bfdf78e078e79c37ecb317fca5a09316"
// <auto-generated/>
#pragma warning disable 1591
namespace MyFirstBlazorApp.Controls
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
    public partial class ProductItemComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\Controls\ProductItemComponent.razor"
 if (this.Product != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "tr");
            __builder.AddMarkupContent(2, "\n        ");
            __builder.OpenElement(3, "td");
            __builder.AddMarkupContent(4, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(5);
            __builder.AddAttribute(6, "href", 
#nullable restore
#line 5 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\Controls\ProductItemComponent.razor"
                             $"product/{Product.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\n                ");
                __builder2.AddContent(9, 
#nullable restore
#line 6 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\Controls\ProductItemComponent.razor"
                 Product.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(10, "\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "            \n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n        ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 9 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\Controls\ProductItemComponent.razor"
             Product.Type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n        ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 10 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\Controls\ProductItemComponent.razor"
             Product.Price.ToString("c")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n");
#nullable restore
#line 12 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\Controls\ProductItemComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\Controls\ProductItemComponent.razor"
       
    [Parameter]
    public Product Product { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

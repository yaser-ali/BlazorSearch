#pragma checksum "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\Pages\ViewProductComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6dee2bf2d55131869b18f8eb6651e883d0db2f4"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/product/{id:int}")]
    public partial class ViewProductComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Product Details</h3>\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card");
            __builder.AddAttribute(3, "style", "width: 30rem;");
            __builder.AddMarkupContent(4, "\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.AddMarkupContent(7, "\n        ");
            __builder.OpenElement(8, "img");
            __builder.AddAttribute(9, "src", 
#nullable restore
#line 9 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\Pages\ViewProductComponent.razor"
                   product.ImageLink

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n        ");
            __builder.OpenElement(11, "h5");
            __builder.AddAttribute(12, "class", "card-title");
            __builder.AddContent(13, 
#nullable restore
#line 10 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\Pages\ViewProductComponent.razor"
                                product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n        ");
            __builder.OpenElement(15, "h6");
            __builder.AddAttribute(16, "class", "card-subtitle mb-2 text-muted");
            __builder.AddContent(17, 
#nullable restore
#line 11 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\Pages\ViewProductComponent.razor"
                                                   product.Type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n        <hr>\n        ");
            __builder.OpenElement(19, "p");
            __builder.AddMarkupContent(20, "\n            Price: ");
            __builder.OpenElement(21, "label");
            __builder.AddAttribute(22, "style", "color:darkred");
            __builder.AddContent(23, 
#nullable restore
#line 14 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\Pages\ViewProductComponent.razor"
                                                 product.Price.ToString("c")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n        ");
            __builder.OpenElement(26, "p");
            __builder.AddAttribute(27, "class", "card-text");
            __builder.AddContent(28, 
#nullable restore
#line 16 "C:\Users\User\Desktop\MyFirstBlazorApp\MyFirstBlazorApp\Pages\ViewProductComponent.razor"
                              product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n<br>\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(32);
            __builder.AddAttribute(33, "href", "products");
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(35, "Back to Products");
            }
            ));
            __builder.CloseComponent();
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

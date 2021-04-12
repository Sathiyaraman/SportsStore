#pragma checksum "D:\ASP.NET Core MVC 3\SportsSln\SportsStore\Pages\Admin\Products.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01caae0c6f80ec102c71334b5f72e9be9928e850"
// <auto-generated/>
#pragma warning disable 1591
namespace SportsStore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "D:\ASP.NET Core MVC 3\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP.NET Core MVC 3\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ASP.NET Core MVC 3\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ASP.NET Core MVC 3\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\ASP.NET Core MVC 3\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\ASP.NET Core MVC 3\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using SportsStore.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/products")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Products : OwningComponentBase<IStoreRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-stripped table-bordered table-sm");
            __builder.AddMarkupContent(2, "<thead><tr><th>ID</th>\r\n            <th>Name</th>\r\n            <th>Category</th>\r\n            <th>Price</th>\r\n            <th>Stock Available</th></tr></thead>\r\n    ");
            __builder.OpenElement(3, "tbody");
#nullable restore
#line 16 "D:\ASP.NET Core MVC 3\SportsSln\SportsStore\Pages\Admin\Products.razor"
         if(ProductData?.Count() > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\ASP.NET Core MVC 3\SportsSln\SportsStore\Pages\Admin\Products.razor"
             foreach(Product p in ProductData)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "tr");
            __builder.OpenElement(5, "td");
            __builder.AddContent(6, 
#nullable restore
#line 21 "D:\ASP.NET Core MVC 3\SportsSln\SportsStore\Pages\Admin\Products.razor"
                         p.ProductId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n                    ");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 22 "D:\ASP.NET Core MVC 3\SportsSln\SportsStore\Pages\Admin\Products.razor"
                         p.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 23 "D:\ASP.NET Core MVC 3\SportsSln\SportsStore\Pages\Admin\Products.razor"
                         p.Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddAttribute(15, "class", "text-right");
            __builder.AddContent(16, 
#nullable restore
#line 24 "D:\ASP.NET Core MVC 3\SportsSln\SportsStore\Pages\Admin\Products.razor"
                                            p.Price.ToString("c")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddAttribute(19, "class", "text-right");
            __builder.AddContent(20, 
#nullable restore
#line 25 "D:\ASP.NET Core MVC 3\SportsSln\SportsStore\Pages\Admin\Products.razor"
                                            p.StockQuantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(23);
            __builder.AddAttribute(24, "class", "btn btn-info btn-sm");
            __builder.AddAttribute(25, "href", 
#nullable restore
#line 27 "D:\ASP.NET Core MVC 3\SportsSln\SportsStore\Pages\Admin\Products.razor"
                                                                    GetDetailsUrl(p.ProductId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(27, "Details");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "                  \r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(29);
            __builder.AddAttribute(30, "class", "btn btn-warning btn-sm");
            __builder.AddAttribute(31, "href", 
#nullable restore
#line 28 "D:\ASP.NET Core MVC 3\SportsSln\SportsStore\Pages\Admin\Products.razor"
                                                                       GetEditUrl(p.ProductId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(33, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "D:\ASP.NET Core MVC 3\SportsSln\SportsStore\Pages\Admin\Products.razor"
                                                                          e => DeleteProduct(p)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "D:\ASP.NET Core MVC 3\SportsSln\SportsStore\Pages\Admin\Products.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\ASP.NET Core MVC 3\SportsSln\SportsStore\Pages\Admin\Products.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(39, "<tr><td colspan=\"5\" class=\"text-center\">No Products</td></tr>");
#nullable restore
#line 39 "D:\ASP.NET Core MVC 3\SportsSln\SportsStore\Pages\Admin\Products.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(41);
            __builder.AddAttribute(42, "class", "btn btn-primary");
            __builder.AddAttribute(43, "href", "/admin/products/create");
            __builder.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(45, "Create");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "D:\ASP.NET Core MVC 3\SportsSln\SportsStore\Pages\Admin\Products.razor"
 
    public IStoreRepository Repository => Service;
    public IEnumerable<Product> ProductData { get; set; }
    
    protected async override Task OnInitializedAsync() 
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        ProductData = await Repository.Products.ToListAsync();
    }

    public async Task DeleteProduct(Product p){
        Repository.DeleteProduct(p);
        await UpdateData();
    }

    public string GetDetailsUrl(long Id) => $"/admin/products/details/{Id}";

    public string GetEditUrl(long Id) => $"/admin/products/edit/{Id}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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

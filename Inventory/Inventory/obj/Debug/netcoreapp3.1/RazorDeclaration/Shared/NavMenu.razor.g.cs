// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Inventory.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Inventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Inventory.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Ejercicios.BlazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Ejercicios.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.InputsOutputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Storages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Warehouses;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

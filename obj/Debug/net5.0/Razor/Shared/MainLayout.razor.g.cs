#pragma checksum "/Users/admin/RiderProjects/HighwayToHeaven/HighwayToHeaven/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f12c539b68073adc8a949c3d1a7a3950304898f"
// <auto-generated/>
#pragma warning disable 1591
namespace HighwayToHeaven.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/admin/RiderProjects/HighwayToHeaven/HighwayToHeaven/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/admin/RiderProjects/HighwayToHeaven/HighwayToHeaven/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/admin/RiderProjects/HighwayToHeaven/HighwayToHeaven/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/admin/RiderProjects/HighwayToHeaven/HighwayToHeaven/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/admin/RiderProjects/HighwayToHeaven/HighwayToHeaven/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/admin/RiderProjects/HighwayToHeaven/HighwayToHeaven/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/admin/RiderProjects/HighwayToHeaven/HighwayToHeaven/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/admin/RiderProjects/HighwayToHeaven/HighwayToHeaven/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/admin/RiderProjects/HighwayToHeaven/HighwayToHeaven/_Imports.razor"
using HighwayToHeaven;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/admin/RiderProjects/HighwayToHeaven/HighwayToHeaven/_Imports.razor"
using HighwayToHeaven.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-67yi6dd1qt");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-67yi6dd1qt");
            __builder.OpenComponent<HighwayToHeaven.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n\n    \n\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "content px-4");
            __builder.AddAttribute(10, "b-67yi6dd1qt");
            __builder.AddContent(11, 
#nullable restore
#line 11 "/Users/admin/RiderProjects/HighwayToHeaven/HighwayToHeaven/Shared/MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
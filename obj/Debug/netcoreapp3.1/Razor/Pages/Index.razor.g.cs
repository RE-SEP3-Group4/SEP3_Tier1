#pragma checksum "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4189d1b768b5310020cd6de633e5df994b913d29"
// <auto-generated/>
#pragma warning disable 1591
namespace SEP3_Tier1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\javic\source\repos\SEP3_Tier1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\javic\source\repos\SEP3_Tier1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\javic\source\repos\SEP3_Tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\javic\source\repos\SEP3_Tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\javic\source\repos\SEP3_Tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\javic\source\repos\SEP3_Tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\javic\source\repos\SEP3_Tier1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\javic\source\repos\SEP3_Tier1\_Imports.razor"
using SEP3_Tier1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\javic\source\repos\SEP3_Tier1\_Imports.razor"
using SEP3_Tier1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Index.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Index.razor"
using SEP3_Tier1.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    h1 , h5{\r\n     font-family: \"San Francisco\";\r\n     font-weight: 400;\r\n     src: url(\"https://applesocial.s3.amazonaws.com/assets/styles/fonts/sanfrancisco/sanfranciscodisplay-regular-webfont.woff\");\r\n    }\r\n\r\n       \r\n\r\n</style>\r\n");
            __builder.OpenElement(1, "h1");
            __builder.AddContent(2, "Hello, ");
            __builder.AddContent(3, 
#nullable restore
#line 14 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Index.razor"
            user.username

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " !");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.AddMarkupContent(6, @"<h5>Welcome to your new website, where you are going to be able to make a reservation to attend your fitness center. <br>
    First of all if you haven't make a reservation is to go to the <a href=""payments"">payments</a> page in order to make a reservation!</h5>");
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Index.razor"
      
    private User user;

    protected override void OnInitialized()
    {
        user = UserService.getInstance().GetUser();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "893346ae70bd7135694c822f99eeec5aacb492fb"
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
#line 1 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\_Imports.razor"
using SEP3_Tier1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\_Imports.razor"
using SEP3_Tier1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Register.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Register.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Register.razor"
using Data.Login;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h4 class=\"card-header\">Register</h4>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Register.razor"
                          user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Register.razor"
                                               OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n            \r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group");
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.AddMarkupContent(17, "<label>Username</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Register.razor"
                                        user.username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.username = __value, user.username))));
                __builder2.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.username));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n                ");
                __Blazor.SEP3_Tier1.Pages.Register.TypeInference.CreateValidationMessage_0(__builder2, 24, 25, 
#nullable restore
#line 17 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Register.razor"
                                          () => user.username

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(26, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group");
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.AddMarkupContent(31, "<label>Password</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "type", "password");
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Register.razor"
                                        user.password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.password = __value, user.password))));
                __builder2.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n                ");
                __Blazor.SEP3_Tier1.Pages.Register.TypeInference.CreateValidationMessage_1(__builder2, 39, 40, 
#nullable restore
#line 22 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Register.razor"
                                          () => user.password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.OpenElement(43, "button");
                __builder2.AddAttribute(44, "disabled", 
#nullable restore
#line 24 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Register.razor"
                               loading

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(45, "class", "btn btn-primary");
                __builder2.AddMarkupContent(46, "\r\n");
#nullable restore
#line 25 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Register.razor"
                 if (loading)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(47, "                    <span class=\"spinner-border spinner-border-sm mr-1\"></span>\r\n");
#nullable restore
#line 28 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Register.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(48, "                Register\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(50);
                __builder2.AddAttribute(51, "href", "account/login");
                __builder2.AddAttribute(52, "class", "btn btn-link");
                __builder2.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(54, "Cancel");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(56, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Register.razor"
       
    private User user;
    private bool loading;

    private async void OnValidSubmit()
    {
        loading = true;

        try
        {
            await UserManager.Register(user.username, user.password);
            NavigationManager.NavigateTo("/login");
        }
        catch(Exception e)
        {
            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
namespace __Blazor.SEP3_Tier1.Pages.Register
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

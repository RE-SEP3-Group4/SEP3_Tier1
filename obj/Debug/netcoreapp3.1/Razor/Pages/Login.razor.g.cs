#pragma checksum "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eca871c16b674c65e2cb9e51150586e42ab72fca"
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
#line 3 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Login.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Login.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Login.razor"
using Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-md-6 offset-md-3 mt-5");
            __builder.AddMarkupContent(2, "<div class=\"alert alert-info\">\r\n        Please fill username and password\r\n    </div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card");
            __builder.AddMarkupContent(5, "<h4 class=\"card-header\">Login</h4>\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Login.razor"
                                                                    user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Login.razor"
                                                                                         OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n                ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group");
                __builder2.AddMarkupContent(16, "<label>Username</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Login.razor"
                                                                                  usern

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usern = __value, usern))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => usern));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n                    ");
                __Blazor.SEP3_Tier1.Pages.Login.TypeInference.CreateMicrosoft_AspNetCore_Components_Forms_ValidationMessage_0(__builder2, 23, 24, 
#nullable restore
#line 20 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Login.razor"
                                                                                    () => user.username

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group");
                __builder2.AddMarkupContent(28, "<label>Password</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(29);
                __builder2.AddAttribute(30, "type", "password");
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Login.razor"
                                                                                  pass

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pass = __value, pass))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => pass));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n                    ");
                __Blazor.SEP3_Tier1.Pages.Login.TypeInference.CreateMicrosoft_AspNetCore_Components_Forms_ValidationMessage_1(__builder2, 36, 37, 
#nullable restore
#line 25 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Login.razor"
                                                                                    () => user.password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                ");
                __builder2.OpenElement(39, "button");
                __builder2.AddAttribute(40, "disabled", 
#nullable restore
#line 27 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Login.razor"
                                   loading

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(41, "class", "btn btn-primary");
#nullable restore
#line 28 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Login.razor"
                     if (loading)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(42, "<span class=\"spinner-border spinner-border-sm mr-1\"></span>");
#nullable restore
#line 31 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Login.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(43, "                    Login\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(45);
                __builder2.AddAttribute(46, "href", "register");
                __builder2.AddAttribute(47, "class", "btn btn-link");
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(49, "Register");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Login.razor"
           
        private User user = new User();
        private string usern, pass;
        private bool loading;
        private bool showAuthErrorTxt = false;
        private string authErrorTxt = "";

        private async void OnValidSubmit()
        {
            loading = true;
            try
            {
                UserService.getInstance().SetUser(await UserManager.Login(usern, pass));
                
       
                if (UserService.getInstance().GetUser().id != 0)
                {
                    NavigationManager.NavigateTo("/index");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                loading = false;
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
namespace __Blazor.SEP3_Tier1.Pages.Login
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMicrosoft_AspNetCore_Components_Forms_ValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMicrosoft_AspNetCore_Components_Forms_ValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

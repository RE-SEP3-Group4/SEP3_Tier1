#pragma checksum "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Users.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "306a3dd9b41cb806f02c1897553e499bf52f639f"
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
#line 2 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Users.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Users.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Users.razor"
using Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/users")]
    public partial class Users : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Users.razor"
 if(user.username == "admin") { 

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<h3>Users</h3>\r\n        ");
            __builder.AddMarkupContent(1, "<h3>Update an user</h3>\r\n        ");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Users.razor"
                          openPopUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Create ");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
#nullable restore
#line 10 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Users.razor"
             if (users == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>Loading...</em></p>");
#nullable restore
#line 15 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Users.razor"
            }
            else if (!users.Any())
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<p><em>No users in the system. Please add some.</em></p>");
#nullable restore
#line 21 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Users.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table");
            __builder.AddMarkupContent(11, "<thead><tr><th>Username</th>\r\n                            <th>Password</th>\r\n                            <th>securityLevel</th>\r\n                            <th>Remove</th></tr></thead>");
#nullable restore
#line 36 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Users.razor"
                     foreach (var user in users)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "tbody");
            __builder.OpenElement(13, "tr");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 41 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Users.razor"
                                     user.id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                                ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 42 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Users.razor"
                                     user.username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 43 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Users.razor"
                                     user.password

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 44 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Users.razor"
                                     user.securityLevel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n                                ");
            __builder.OpenElement(26, "td");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "btn btn-primary");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Users.razor"
                                                      (() => EditUser(user))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(30, "\r\n                                        EditUser\r\n                                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                                ");
            __builder.OpenElement(32, "td");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Users.razor"
                                                        (() => RemoveUser(user.id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(35, "<i class=\"oi oi-trash\" style=\"color: black\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Users.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 63 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Users.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 66 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Users.razor"
         if (popUp)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "modal");
            __builder.AddAttribute(38, "tabindex", "-1");
            __builder.AddAttribute(39, "style", "display:block");
            __builder.AddAttribute(40, "role", "dialog");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "modal-dialog");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "modal-content");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "modal-header");
            __builder.AddMarkupContent(47, "<h3 class=\"modal-title\">Edit User</h3>\r\n                            ");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "type", "button");
            __builder.AddAttribute(50, "class", "close");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Users.razor"
                                                                          ClosePopUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(52, "<span aria-hidden=\"true\">X</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                        ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "modal-body");
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "class", "form-control");
            __builder.AddAttribute(58, "type", "text");
            __builder.AddAttribute(59, "placeholder", "Username");
            __builder.AddAttribute(60, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 79 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Users.razor"
                                                                                                  user.username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.username = __value, user.username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                            ");
            __builder.OpenElement(63, "input");
            __builder.AddAttribute(64, "class", "form-control");
            __builder.AddAttribute(65, "type", "password");
            __builder.AddAttribute(66, "placeholder", "Password");
            __builder.AddAttribute(67, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 80 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Users.razor"
                                                                                                      user.password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.password = __value, user.password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                            ");
            __builder.OpenElement(70, "button");
            __builder.AddAttribute(71, "class", "btn btn-primary");
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Users.razor"
                                                                      SaveUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(73, " Save");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 89 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Users.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Users.razor"
         
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(74, "<p>ups</p>");
        }
        #pragma warning restore 1998
#nullable restore
#line 92 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Users.razor"
       
    private User user = UserService.GetUser();
    private bool popUp = false;
    private List<User> users;
    protected override async Task OnInitializedAsync()
    {
        users = await UserManager.GetAllUsers();
    }
    private async Task EditUser(User _user)
    {
        user = _user;
        var usser = _user.id;
        popUp = true;

    }
    private async Task SaveUser()
    {
        try
        {
            if (user.id != null)
            {
                var _user = user;
                _user.id = user.id;
                _user.username = user.username;
                _user.password = user.password;
                await UserManager.UpdateUser(user.id, user.username, user.password);
            }
            popUp = false;
            users = await UserManager.GetAllUsers();
        }
        catch (Exception ex)
        {
            String error;
            error = ex.GetBaseException().Message;
        }
    }
    private async Task RemoveUser(int userId)
    {
        await UserManager.DeleteUser(userId);
    }
    void openPopUp()
    {
        popUp = true;
    }

    void ClosePopUp()
    {
        popUp = false;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

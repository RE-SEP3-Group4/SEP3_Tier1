#pragma checksum "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Users.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7f89c7ea5756a3841c05c12c903598494cd6248"
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
#line 2 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Users.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Users.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Users.razor"
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
#line 5 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Users.razor"
 if(user.username == "admin") { 

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "        ");
            __builder.AddMarkupContent(1, "<h3>Users</h3>\r\n        ");
            __builder.AddMarkupContent(2, "<h3>Update an user</h3>\r\n        ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Users.razor"
                          openPopUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Create ");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 10 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Users.razor"
             if (users == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "                ");
            __builder.AddMarkupContent(10, "<p>\r\n                    <em>Loading...</em>\r\n                </p>\r\n");
#nullable restore
#line 15 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Users.razor"
            }
            else if (!users.Any())
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.AddMarkupContent(12, "<p>\r\n                    <em>No users in the system. Please add some.</em>\r\n                </p>\r\n");
#nullable restore
#line 21 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Users.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "                ");
            __builder.OpenElement(14, "table");
            __builder.AddAttribute(15, "class", "table");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.AddMarkupContent(17, @"<thead>

                        <tr>
                            <th>Username</th>
                            <th>Password</th>
                            <th>securityLevel</th>
                            <th>Remove</th>

                        </tr>

                    </thead>
");
#nullable restore
#line 36 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Users.razor"
                     foreach (var user in users)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "                        ");
            __builder.OpenElement(19, "tbody");
            __builder.AddMarkupContent(20, "\r\n\r\n                            ");
            __builder.OpenElement(21, "tr");
            __builder.AddMarkupContent(22, "\r\n                                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 41 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Users.razor"
                                     user.id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                                ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 42 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Users.razor"
                                     user.username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 43 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Users.razor"
                                     user.password

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                                ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 44 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Users.razor"
                                     user.securityLevel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n                                ");
            __builder.OpenElement(35, "td");
            __builder.AddMarkupContent(36, "\r\n                                    ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "btn btn-primary");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Users.razor"
                                                      (() => EditUser(user))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(40, "\r\n                                        EditUser\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                                ");
            __builder.OpenElement(43, "td");
            __builder.AddMarkupContent(44, "\r\n                                    ");
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Users.razor"
                                                        (() => RemoveUser(user.id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(47, "\r\n                                        <i class=\"oi oi-trash\" style=\"color: black\"></i>\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 61 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Users.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 63 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Users.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 66 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Users.razor"
         if (popUp)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "            ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "modal");
            __builder.AddAttribute(59, "tabindex", "-1");
            __builder.AddAttribute(60, "style", "display:block");
            __builder.AddAttribute(61, "role", "dialog");
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "modal-dialog");
            __builder.AddMarkupContent(65, "\r\n                    ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "modal-content");
            __builder.AddMarkupContent(68, "\r\n                        ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "modal-header");
            __builder.AddMarkupContent(71, "\r\n                            ");
            __builder.AddMarkupContent(72, "<h3 class=\"modal-title\">Edit User</h3>\r\n                            ");
            __builder.OpenElement(73, "button");
            __builder.AddAttribute(74, "type", "button");
            __builder.AddAttribute(75, "class", "close");
            __builder.AddAttribute(76, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Users.razor"
                                                                          ClosePopUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(77, "\r\n                                ");
            __builder.AddMarkupContent(78, "<span aria-hidden=\"true\">X</span>\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                        ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "modal-body");
            __builder.AddMarkupContent(83, "\r\n\r\n                            ");
            __builder.OpenElement(84, "input");
            __builder.AddAttribute(85, "class", "form-control");
            __builder.AddAttribute(86, "type", "text");
            __builder.AddAttribute(87, "placeholder", "Username");
            __builder.AddAttribute(88, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 79 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Users.razor"
                                                                                                  user.username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(89, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.username = __value, user.username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                            ");
            __builder.OpenElement(91, "input");
            __builder.AddAttribute(92, "class", "form-control");
            __builder.AddAttribute(93, "type", "password");
            __builder.AddAttribute(94, "placeholder", "Password");
            __builder.AddAttribute(95, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 80 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Users.razor"
                                                                                                      user.password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(96, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.password = __value, user.password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                            ");
            __builder.OpenElement(98, "button");
            __builder.AddAttribute(99, "class", "btn btn-primary");
            __builder.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Users.razor"
                                                                      SaveUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(101, " Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n");
#nullable restore
#line 89 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Users.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Users.razor"
         
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(107, "<p>ups</p>");
        }
        #pragma warning restore 1998
#nullable restore
#line 92 "C:\Users\joaob\source\repos\SEP3_Tier1\SEP3_Tier1\Pages\Users.razor"
       
    private User user = UserService.getInstance().GetUser();
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

// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 94 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Users.razor"
       
    private User user = UserService.getInstance().GetUser();
    private bool popUp = false;
    private List<User> users;
    private List<User> toShow;
    protected override async Task OnInitializedAsync()
    {
        users = await UserManager.GetAllUsers();
        toShow = users;
    }
    private async Task EditUser(User _user)
    {
        _user = user;
        var usser = _user;
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
    private void FilterById(ChangeEventArgs args)
    {
        int? filterById = null;
        try
        {
            filterById = int.Parse(args.Value.ToString());
        }
        catch (Exception e) { }
        if (filterById != null)
        {
            toShow = users.Where(t => t.id == filterById).ToList();
        }
        else
        {
            toShow = users;
        }
    }
    private void FilterByUsername(ChangeEventArgs args)
    {
        string filterByUsername = null;
        try
        {
            filterByUsername = args.Value.ToString();
        }
        catch (Exception e) { }
        if (filterByUsername != null)
        {
            toShow = users.Where(t => t.username.Contains(filterByUsername)).ToList();
        }
        else
        {
            toShow = users;
        }
    }
    private void FilterByPassword(ChangeEventArgs args)
    {
        string filterByPassword = null;
        try
        {
            filterByPassword = args.Value.ToString();
        }
        catch (Exception e) { }
        if (filterByPassword != null)
        {
            toShow = users.Where(t => t.password.Contains(filterByPassword)).ToList();
        }
        else
        {
            toShow = users;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

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
#line 2 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
using Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bookings")]
    public partial class Bookings : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
       
    private bool loading;
    private List<Reservation> reservations;
    protected override async Task OnInitializedAsync()
    {
        loading = true;
        reservations = await ReservationManager.GetReservations(UserService.GetUser().id);
        loading = false;
    }
    private async Task DeleteBooking(Reservation reservation) {

        await ReservationManager.DeleteReservation(reservation);
        reservations = await ReservationManager.GetReservations(UserService.GetUser().id);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82c2eb8226505924a173b3f8acf5b2881ce9c374"
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
            __builder.AddMarkupContent(0, "<style>\r\n    #btn-class {\r\n        display: block;\r\n        margin: auto;\r\n    }\r\n    #table_res{\r\n        margin-left:-20px;\r\n    }\r\n    \r\n</style>\r\n");
            __builder.AddMarkupContent(1, "<h3>Welcome to your reservations!</h3>\r\n");
            __builder.AddMarkupContent(2, "<h5>In this page you will be able to see and manage your reservations.<br> In order to so first you will need to make a suscription to the gym. If you haven\'t done it please follow this <a href=\"payments\">link</a></h5>");
#nullable restore
#line 17 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
 if (payments != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "btn btn-primary");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
                                              openPopUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, "Create");
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card mt-2");
            __builder.OpenElement(9, "h4");
            __builder.AddAttribute(10, "class", "card-header");
            __builder.AddContent(11, "Bookings of ");
            __builder.AddContent(12, 
#nullable restore
#line 23 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
                                         user.username

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, " with id ");
            __builder.AddContent(14, 
#nullable restore
#line 23 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
                                                                user.id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "card-body");
#nullable restore
#line 26 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
         if (loading)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(18, "<div class=\"spinner-border spinner-border-sm\"></div>");
#nullable restore
#line 29 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
         if (reservations != null)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "ul");
            __builder.OpenElement(20, "table");
            __builder.AddAttribute(21, "id", "table_res");
            __builder.AddAttribute(22, "class", "table table-bordered table-striped");
#nullable restore
#line 34 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
                     foreach (var reservation in reservations)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "tr");
            __builder.OpenElement(24, "td");
            __builder.AddAttribute(25, "class", "table-info");
            __builder.AddContent(26, "Date of reservation: ");
            __builder.AddContent(27, 
#nullable restore
#line 37 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
                                                                         reservation.date.Insert(2, "/").Insert(5, "/")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n                            ");
            __builder.OpenElement(29, "td");
            __builder.AddAttribute(30, "class", "table-info");
            __builder.AddContent(31, "Time of reservation: ");
            __builder.AddContent(32, 
#nullable restore
#line 39 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
                                                                         reservation.hour.Insert(2, ":")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n                            ");
            __builder.OpenElement(34, "td");
            __builder.AddAttribute(35, "class", "table-danger");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "id", "btn-class");
            __builder.AddAttribute(38, "class", "btn btn-danger");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
                                                                                        () => DeleteBooking(reservation)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 49 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
 if (popUp)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "modal");
            __builder.AddAttribute(43, "tabindex", "-1");
            __builder.AddAttribute(44, "style", "display:block");
            __builder.AddAttribute(45, "role", "dialog");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "modal-dialog");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "modal-content");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "modal-header");
            __builder.AddMarkupContent(52, "<h3 class=\"modal-title\">Create payment</h3>\r\n                    ");
            __builder.OpenElement(53, "button");
            __builder.AddAttribute(54, "type", "button");
            __builder.AddAttribute(55, "class", "close");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
                                                                  ClosePopUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(57, "<span aria-hidden=\"true\">X</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "modal-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(61);
            __builder.AddAttribute(62, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 64 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
                                     reservation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "form-group");
                __builder2.OpenElement(66, "label");
                __builder2.AddAttribute(67, "for", "Name");
                __builder2.AddAttribute(68, "class", "control-label");
                __builder2.AddContent(69, "Reservation for ");
                __builder2.AddContent(70, 
#nullable restore
#line 66 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
                                                                                     user.username

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(71, " with id ");
                __builder2.AddContent(72, 
#nullable restore
#line 66 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
                                                                                                            user.id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                            ");
                __Blazor.SEP3_Tier1.Pages.Bookings.TypeInference.CreateInputDate_0(__builder2, 74, 75, "date", 76, "form-control", 77, 
#nullable restore
#line 67 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
                                                                                     dateTime

#line default
#line hidden
#nullable disable
                , 78, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dateTime = __value, dateTime)), 79, () => dateTime);
                __builder2.AddMarkupContent(80, "\r\n                            ");
                __builder2.OpenElement(81, "input");
                __builder2.AddAttribute(82, "type", "time");
                __builder2.AddAttribute(83, "class", "form-control oi-timer");
                __builder2.AddAttribute(84, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 68 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
                                                                                          hourTime

#line default
#line hidden
#nullable disable
                , format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(85, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => hourTime = __value, hourTime, format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n                        ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "form-group");
                __builder2.OpenElement(89, "button");
                __builder2.AddAttribute(90, "type", "button");
                __builder2.AddAttribute(91, "class", "btn btn-primary");
                __builder2.AddAttribute(92, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
                                                                                    () => { CreateBooking(); ClosePopUp(); }

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(93, "Save");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n                            ");
                __builder2.OpenElement(95, "button");
                __builder2.AddAttribute(96, "type", "button");
                __builder2.AddAttribute(97, "class", "btn btn-danger");
                __builder2.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
                                                                                   () => cancel()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(99, "Cancel");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 81 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "C:\Users\javic\source\repos\SEP3_Tier1\Pages\Bookings.razor"
       
    private User user;
    private bool loading, popUp = false;
    private DateTime dateTime, hourTime;
    private string date, hour;
    private Reservation reservation = new Reservation();
    private List<Payment> payments;

    private List<Reservation> reservations;
    protected override async Task OnInitializedAsync()
    {
        user = UserService.getInstance().GetUser();
        loading = true;
        reservations = await ReservationManager.GetReservations(user.id);
        payments = await PaymentManager.GetPayments(user.id);
        loading = false;

    }

    private async void CreateBooking()
    {
        date = dateTime.ToString("ddMMyyyy");
        hour = hourTime.ToString("HHmm");
        await ReservationManager.CreateReservation(user.id, date, hour);
    }
    private async void  openPopUp()
    {
        payments = await PaymentManager.GetPayments(user.id);
        if (payments != null) {
            popUp = true;
        }

    }
    private void ClosePopUp()
    {

        popUp = false;
    }
    void cancel()
    {

        popUp = false;
    }
    private async void DeleteBooking(Reservation reservation)
    {
        reservations.Remove(reservation);
        await ReservationManager.DeleteReservation(reservation);
        reservations = await ReservationManager.GetReservations(user.id);
    }



#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.SEP3_Tier1.Pages.Bookings
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "type", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

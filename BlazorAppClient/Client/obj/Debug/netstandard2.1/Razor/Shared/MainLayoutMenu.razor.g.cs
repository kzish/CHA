#pragma checksum "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Shared\MainLayoutMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9638c282d04050bcc35932cee2c670de5aa4d6b1"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAppClient.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\_Imports.razor"
using BlazorAppClient.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\_Imports.razor"
using BlazorAppClient.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\_Imports.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\_Imports.razor"
using CurrieTechnologies.Razor.SweetAlert2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Shared\MainLayoutMenu.razor"
using System.Web;

#line default
#line hidden
#nullable disable
    public partial class MainLayoutMenu : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-lg navbar-light bg-light");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href=\"/\">\r\n        <img src=\"/assets/img/logo.png\" style=\"height:auto;width:184px!important;\">\r\n    </a>\r\n    ");
            __builder.AddMarkupContent(4, "<button class=\"navbar-toggler\" type=\"button\" data-toggle=\"collapse\" data-target=\"#navbarColor03\" aria-controls=\"navbarColor03\" aria-expanded=\"false\" aria-label=\"Toggle navigation\">\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    </button>\r\n\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "collapse navbar-collapse");
            __builder.AddAttribute(7, "id", "navbarColor03");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.AddMarkupContent(9, @"<ul class=""navbar-nav mr-auto"">
            <li class=""nav-item active"">
                <a class=""nav-link"" href=""/"">Menu</a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/Help"">Help</a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/About"">About</a>
            </li>
        </ul>
        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(10);
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "nav-item dropdown");
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.OpenElement(16, "a");
                __builder2.AddAttribute(17, "class", "nav-link dropdown-toggle");
                __builder2.AddAttribute(18, "data-toggle", "dropdown");
                __builder2.AddAttribute(19, "href", "#");
                __builder2.AddAttribute(20, "role", "button");
                __builder2.AddAttribute(21, "aria-haspopup", "true");
                __builder2.AddAttribute(22, "aria-expanded", "false");
                __builder2.AddMarkupContent(23, "\r\n                    ");
                __builder2.OpenComponent<BlazorAppClient.Client.Shared.Loading>(24);
                __builder2.AddAttribute(25, "isloading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Shared\MainLayoutMenu.razor"
                                         isloading

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddContent(26, 
#nullable restore
#line 30 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Shared\MainLayoutMenu.razor"
                                                       context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(27, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "dropdown-menu");
                __builder2.AddMarkupContent(31, "\r\n                    ");
                __builder2.AddMarkupContent(32, "<a class=\"dropdown-item\" href=\"#\">Account</a>\r\n                    <div class=\"dropdown-divider\"></div>\r\n                    ");
                __builder2.OpenElement(33, "a");
                __builder2.AddAttribute(34, "class", "dropdown-item");
                __builder2.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Shared\MainLayoutMenu.razor"
                                                      (()=>  Logout())

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(36, "\r\n                    Log out\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "bg_menu");
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.OpenElement(46, "main");
            __builder.AddAttribute(47, "class", "page-content pt-2");
            __builder.AddMarkupContent(48, "\r\n        <div id=\"overlay\" class=\"overlay\"></div>\r\n        ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "container-fluid p-5");
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.AddContent(52, 
#nullable restore
#line 47 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Shared\MainLayoutMenu.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Shared\MainLayoutMenu.razor"
 

    public bool isloading = false;
    protected override async Task OnAfterRenderAsync(bool first_render)
    {
        //init the sidebar js
        if (first_render)
            await js.InvokeAsync<string>("init");
    }


    async Task Logout()
    {
        isloading = true;
        var response1 = await http_client.PostAsync("_Auth/Logoff", null);
        var response2 = await response1.Content.ReadAsStringAsync();
        if (response2.ToLower() == "logout success")
        {
            navigation_manager.NavigateTo("Auth/Login",true);
        }
        isloading = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http_client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation_manager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SweetAlertService Swal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authentication_state_provider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService local_storage { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Shared\Pagination.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48f23816530856a28b4631ba2951e708deb2b8c7"
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
    public partial class Pagination : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "aria-label", "Page navigation example");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "pagination justify-content-center");
            __builder.AddMarkupContent(5, "\n");
#nullable restore
#line 3 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Shared\Pagination.razor"
         foreach (var link in _links)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "li");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Shared\Pagination.razor"
                          () => OnSelectedPage(link)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "style", "cursor: pointer;");
            __builder.AddAttribute(10, "class", "page-item" + " " + (
#nullable restore
#line 5 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Shared\Pagination.razor"
                                                                                                  link.Enabled ? null : "disabled"

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 5 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Shared\Pagination.razor"
                                                                                                                                      link.Active ? "active" : null

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(11, "\n                ");
            __builder.OpenElement(12, "span");
            __builder.AddAttribute(13, "class", "page-link");
            __builder.AddAttribute(14, "href", "#");
            __builder.AddContent(15, 
#nullable restore
#line 6 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Shared\Pagination.razor"
                                                  link.Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n");
#nullable restore
#line 8 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Shared\Pagination.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Shared\Pagination.razor"
 

    [Parameter]
    public BlazorAppClient.Shared.PaginationMetaData MetaData { get; set; }
    [Parameter]
    public int Spread { get; set; }
    [Parameter]
    public EventCallback<int> SelectedPage { get; set; }

    private List<BlazorAppClient.Shared.PagingLink> _links;



    protected override void OnParametersSet()
    {
        CreatePaginationLinks();
    }


    private void CreatePaginationLinks()
    {
        //
        _links = new List<BlazorAppClient.Shared.PagingLink>();
        //add prev
        _links.Add(new BlazorAppClient.Shared.PagingLink(MetaData.CurrentPage, MetaData.HasPrevious, "Prev"));

        //add inbetween
        for (int i = 1; i <= MetaData.TotalPages; i++)
        {
            if ((i >= MetaData.CurrentPage - Spread) && (i <= MetaData.CurrentPage + Spread))
            {
                _links.Add(new BlazorAppClient.Shared.PagingLink(i, true, i.ToString()) { Active = MetaData.CurrentPage == i });
            }
        }
        //add next
        _links.Add(new BlazorAppClient.Shared.PagingLink(MetaData.CurrentPage + 1, MetaData.HasNext, "Next"));
    }

    private async Task OnSelectedPage(BlazorAppClient.Shared.PagingLink link)
    {
        if (link.Page == MetaData.CurrentPage || !link.Enabled)
            return;

        MetaData.CurrentPage = link.Page;
        await SelectedPage.InvokeAsync(link.Page);
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SweetAlertService Swal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authentication_state_provider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService local_storage { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3494577bcb00335dfc07851ff128b4415b1cb33"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAppClient.Client.Pages.Course
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
#line 5 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CourseWork/{course_id}")]
    public partial class CourseWork : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 11 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
 if (course == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-12");
            __builder.AddAttribute(6, "style", "display:flex;align-content:center;justify-content:center;");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenComponent<BlazorAppClient.Client.Shared.Loading>(8);
            __builder.AddAttribute(9, "isloading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                              50

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                                         50

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.AddMarkupContent(15, "<div class=\"row\">\r\n        <div class=\"col-md-12\" style=\"display:flex;align-content:center;justify-content:center;\">\r\n            <p style=\"clear:both;\">Loading course...</p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 23 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "page-wrapper white-theme sidebar-bg. bg1. toggled");
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "nav");
            __builder.AddAttribute(21, "id", "sidebar");
            __builder.AddAttribute(22, "class", "sidebar-wrapper");
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "sidebar-content");
            __builder.AddMarkupContent(26, "\r\n                \r\n                ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "sidebar-item. sidebar-brand");
            __builder.AddAttribute(29, "style", "color:black!important;");
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "href", "/Course/" + (
#nullable restore
#line 31 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                      course.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(33, "<i title=\"back\" class=\"fas fa-sign-out-alt flip_180\" style=\"color:black;font-size:22px;\"></i>");
            __builder.CloseElement();
            __builder.OpenElement(34, "a");
            __builder.AddAttribute(35, "style", "color:black;");
            __builder.AddAttribute(36, "title", 
#nullable restore
#line 31 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                                                                                                                                                                  course.CourseName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(37, 
#nullable restore
#line 31 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                                                                                                                                                                                       course.CourseName.Length >= 10 ? course.CourseName.Substring(0, 9) + "..." : course.CourseName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(38, " / CW");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                \r\n                \r\n                \r\n                \r\n                ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "sidebar-item.");
            __builder.AddMarkupContent(43, "\r\n\r\n                    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "id", "html_course_work");
            __builder.AddAttribute(46, "class", "demo");
            __builder.AddMarkupContent(47, "\r\n                        ");
            __builder.OpenElement(48, "ul");
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 53 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                             foreach (var topic in course.MCourseTopic.OrderBy(i => i.Sequence))
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "                                ");
            __builder.OpenElement(51, "li");
            __builder.AddAttribute(52, "data-jstree", "{" + " \"opened\"" + " :" + " " + (
#nullable restore
#line 55 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                                                course_counter == 0 ? "true" : "false"

#line default
#line hidden
#nullable disable
            ) + " }");
            __builder.AddMarkupContent(53, "\r\n                                    ");
            __builder.AddContent(54, 
#nullable restore
#line 56 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                     topic.Topic

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(55, "\r\n                                    ");
            __builder.OpenElement(56, "ul");
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 58 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                         foreach (var page_ in course.MCourseMaterial.Where(i => i.MCourseTopicIdFk == topic.Id).OrderBy(i => i.PageSequence))
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, "                                            ");
            __builder.OpenElement(59, "li");
            __builder.AddAttribute(60, "data-jstree", "{" + " \"selected\"" + " :" + " false,\"PageData\":\"" + (
#nullable restore
#line 60 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                                                                               page_.PageData

#line default
#line hidden
#nullable disable
            ) + "\"" + " }");
            __builder.AddMarkupContent(61, "\r\n                                                ");
            __builder.AddContent(62, 
#nullable restore
#line 61 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                                 page_.PageTitle

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(63, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n");
#nullable restore
#line 63 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(65, "                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
            __builder.AddContent(68, 
#nullable restore
#line 66 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                  course_counter = course_counter + 1

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 66 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                                                      
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(69, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n        \r\n        ");
            __builder.OpenElement(75, "main");
            __builder.AddAttribute(76, "class", "page-content pt-2");
            __builder.AddMarkupContent(77, "\r\n            <div id=\"overlay\" class=\"overlay\"></div>\r\n            ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "container-fluid p-5");
            __builder.AddMarkupContent(80, "\r\n                ");
            __builder.AddContent(81, 
#nullable restore
#line 77 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                  (MarkupString)PageData

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(82, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n");
#nullable restore
#line 82 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
       
    [Parameter]
    public string course_id { get; set; }
    private int course_counter = 0;
    private static string PageData = string.Empty;
    private bool tree_initialized = false;


    private BlazorAppClient.Shared.Models.MCourse course = null;

    protected override async Task OnParametersSetAsync()
    {
        base.OnParametersSet();
        PageData = string.Empty;
        await StartCourse();
    }

    protected override async Task OnAfterRenderAsync(bool first_render)
    {
        if (first_render)
        {

            await js.InvokeAsync<string>("initInstance", DotNetObjectReference.Create(this));
            StateHasChanged();
        }
        if (!tree_initialized)
        {
            await js.InvokeAsync<string>("initTree");
        }

    }

    private async Task start()
    {
        await js.InvokeAsync<string>("initTree", DotNetObjectReference.Create(this));
    }

    private async Task<BlazorAppClient.Shared.CurrentUser> GetCurrentUser()
    {
        dynamic user_string = await local_storage.GetItemAsStringAsync("current_user");
        var current_user = JsonConvert.DeserializeObject<BlazorAppClient.Shared.CurrentUser>(user_string);
        return current_user;
    }


    [JSInvokable]
    public void RenderContent(string page_data)
    {
        tree_initialized = true;
        if (!string.IsNullOrEmpty(page_data))
        {
            var base64EncodedBytes = System.Convert.FromBase64String(page_data);
            PageData = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            //PageData = page_data;
            StateHasChanged();
        }
    }

    public async Task StartCourse()
    {
        try
        {
            var current_user = await GetCurrentUser();
            var response1 = await http_client
                   .GetAsync($"Courses/StartCourse?asp_net_user_id={HttpUtility.UrlEncode(current_user.user_id)}&course_id={course_id}");
            var response2 = await response1.Content.ReadAsStringAsync();
            Console.WriteLine(response2);
            dynamic json = JsonConvert.DeserializeObject(response2);
            if (json.res == "ok")
            {
                course = JsonConvert.DeserializeObject<BlazorAppClient.Shared.Models.MCourse>(json.data.ToString());
            }
            else
            {
                toastService.ShowError(json.data.ToString(), "Error");
            }
        }
        catch (Exception ex)
        {
            toastService.ShowError(ex.Message, "Error");
        }
        finally
        {
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http_client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SweetAlertService Swal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authentication_state_provider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService local_storage { get; set; }
    }
}
#pragma warning restore 1591

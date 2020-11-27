#pragma checksum "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43bc68d10cefda845718406a6d6243c3fc93603b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 170 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
       
    [Parameter]
    public string course_id { get; set; }
    //private int course_percentage_complete { get; set; }
    private int course_counter = 0;
    private static string PageData = string.Empty;
    private static string page_id = string.Empty;
    private static string topic_id = string.Empty;
    private static bool has_questions = false;//does this course page/material have any questions?load questions from server
    private bool tree_initialized = false;
    private bool loading = false;
    private List<BlazorAppClient.Shared.Models.MUsersAnswersCourseMaterial> completed_questions_answers = null;

    private BlazorAppClient.Shared.Models.MCourse course = null;

    private List<BlazorAppClient.Shared.Models.MCourseWorkQuestion> course_material_questions = null;

    protected override async Task OnParametersSetAsync()
    {
        base.OnParametersSet();
        PageData = string.Empty;
        page_id = string.Empty;
        topic_id = string.Empty;
        has_questions = false;
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


    protected override void OnInitialized()
    {
        base.OnInitialized();
        state.OnChange += StateHasChanged;
    }

    public void Dispose()
    {
        state.OnChange -= StateHasChanged;
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
    public async Task RenderContent(string _page_id, string page_data, string _topic_id, string _has_questions)
    {
        tree_initialized = true;
        has_questions = false;
        course_material_questions = null;
        if (!string.IsNullOrEmpty(page_data))
        {
            var base64EncodedBytes = System.Convert.FromBase64String(page_data);
            PageData = System.Text.Encoding.ASCII.GetString(base64EncodedBytes);
            page_id = _page_id;
            topic_id = _topic_id;
            has_questions = bool.Parse(_has_questions.ToLower());
            if (has_questions)
            {
                await LoadQuestionsForCourseMaterial();
            }
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
            dynamic json = JsonConvert.DeserializeObject(response2);
            if (json.res.ToString() == "ok")
            {
                course = JsonConvert.DeserializeObject<BlazorAppClient.Shared.Models.MCourse>(json.data.ToString());
                List<BlazorAppClient.Shared.Models.MCourseWorkProgress> completed_pages = JsonConvert.DeserializeObject<List<BlazorAppClient.Shared.Models.MCourseWorkProgress>>(json.completed_pages.ToString());
                //
                state.SetCourse(course);
                state.SetCompletedPages(completed_pages);
                //course_percentage_complete = (state.completed_pages.Count / state.course.MCourseMaterial.Count) * 100;
                //StateHasChanged();
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



    /// <summary>
    /// update the course progress for this user
    /// user can only take exam when progress is completed
    /// </summary>
    private async Task SaveProgress()
    {
        loading = true;
        StateHasChanged();
        try
        {
            var current_user = await GetCurrentUser();
            var content = new StringContent($"asp_net_user_id={current_user.user_id}&page_id={page_id}&course_id={course.Id}&topic_id={topic_id}",
               System.Text.Encoding.UTF8,
               "application/x-www-form-urlencoded");
            var response1 = await http_client.PostAsync("/Courses/UpdateCourseProgress", content);
            var response2 = await response1.Content.ReadAsStringAsync();
            dynamic json_data = JsonConvert.DeserializeObject(response2);

            if (json_data.res.ToString() == "ok")
            {
                List<BlazorAppClient.Shared.Models.MCourseWorkProgress> completed_pages = JsonConvert.DeserializeObject<List<BlazorAppClient.Shared.Models.MCourseWorkProgress>>(json_data.completed_pages.ToString());
                state.SetCompletedPages(completed_pages);
                //course_percentage_complete = (int)(((decimal)state.completed_pages.Count / (decimal)state.course.MCourseMaterial.Count) * 100);
                StateHasChanged();
            }
            else
            {
                toastService.ShowError(json_data.data.ToString());
            }
        }
        catch (Exception ex)
        {
            toastService.ShowError(ex.Message);
        }
        finally
        {
            loading = false;
            StateHasChanged();
        }
    }


    /// <summary>
    /// load the questions and answers for the selected page/course material
    /// load also the completed answers
    /// </summary>
    /// <returns></returns>
    public async Task LoadQuestionsForCourseMaterial()
    {
        try
        {
            var current_user = await GetCurrentUser();
            var response1 = await http_client
                   .GetAsync($"Courses/LoadQuestionsForCourseMaterial?asp_net_user_id={HttpUtility.UrlEncode(current_user.user_id)}&course_material_id={page_id}&course_id={course_id}");
            var response2 = await response1.Content.ReadAsStringAsync();
            dynamic json = JsonConvert.DeserializeObject(response2);
            if (json.res.ToString() == "ok")
            {
                course_material_questions = JsonConvert.DeserializeObject<List<BlazorAppClient.Shared.Models.MCourseWorkQuestion>>(json.data.ToString());
                completed_questions_answers = JsonConvert.DeserializeObject<List<BlazorAppClient.Shared.Models.MUsersAnswersCourseMaterial>>(json.completed_questions_answers.ToString());
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private State state { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http_client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SweetAlertService Swal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authentication_state_provider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService local_storage { get; set; }
    }
}
#pragma warning restore 1591

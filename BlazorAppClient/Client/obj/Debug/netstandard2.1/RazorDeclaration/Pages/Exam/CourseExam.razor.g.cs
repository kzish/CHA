#pragma checksum "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93f68e5494f7067322f55195e600b5cbd49cba3b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAppClient.Client.Pages.Exam
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
#line 5 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Exam/{course_id}")]
    public partial class CourseExam : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 143 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
       
    [Parameter]
    public string course_id { get; set; }
    private int course_counter = 0;
    private static string PageData = string.Empty;
    private bool tree_initialized = false;
    private BlazorAppClient.Shared.Models.MQuestion question = null;
    private bool show_answer = false;
    private List<string> client_side_ordered_questions = new List<string>();


    private BlazorAppClient.Shared.Models.MCourse course = null;

    protected override async Task OnParametersSetAsync()
    {
        base.OnParametersSet();
        PageData = string.Empty;
        await StartExam();
    }

    protected override void OnInitialized()
    {
        state.OnChange += StateHasChanged;
    }

    public void Dispose()
    {
        state.OnChange -= StateHasChanged;
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

    private async Task<BlazorAppClient.Shared.CurrentUser> GetCurrentUser()
    {
        dynamic user_string = await local_storage.GetItemAsStringAsync("current_user");
        var current_user = JsonConvert.DeserializeObject<BlazorAppClient.Shared.CurrentUser>(user_string);
        return current_user;
    }

    /// <summary>
    /// dont render content unless previous question has been answered
    /// this ensures questions are answered in chronological order
    /// skip this check for the first question
    ///
    /// </summary>
    /// <param name="page_data"></param>
    /// <param name="question_id"></param>
    [JSInvokable]
    public void RenderContent(string page_data, string question_id)
    {
        tree_initialized = true;

        if (!string.IsNullOrEmpty(page_data))
        {
            bool is_first_question = client_side_ordered_questions.First() == question_id;
            //toastService.ShowInfo("is_first_question: " + is_first_question);
            if (!is_first_question)
            {
                //current position
                var pos = client_side_ordered_questions.IndexOf(question_id);
                //toastService.ShowInfo("pos: " + pos);
                //toastService.ShowInfo("state.answers.Count: " + state.answers.Count);
                //go back one if its present render
                //else alert you must completed previous question first
                if (state.answers.Count < (pos))
                {
                    toastService.ShowError("You must answer previous question first");
                    return;
                }
            }

            var base64EncodedBytes = System.Convert.FromBase64String(page_data);
            PageData = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            question = course.MQuestion.Where(i => i.Id == question_id).First();
            show_answer = state.answers.Where(i => i.QuestionIdFk == question_id).Any();
            StateHasChanged();
        }
    }

    public async Task StartExam()
    {
        try
        {
            var current_user = await GetCurrentUser();
            var response1 = await http_client
                   .GetAsync($"Courses/StartExam?asp_net_user_id={HttpUtility.UrlEncode(current_user.user_id)}&course_id={course_id}");
            var response2 = await response1.Content.ReadAsStringAsync();
            dynamic json = JsonConvert.DeserializeObject(response2);
            if (json.res == "ok")
            {
                course = JsonConvert.DeserializeObject<BlazorAppClient.Shared.Models.MCourse>(json.data.ToString());
                var users_answers = JsonConvert.DeserializeObject<List<BlazorAppClient.Shared.Models.MUsersAnswers>>(json.users_answers.ToString());
                string is_course_work_completed = json.is_course_work_completed.ToString();
                if(is_course_work_completed.ToLower()=="false")
                {
                    //toastService.ShowError("You have not completed all the course work and questions", "Error");
                    //navigate back
                    nav.NavigateTo($"/Course/{course_id}?msg_type=error&msg={HttpUtility.UrlEncode("You have not completed all the course work and questions")}");

                }

                state.SetCourse(course);
                state.SetAnswers(users_answers);
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private State state { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http_client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SweetAlertService Swal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authentication_state_provider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService local_storage { get; set; }
    }
}
#pragma warning restore 1591

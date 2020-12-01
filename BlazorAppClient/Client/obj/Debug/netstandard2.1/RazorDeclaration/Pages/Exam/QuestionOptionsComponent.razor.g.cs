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
    public partial class QuestionOptionsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\QuestionOptionsComponent.razor"
       

    [Parameter]
    public BlazorAppClient.Shared.Models.MQuestion question { get; set; }

    [Parameter]
    public BlazorAppClient.Shared.Models.MCourse course { get; set; }

    [Parameter]
    public List<BlazorAppClient.Shared.Models.MQuestionAnswerOptions> question_answers_options { get; set; }


    public List<string> selected_answers = new List<string>();
    private string text_answer = string.Empty;
    //
    private string text_based_question_id = "A011ED2A-AE61-43BB-BD01-EEFD428DE0FE";
    private string radio_based_question_id = "C277D965-1573-43C7-8E23-81AD4AAAB6F9";
    private string checkbox_based_question_id = "04E2AB58-1885-411E-BCB5-0A14894571E9";
    //only show the answer if the question has been answered
    private bool loading { get; set; } = false;

    protected override void OnInitialized()
    {
        state.OnChange += StateHasChanged;
    }

    public void Dispose()
    {
        state.OnChange -= StateHasChanged;
    }

    protected override void OnParametersSet()
    {
        //show the existing answers if there are there only on parameter set
        base.OnParametersSet();
    }

    private async Task<BlazorAppClient.Shared.CurrentUser> GetCurrentUser()
    {
        dynamic user_string = await local_storage.GetItemAsStringAsync("current_user");
        var current_user = JsonConvert.DeserializeObject<BlazorAppClient.Shared.CurrentUser>(user_string);
        return current_user;
    }


    private async Task ConfirmSubmit()
    {
        //user has confirmed answer
        var confirm = await js.InvokeAsync<bool>("confirm", new[] { "Confirm Answer", "Are you sure?" });
        Console.WriteLine(confirm);
        if (confirm)
        {

            if (selected_answers.Count == 0 && string.IsNullOrEmpty(text_answer))
            {
                toastService.ShowError("Provide and answer");
                return;
            }
            var current_user = await GetCurrentUser();
            if (question.EQuestionTypeIdFk == text_based_question_id)//text based answer
            {
                if (string.IsNullOrEmpty(text_answer))
                {
                    toastService.ShowError("Answer is empty");
                    return;
                }
                else
                {
                    // -- for now all text based questions are correct by default, the admin will mark this type of question via the continous assesment
                    //todo: improve on text based answer comparison
                    //compare text asnwer with users answer
                    //upload this answer to the server
                    //taken from https://github.com/feature23/StringSimilarity.NET
                    //also https://github.com/tylerjensen/FuzzyStrings

                    var nlevenshtien = new F23.StringSimilarity.NormalizedLevenshtein();
                    var correct_text_answer = question.MQuestionAnswerOptions
                                                .Where(i => i.IsCorrectAnswer)
                                                .Select(i => i.OptionText)
                                                .FirstOrDefault();
                    var score3 = nlevenshtien.Distance(text_answer, correct_text_answer);
                    var users_answer = new BlazorAppClient.Shared.Models.MUsersAnswers()
                    {
                        CourseIdNfk = question.MCourseIdFk,
                        TopicIdNfk = question.MCourseTopicIdNfk,
                        QuestionIdFk = question.Id,
                        AspNetUserIdFk = current_user.user_id,
                        DateAnswered = DateTime.Now,
                        Answer = text_answer,
                        CorrectAnswer = true//score3 < (0.6),//0.6 is 60 percent tollerance anything above is incorrect, must be below 0.6 to be correct
                    };
                    if (await UploadAnswerToServer(users_answer))
                    {
                        state.SetAnswer(users_answer);
                    }
                }
            }
            else//radio and checkbox
            {
                var list_of_correct_answers = question_answers_options
                    .Where(i => i.MCourseIdNfk == course.Id)
                    .Where(i => i.MQuestionIdFk == question.Id)
                    .Where(i => i.IsCorrectAnswer)
                    .Select(i => i.Id)
                    .ToList();

                //first check same number of answers
                if (selected_answers.Count == list_of_correct_answers.Count)
                {
                    //
                    var users_answer = new BlazorAppClient.Shared.Models.MUsersAnswers()
                    {
                        CourseIdNfk = question.MCourseIdFk,
                        TopicIdNfk = question.MCourseTopicIdNfk,
                        QuestionIdFk = question.Id,
                        AspNetUserIdFk = current_user.user_id,
                        DateAnswered = DateTime.Now,
                        Answer = String.Join(",", selected_answers),
                        CorrectAnswer = false,
                    };
                    //
                    var intersection = selected_answers.Intersect(list_of_correct_answers).ToList();
                    if (intersection.Count == list_of_correct_answers.Count)
                    {
                        users_answer.CorrectAnswer = true;
                    }
                    //
                    if (await UploadAnswerToServer(users_answer))
                    {
                        state.SetAnswer(users_answer);
                    }
                }
                else
                {
                    //record answers as incorrect already, since they are different lengths
                    var users_answer = new BlazorAppClient.Shared.Models.MUsersAnswers()
                    {
                        CourseIdNfk = question.MCourseIdFk,
                        TopicIdNfk = question.MCourseTopicIdNfk,
                        QuestionIdFk = question.Id,
                        AspNetUserIdFk = current_user.user_id,
                        DateAnswered = DateTime.Now,
                        Answer = String.Join(",", selected_answers),
                        CorrectAnswer = false,
                    };
                    //
                    if (await UploadAnswerToServer(users_answer))
                    {
                        state.SetAnswer(users_answer);
                    }
                }


            }

        }
    }


    private void AddRemoveAnswer(ChangeEventArgs e, string answer)
    {
        if (question.EQuestionTypeIdFk == radio_based_question_id)
        {
            selected_answers.Clear();//remove all answers for radio
        }
        if (bool.Parse(e.Value.ToString()))
        {
            if (!selected_answers.Contains(answer))
            {
                selected_answers.Add(answer);
            }
        }
        else
        {
            if (selected_answers.Contains(answer))
                selected_answers.Remove(answer);
        }
        Console.WriteLine(string.Join(",", selected_answers));
    }


    private async Task<bool> UploadAnswerToServer(BlazorAppClient.Shared.Models.MUsersAnswers answer)
    {
        try
        {

            loading = true;
            StateHasChanged();
            var response1 = await http_client.PostAsJsonAsync<BlazorAppClient.Shared.Models.MUsersAnswers>("/Courses/UploadAnswerToServer", answer);
            var response2 = await response1.Content.ReadAsStringAsync();
            dynamic json = JsonConvert.DeserializeObject(response2);
            if (json.res.ToString() == "ok")
            {

                return true;
            }
            else
            {
                toastService.ShowError(json.data.ToString());
                return false;
            }
        }
        catch (Exception ex)
        {
            return false;
        }
        finally
        {
            loading = false;
            //selected_answers.Clear();
            StateHasChanged();
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http_client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private State state { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SweetAlertService Swal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authentication_state_provider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService local_storage { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialQuestionOptionsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20edba93320d8453f7de763b1fecc0716f15aa5c"
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
    public partial class CourseMaterialQuestionOptionsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "p");
            __builder.AddAttribute(4, "class", "lead");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "b");
            __builder.AddContent(7, 
#nullable restore
#line 8 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialQuestionOptionsComponent.razor"
             (MarkupString)question.QuestionText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
#nullable restore
#line 13 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialQuestionOptionsComponent.razor"
 if (answers.Where(i => i.CourseMaterialQuestionIdFk == question.Id).Any())
{
    //show answer

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "    ");
            __builder.OpenComponent<BlazorAppClient.Client.Pages.Course.CourseMaterialAnswersComponent>(12);
            __builder.AddAttribute(13, "question", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAppClient.Shared.Models.MCourseWorkQuestion>(
#nullable restore
#line 16 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialQuestionOptionsComponent.razor"
                                              question

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "answer", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAppClient.Shared.Models.MUsersAnswersCourseMaterial>(
#nullable restore
#line 17 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialQuestionOptionsComponent.razor"
                                            answers.Where(i => i.CourseMaterialQuestionIdFk == question.Id).FirstOrDefault()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 18 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialQuestionOptionsComponent.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialQuestionOptionsComponent.razor"
     foreach (var item in question.MCourseWorkQuestionAnswerOptions)
    {
        if (question.EQuestionTypeIdFk == checkbox_based_question_id)//checkbox
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "            ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "checkbox");
            __builder.AddAttribute(19, "value", "true");
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialQuestionOptionsComponent.razor"
                                                           ( (ev) =>  { AddRemoveAnswer(ev, item.Id); } )

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.AddContent(22, 
#nullable restore
#line 27 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialQuestionOptionsComponent.razor"
             item.OptionText

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(23, "            <br>\r\n");
#nullable restore
#line 29 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialQuestionOptionsComponent.razor"
        }
        else if (question.EQuestionTypeIdFk == radio_based_question_id)//radio
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "            ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "name", "radio");
            __builder.AddAttribute(27, "value", "true");
            __builder.AddAttribute(28, "type", "radio");
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialQuestionOptionsComponent.razor"
                                                                     ( (ev) =>  { AddRemoveAnswer(ev, item.Id); } )

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.AddContent(31, 
#nullable restore
#line 33 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialQuestionOptionsComponent.razor"
             item.OptionText

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(32, "            <br>\r\n");
#nullable restore
#line 35 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialQuestionOptionsComponent.razor"
        }
        else if (question.EQuestionTypeIdFk == text_based_question_id)//text
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "            ");
            __builder.OpenElement(34, "textarea");
            __builder.AddAttribute(35, "placeholder", "type answer here...");
            __builder.AddAttribute(36, "required", true);
            __builder.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialQuestionOptionsComponent.razor"
                                                                        text_answer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => text_answer = __value, text_answer));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 39 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialQuestionOptionsComponent.razor"
        }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialQuestionOptionsComponent.razor"
     
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 43 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialQuestionOptionsComponent.razor"
 if (!answers.Where(i => i.CourseMaterialQuestionIdFk == question.Id).Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(41, "    <br>\r\n    ");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "type", "button");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialQuestionOptionsComponent.razor"
                                    ConfirmSubmit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "class", "btn btn-success btn-sm");
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.OpenComponent<BlazorAppClient.Client.Shared.Loading>(47);
            __builder.AddAttribute(48, "isloading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 47 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialQuestionOptionsComponent.razor"
                            loading

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(49, "\r\n        Submit Answer\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(51, "<small style=\"color:red;\">you will not be able to change the answer</small>\r\n");
#nullable restore
#line 52 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialQuestionOptionsComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialQuestionOptionsComponent.razor"
       

    [Parameter]
    public BlazorAppClient.Shared.Models.MCourseWorkQuestion question { get; set; }
    [Parameter]
    public List<BlazorAppClient.Shared.Models.MUsersAnswersCourseMaterial> answers { get; set; } = new List<BlazorAppClient.Shared.Models.MUsersAnswersCourseMaterial>();

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
        base.OnParametersSet();
        //convert from base 64 text
        question.QuestionText = System.Text.ASCIIEncoding.ASCII.GetString(System.Convert.FromBase64String(question.QuestionText));
    }

    private async Task<BlazorAppClient.Shared.CurrentUser> GetCurrentUser()
    {
        dynamic user_string = await local_storage.GetItemAsStringAsync("current_user");
        var current_user = JsonConvert.DeserializeObject<BlazorAppClient.Shared.CurrentUser>(user_string);
        return current_user;
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


    private async Task<bool> UploadAnswerToServer(BlazorAppClient.Shared.Models.MUsersAnswersCourseMaterial answer)
    {
        try
        {

            loading = true;
            //StateHasChanged();
            var response1 = await http_client.PostAsJsonAsync<BlazorAppClient.Shared.Models.MUsersAnswersCourseMaterial>("/Courses/UploadCourseMaterialAnswerToServer", answer);
            var response2 = await response1.Content.ReadAsStringAsync();
            dynamic json = JsonConvert.DeserializeObject(response2);
            if (json.res.ToString() == "ok")
            {
                answers.Add(answer);
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



    private async Task ConfirmSubmit()
    {
        var current_user = await GetCurrentUser();
        //user has confirmed answer
        var confirm = await js.InvokeAsync<bool>("confirm", new[] { "Confirm Answer", "Are you sure?" });
        if (confirm)
        {

            if (selected_answers.Count == 0 && string.IsNullOrEmpty(text_answer))
            {
                toastService.ShowError("Provide and answer");
                return;
            }
            if (question.EQuestionTypeIdFk == text_based_question_id)//text based answer
            {
                if (string.IsNullOrEmpty(text_answer))
                {
                    toastService.ShowError("Answer is empty");
                    return;
                }
                else
                {
                    //todo: compare text asnwer with users answer using bayes algorithm
                }
            }
            else//radio and checkbox
            {
                var list_of_correct_answers = question.MCourseWorkQuestionAnswerOptions
                .Where(i => i.IsCorrectAnswer)
                .Select(i => i.Id)
                .ToList();

                //first check same number of answers
                if (selected_answers.Count == list_of_correct_answers.Count)
                {
                    //
                    var users_answer = new BlazorAppClient.Shared.Models.MUsersAnswersCourseMaterial()
                    {
                        CourseMaterialIdFk = question.MCourseMaterialIdFk,
                        CourseMaterialQuestionIdFk = question.Id,
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
                        //state.SetAnswer(users_answer);
                    }
                }
                else
                {
                    //record answers as incorrect already, since they are different lengths
                    var users_answer = new BlazorAppClient.Shared.Models.MUsersAnswersCourseMaterial()
                    {
                        CourseMaterialIdFk = question.MCourseMaterialIdFk,
                        CourseMaterialQuestionIdFk = question.Id,
                        AspNetUserIdFk = current_user.user_id,
                        DateAnswered = DateTime.Now,
                        Answer = String.Join(",", selected_answers),
                        CorrectAnswer = false,
                    };
                    //
                    if (await UploadAnswerToServer(users_answer))
                    {
                        //state.SetAnswer(users_answer);
                    }
                }


            }

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

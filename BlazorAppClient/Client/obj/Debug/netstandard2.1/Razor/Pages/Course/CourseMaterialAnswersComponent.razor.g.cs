#pragma checksum "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf3910c55001a8185523d8bad364ca860c286768"
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
    public partial class CourseMaterialAnswersComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
 if (question.EQuestionTypeIdFk == text_based_question_id)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<h3>Your answer is: Recorded</h3>");
#nullable restore
#line 5 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
     if (question.EQuestionTypeIdFk == text_based_question_id)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, 
#nullable restore
#line 7 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
            answer.Answer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 8 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
         if (selected_answers.Count > 0 && selected_answers != null)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "ul");
#nullable restore
#line 14 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
                 foreach (var ans in selected_answers)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "li");
            __builder.AddContent(5, 
#nullable restore
#line 17 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
                         question.MCourseWorkQuestionAnswerOptions.Where(i => i.Id == ans).FirstOrDefault()?.OptionText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<h3>\r\n        Sample Answer\r\n    </h3>");
#nullable restore
#line 30 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
     if (question.EQuestionTypeIdFk == text_based_question_id)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "p");
            __builder.AddContent(8, 
#nullable restore
#line 33 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
             question.MCourseWorkQuestionAnswerOptions.FirstOrDefault().OptionText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "id", "accordion");
#nullable restore
#line 39 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
             foreach (var ans in question.MCourseWorkQuestionAnswerOptions)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card-header");
            __builder.OpenElement(15, "h5");
            __builder.AddAttribute(16, "class", "mb-0");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "style", "color:" + (
#nullable restore
#line 44 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
                                                   ans.IsCorrectAnswer ? "green" : "red"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "class", "btn btn-link");
            __builder.AddAttribute(20, "data-toggle", "collapse");
            __builder.AddAttribute(21, "data-target", "#collapse_" + (
#nullable restore
#line 44 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
                                                                                                                                                                ans.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "aria-expanded", "true");
            __builder.AddAttribute(23, "aria-controls", "collapseOne");
            __builder.AddContent(24, 
#nullable restore
#line 45 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
                                 ans.OptionText

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(25, "   <i class=\"fas fa-arrow-right\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "id", "collapse_" + (
#nullable restore
#line 49 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
                                        ans.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "class", "collapse");
            __builder.AddAttribute(30, "aria-labelledby", "headingOne");
            __builder.AddAttribute(31, "data-parent", "#accordion");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "card-body");
            __builder.AddContent(34, 
#nullable restore
#line 51 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
                             ans.Explanation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 57 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
     

}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "h3");
            __builder.AddContent(36, "Your answer is: ");
            __builder.AddContent(37, 
#nullable restore
#line 62 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
                          answer.CorrectAnswer ? ((MarkupString)"<span style='color:green'>Correct</span>") : ((MarkupString)"<span style='color:red'>Wrong</span>")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 63 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
     if (question.EQuestionTypeIdFk == text_based_question_id)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "p");
            __builder.AddContent(39, 
#nullable restore
#line 65 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
            answer.Answer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 66 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
         if (selected_answers.Count > 0 && selected_answers != null)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(40, "ul");
#nullable restore
#line 72 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
                 foreach (var ans in selected_answers)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(41, "li");
            __builder.AddContent(42, 
#nullable restore
#line 75 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
                         question.MCourseWorkQuestionAnswerOptions.Where(i => i.Id == ans).FirstOrDefault()?.OptionText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 77 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 79 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(43, "<h3>\r\n        Correct Answer\r\n    </h3>");
#nullable restore
#line 88 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
     if (question.EQuestionTypeIdFk == text_based_question_id)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(44, "p");
            __builder.AddContent(45, 
#nullable restore
#line 91 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
             question.MCourseWorkQuestionAnswerOptions.FirstOrDefault().OptionText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 93 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "id", "accordion");
#nullable restore
#line 97 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
             foreach (var ans in question.MCourseWorkQuestionAnswerOptions)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "card");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "card-header");
            __builder.OpenElement(52, "h5");
            __builder.AddAttribute(53, "class", "mb-0");
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "style", "color:" + (
#nullable restore
#line 102 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
                                                   ans.IsCorrectAnswer ? "green" : "red"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "class", "btn btn-link");
            __builder.AddAttribute(57, "data-toggle", "collapse");
            __builder.AddAttribute(58, "data-target", "#collapse_" + (
#nullable restore
#line 102 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
                                                                                                                                                                ans.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "aria-expanded", "true");
            __builder.AddAttribute(60, "aria-controls", "collapseOne");
            __builder.AddContent(61, 
#nullable restore
#line 103 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
                                 ans.OptionText

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(62, "   <i class=\"fas fa-arrow-right\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "id", "collapse_" + (
#nullable restore
#line 107 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
                                        ans.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "class", "collapse");
            __builder.AddAttribute(67, "aria-labelledby", "headingOne");
            __builder.AddAttribute(68, "data-parent", "#accordion");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "card-body");
            __builder.AddContent(71, 
#nullable restore
#line 109 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
                             ans.Explanation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 113 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 115 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
     

}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(72, "<br>\r\n<hr>\r\n<br>");
        }
        #pragma warning restore 1998
#nullable restore
#line 123 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
      

    [Parameter]
    public BlazorAppClient.Shared.Models.MUsersAnswersCourseMaterial answer { get; set; }
    [Parameter]
    public BlazorAppClient.Shared.Models.MCourseWorkQuestion question { get; set; }

    private List<string> selected_answers = null;

    private string text_answer = string.Empty;

    private string text_based_question_id = "A011ED2A-AE61-43BB-BD01-EEFD428DE0FE";
    private string radio_based_question_id = "C277D965-1573-43C7-8E23-81AD4AAAB6F9";
    private string checkbox_based_question_id = "04E2AB58-1885-411E-BCB5-0A14894571E9";

    protected override void OnParametersSet()
    {
        selected_answers = answer.Answer.Split(",").ToList();
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

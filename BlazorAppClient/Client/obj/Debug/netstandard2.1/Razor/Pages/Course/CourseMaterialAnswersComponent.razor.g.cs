#pragma checksum "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "508deae687e6ea6be8c4ee5be079d5fd140c6859"
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
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Your answer is: ");
            __builder.AddContent(2, 
#nullable restore
#line 2 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
                      answer.CorrectAnswer? ((MarkupString)"<span style='color:green'>Correct</span>") : ((MarkupString)"<span style='color:red'>Wrong</span>")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 3 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
 if (question.EQuestionTypeIdFk == text_based_question_id)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, 
#nullable restore
#line 5 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
        text_answer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 6 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
     if (selected_answers.Count > 0 && selected_answers != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "        ");
            __builder.OpenElement(9, "ul");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 12 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
             foreach (var ans in selected_answers)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "li");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.AddContent(14, 
#nullable restore
#line 15 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
                     question.MCourseWorkQuestionAnswerOptions.Where(i => i.Id == ans).FirstOrDefault()?.OptionText

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 17 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 19 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
     
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(19, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(20, "<h3>\r\n    Correct Answer\r\n</h3>\r\n\r\n");
#nullable restore
#line 28 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
 if (question.EQuestionTypeIdFk == text_based_question_id)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "    ");
            __builder.OpenElement(22, "p");
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.AddContent(24, 
#nullable restore
#line 31 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
         question.MCourseWorkQuestionAnswerOptions.FirstOrDefault().OptionText

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 33 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "id", "accordion");
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 37 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
         foreach (var ans in question.MCourseWorkQuestionAnswerOptions)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "            ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "card");
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "card-header");
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "h5");
            __builder.AddAttribute(39, "class", "mb-0");
            __builder.AddMarkupContent(40, "\r\n                        ");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "style", "color:" + (
#nullable restore
#line 42 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
                                               ans.IsCorrectAnswer?"green":"red"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "class", "btn btn-link");
            __builder.AddAttribute(44, "data-toggle", "collapse");
            __builder.AddAttribute(45, "data-target", "#collapse_" + (
#nullable restore
#line 42 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
                                                                                                                                                        ans.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "aria-expanded", "true");
            __builder.AddAttribute(47, "aria-controls", "collapseOne");
            __builder.AddMarkupContent(48, "\r\n                            ");
            __builder.AddContent(49, 
#nullable restore
#line 43 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
                             ans.OptionText

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(50, "   <i class=\"fas fa-arrow-right\"></i>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "id", "collapse_" + (
#nullable restore
#line 47 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
                                    ans.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "class", "collapse");
            __builder.AddAttribute(57, "aria-labelledby", "headingOne");
            __builder.AddAttribute(58, "data-parent", "#accordion");
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "card-body");
            __builder.AddMarkupContent(62, "\r\n                        ");
            __builder.AddContent(63, 
#nullable restore
#line 49 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
                         ans.Explanation

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(64, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
#nullable restore
#line 53 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(68, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
#nullable restore
#line 55 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(70, "\r\n\r\n<br>\r\n<hr>\r\n<br>");
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseMaterialAnswersComponent.razor"
      

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
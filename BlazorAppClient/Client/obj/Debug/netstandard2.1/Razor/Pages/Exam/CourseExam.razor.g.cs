#pragma checksum "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7950935e845b18ecc59825efaf715c9091857bc"
// <auto-generated/>
#pragma warning disable 1591
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
#nullable restore
#line 13 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
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
#line 17 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 17 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                                              50

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 17 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
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
            __builder.AddMarkupContent(15, "<div class=\"row\">\r\n        <div class=\"col-md-12\" style=\"display:flex;align-content:center;justify-content:center;\">\r\n            <p style=\"clear:both;\">Loading exam...</p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 25 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
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
#line 33 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
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
#line 33 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                                                                                                                                                                                  course.CourseName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(37, 
#nullable restore
#line 33 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                                                                                                                                                                                                       course.CourseName.Length >= 10 ? course.CourseName.Substring(0, 9) + "..." : course.CourseName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(38, " / Exam");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                \r\n                \r\n                \r\n                \r\n                ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "sidebar-item.");
            __builder.AddMarkupContent(43, "\r\n\r\n                    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "id", "html_exam");
            __builder.AddAttribute(46, "class", "demo");
            __builder.AddMarkupContent(47, "\r\n                        ");
            __builder.OpenElement(48, "ul");
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 55 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                             foreach (var topic in course.MCourseTopic.OrderBy(i => i.Sequence))
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "                                ");
            __builder.OpenElement(51, "li");
            __builder.AddAttribute(52, "data-jstree", "{" + " \"opened\"" + " :" + " " + (
#nullable restore
#line 57 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                                                                course_counter == 0 ? "true" : "false"

#line default
#line hidden
#nullable disable
            ) + " }");
            __builder.AddMarkupContent(53, "\r\n                                    ");
            __builder.AddContent(54, 
#nullable restore
#line 58 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                                     topic.Topic

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(55, "\r\n                                    ");
            __builder.OpenElement(56, "ul");
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 60 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                                          
                                            int question_number = 1;
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                                         foreach (var page_ in course.MQuestion.Where(i => i.MCourseTopicIdFk == topic.Id).OrderBy(i => i.QuestionSequence))
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, "                                            ");
            __builder.OpenElement(59, "li");
            __builder.AddAttribute(60, "data-jstree", "{" + " \"selected\"" + " :" + " false,\"PageData\":\"" + (
#nullable restore
#line 65 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                                                                                               page_.QuestionText

#line default
#line hidden
#nullable disable
            ) + "\",\"QuestionID\":\"" + (
#nullable restore
#line 65 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                                                                                                                                  page_.Id

#line default
#line hidden
#nullable disable
            ) + "\"" + " }");
            __builder.AddMarkupContent(61, "\r\n                                                Question ");
            __builder.AddContent(62, 
#nullable restore
#line 66 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                                                          question_number

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(63, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n");
            __builder.AddContent(65, 
#nullable restore
#line 68 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                                              question_number = question_number + 1

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 68 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                                                                                    
                                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(66, "                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
            __builder.AddContent(69, 
#nullable restore
#line 72 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                                  course_counter = course_counter + 1

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 72 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                                                                      
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(70, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n        \r\n        ");
            __builder.OpenElement(76, "main");
            __builder.AddAttribute(77, "class", "page-content pt-2");
            __builder.AddMarkupContent(78, "\r\n         \r\n\r\n              ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "container");
            __builder.AddMarkupContent(81, "\r\n");
#nullable restore
#line 84 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                 if (!string.IsNullOrEmpty(PageData))
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(82, "                    ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "row");
            __builder.AddMarkupContent(85, "\r\n                        ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "col-md-12");
            __builder.AddMarkupContent(88, "\r\n                            progress\r\n                            ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "progress");
            __builder.AddMarkupContent(91, "\r\n                                ");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "progress-bar" + " " + (
#nullable restore
#line 90 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                                                           state.exam_percentage_complete==100?"bg-success":
                                                           state.exam_percentage_complete>=75?"bg-info":
                                                           state.exam_percentage_complete>=50?"bg-warning":
                                                           "bg-danger"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(94, "role", "progressbar");
            __builder.AddAttribute(95, "style", "width:" + " " + (
#nullable restore
#line 95 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                                                     state.exam_percentage_complete

#line default
#line hidden
#nullable disable
            ) + "%;");
            __builder.AddAttribute(96, "aria-valuenow", 
#nullable restore
#line 96 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                                                      state.exam_percentage_complete

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(97, "aria-valuemin", "0");
            __builder.AddAttribute(98, "aria-valuemax", "100");
            __builder.AddContent(99, 
#nullable restore
#line 97 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                                                                             state.exam_percentage_complete

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(100, "%");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n");
#nullable restore
#line 101 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(105, "                    ");
            __builder.AddMarkupContent(106, "<div class=\"row\">\r\n                        <div class=\"col-md-12\">\r\n                            <small style=\"color:orange\">Select a page to begin</small>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 109 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(107, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n\r\n\r\n\r\n            <div id=\"overlay\" class=\"overlay\"></div>\r\n            ");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "class", "container-fluid p-5");
            __builder.AddMarkupContent(111, "\r\n                ");
            __builder.AddMarkupContent(112, "<div class=\"row\">\r\n                    <div class=\"col-md-12\">\r\n\r\n                    </div>\r\n                </div>\r\n                ");
            __builder.OpenElement(113, "div");
            __builder.AddAttribute(114, "class", "row");
            __builder.AddMarkupContent(115, "\r\n                    ");
            __builder.OpenElement(116, "div");
            __builder.AddAttribute(117, "class", "col-md-12");
            __builder.AddMarkupContent(118, "\r\n                        ");
            __builder.AddContent(119, 
#nullable restore
#line 123 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                          (MarkupString)PageData

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(120, "\r\n");
#nullable restore
#line 124 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                         if (question != null && course.MQuestionAnswerOptions != null)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(121, "                            <hr>\r\n");
#nullable restore
#line 127 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                             if (state.answers.Where(i => i.QuestionIdFk == question.Id).Any())
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(122, "                                ");
            __builder.OpenComponent<BlazorAppClient.Client.Pages.Exam.AnswersComponent>(123);
            __builder.AddAttribute(124, "question", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAppClient.Shared.Models.MQuestion>(
#nullable restore
#line 129 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                                                            question

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(125, "course", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAppClient.Shared.Models.MCourse>(
#nullable restore
#line 129 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                                                                              course

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(126, "\r\n");
#nullable restore
#line 130 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(127, "                                ");
            __builder.OpenComponent<BlazorAppClient.Client.Pages.Exam.QuestionOptionsComponent>(128);
            __builder.AddAttribute(129, "question", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAppClient.Shared.Models.MQuestion>(
#nullable restore
#line 133 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                                                                    question

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(130, "course", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAppClient.Shared.Models.MCourse>(
#nullable restore
#line 133 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                                                                                      course

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(131, "\r\n");
#nullable restore
#line 134 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 134 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                             
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(132, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n");
#nullable restore
#line 141 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(138, "\r\n");
            __builder.OpenComponent<Blazored.Toast.BlazoredToasts>(139);
            __builder.AddAttribute(140, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.Configuration.ToastPosition>(
#nullable restore
#line 143 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                          ToastPosition.BottomCenter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(141, "Timeout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 144 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                         3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(142, "IconType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.IconType?>(
#nullable restore
#line 145 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
                          IconType.FontAwesome

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(143, "SuccessClass", "success-toast-override");
            __builder.AddAttribute(144, "SuccessIcon", "fa fa-thumbs-up");
            __builder.AddAttribute(145, "ErrorIcon", "fa fa-bug");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 150 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Exam\CourseExam.razor"
       
    [Parameter]
    public string course_id { get; set; }
    private int course_counter = 0;
    private static string PageData = string.Empty;
    private bool tree_initialized = false;
    private BlazorAppClient.Shared.Models.MQuestion question = null;
    private bool show_answer = false;


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


    [JSInvokable]
    public void RenderContent(string page_data, string question_id)
    {
        tree_initialized = true;
        if (!string.IsNullOrEmpty(page_data))
        {
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
                //
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

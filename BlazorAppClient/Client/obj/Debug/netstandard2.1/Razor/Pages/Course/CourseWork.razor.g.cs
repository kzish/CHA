#pragma checksum "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c5874c79f72a553c648f1644b95075980db56a4"
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
            __builder.AddMarkupContent(16, "    <div id=\"mobile-nav\"></div>\r\n    ");
            __builder.OpenElement(17, "nav");
            __builder.AddAttribute(18, "class", "_nav active");
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "sidebar-item. sidebar-brand");
            __builder.AddAttribute(22, "style", "color:black!important;");
            __builder.AddMarkupContent(23, "\r\n\r\n            ");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "href", "/Course/" + (
#nullable restore
#line 31 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                              course.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "style", "color:black;font-size:22px;text-decoration:none;margin:10px;");
            __builder.AddMarkupContent(27, "\r\n                <i title=\"back\" class=\"fas fa-sign-out-alt flip_180\"></i>\r\n                Back\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            <hr>\r\n            ");
            __builder.OpenElement(29, "h3");
            __builder.AddAttribute(30, "style", "margin:10px;color:black;");
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "a");
            __builder.AddAttribute(33, "title", 
#nullable restore
#line 37 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                           course.CourseName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.AddContent(35, 
#nullable restore
#line 38 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                      course.CourseName.Length >= 10 ? course.CourseName.Substring(0, 9) + "..." : course.CourseName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.AddMarkupContent(39, "<h4 style=\"margin:10px;color:Highlight;\">\r\n                <a>\r\n                    Course Work\r\n                </a>\r\n            </h4>\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        <br>\r\n        ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "id", "html_course_work");
            __builder.AddAttribute(43, "class", "demo");
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.OpenElement(45, "ul");
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 52 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                 foreach (var topic in course.MCourseTopic.OrderBy(i => i.Sequence))
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "                    ");
            __builder.OpenElement(48, "li");
            __builder.AddAttribute(49, "data-jstree", "{" + " \"opened\"" + " :" + " " + (
#nullable restore
#line 54 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                                    course_counter == 0 ? "true" : "false"

#line default
#line hidden
#nullable disable
            ) + " }");
            __builder.AddMarkupContent(50, "\r\n                        ");
            __builder.AddContent(51, 
#nullable restore
#line 55 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                         topic.Topic

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(52, "\r\n                        ");
            __builder.OpenElement(53, "ul");
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 57 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                             foreach (var page_ in course.MCourseMaterial.Where(i => i.MCourseTopicIdFk == topic.Id).OrderBy(i => i.PageSequence))
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "                                ");
            __builder.OpenElement(56, "li");
            __builder.AddAttribute(57, "data-jstree", "{\"topic_id\":\"" + (
#nullable restore
#line 59 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                                               topic.Id

#line default
#line hidden
#nullable disable
            ) + "\",\"page_id\":\"" + (
#nullable restore
#line 59 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                                                                     page_.Id

#line default
#line hidden
#nullable disable
            ) + "\"," + " \"selected\"" + " :" + " false,\"PageData\":\"" + (
#nullable restore
#line 59 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                                                                                                                page_.PageData

#line default
#line hidden
#nullable disable
            ) + "\"," + " \"has_questions\":\"" + (
#nullable restore
#line 59 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                                                                                                                                                   page_.HasQuestions

#line default
#line hidden
#nullable disable
            ) + "\"" + " }");
            __builder.AddMarkupContent(58, "\r\n                                    ");
            __builder.AddContent(59, 
#nullable restore
#line 60 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                     page_.PageTitle

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(60, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
#nullable restore
#line 62 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(62, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n");
            __builder.AddContent(65, 
#nullable restore
#line 65 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                      course_counter = course_counter + 1

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 65 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                                          
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(66, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
            __builder.AddContent(70, "    ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "page-wrapper white-theme sidebar-bg. bg1. toggled");
            __builder.AddMarkupContent(73, "\r\n\r\n        ");
            __builder.OpenElement(74, "main");
            __builder.AddAttribute(75, "class", "page-content pt-2");
            __builder.AddMarkupContent(76, "\r\n\r\n            ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "container");
            __builder.AddMarkupContent(79, "\r\n");
#nullable restore
#line 78 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                 if (!string.IsNullOrEmpty(PageData))
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(80, "                    ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "row");
            __builder.AddMarkupContent(83, "\r\n                        ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "col-md-12");
            __builder.AddMarkupContent(86, "\r\n                            progress\r\n                            ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "progress");
            __builder.AddMarkupContent(89, "\r\n                                ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "progress-bar" + " " + (
#nullable restore
#line 85 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                                           state.course_percentage_complete==100?"bg-success":
                                                           state.course_percentage_complete>=75?"bg-info":
                                                           state.course_percentage_complete>=50?"bg-warning":
                                                           "bg-danger"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(92, "role", "progressbar");
            __builder.AddAttribute(93, "style", "width:" + " " + (
#nullable restore
#line 90 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                                     state.course_percentage_complete

#line default
#line hidden
#nullable disable
            ) + "%;");
            __builder.AddAttribute(94, "aria-valuenow", 
#nullable restore
#line 91 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                                      state.course_percentage_complete

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(95, "aria-valuemin", "0");
            __builder.AddAttribute(96, "aria-valuemax", "100");
            __builder.AddContent(97, 
#nullable restore
#line 92 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                                                             state.course_percentage_complete

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(98, "%");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n");
#nullable restore
#line 96 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(103, "                    ");
            __builder.AddMarkupContent(104, "<div class=\"row\">\r\n                        <div class=\"col-md-12\">\r\n                            <small style=\"color:orange\">Select a page to begin</small>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 104 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(105, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n\r\n\r\n            ");
            __builder.OpenElement(107, "div");
            __builder.AddAttribute(108, "class", "container-fluid p-5");
            __builder.AddMarkupContent(109, "\r\n");
#nullable restore
#line 110 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                 if (!string.IsNullOrEmpty(PageData))
                {
                    

#line default
#line hidden
#nullable disable
            __builder.AddContent(110, 
#nullable restore
#line 112 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                      (MarkupString)PageData

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(111, "                    ");
            __builder.OpenElement(112, "div");
            __builder.AddAttribute(113, "class", "form-group");
            __builder.AddMarkupContent(114, "\r\n");
#nullable restore
#line 116 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                         if (state.completed_pages.Where(i => i.CoursePageIdFk == page_id).Any())
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(115, "                            ");
            __builder.AddMarkupContent(116, "<button class=\"btn btn-sm btn-warning\">\r\n                                Saved\r\n                            </button>\r\n");
#nullable restore
#line 121 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(117, "                            ");
            __builder.OpenElement(118, "button");
            __builder.AddAttribute(119, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 124 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                              () => SaveProgress()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(120, "class", "btn btn-sm btn-success");
            __builder.AddMarkupContent(121, "\r\n                                ");
            __builder.OpenComponent<BlazorAppClient.Client.Shared.Loading>(122);
            __builder.AddAttribute(123, "isloading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 125 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                                    loading

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(124, "\r\n                                Save Progress\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n                            <br>\r\n                            ");
            __builder.AddMarkupContent(126, "<small style=\"color:orange\">Click to update progress.</small>\r\n");
#nullable restore
#line 130 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(127, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n");
#nullable restore
#line 132 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(129, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n\r\n            ");
            __builder.OpenElement(131, "div");
            __builder.AddAttribute(132, "class", "container-fluid p-5");
            __builder.AddMarkupContent(133, "\r\n                ");
            __builder.OpenElement(134, "div");
            __builder.AddAttribute(135, "class", "row");
            __builder.AddMarkupContent(136, "\r\n                    ");
            __builder.OpenElement(137, "div");
            __builder.AddAttribute(138, "class", "col-md-12");
            __builder.AddMarkupContent(139, "\r\n");
#nullable restore
#line 139 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                         if (has_questions && course_material_questions == null)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(140, "                            ");
            __builder.AddMarkupContent(141, "<p>Loading Questions...</p>\r\n");
#nullable restore
#line 142 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                        }
                        else if (has_questions && course_material_questions != null)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(142, "                            <hr>\r\n");
#nullable restore
#line 146 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                            foreach (var question in course_material_questions.OrderBy(i=>i.QuestionSequence))
                            {
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(143, "                                    ");
            __builder.OpenComponent<BlazorAppClient.Client.Pages.Course.CourseMaterialQuestionOptionsComponent>(144);
            __builder.AddAttribute(145, "question", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAppClient.Shared.Models.MCourseWorkQuestion>(
#nullable restore
#line 149 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                                                                      question

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(146, "answers", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorAppClient.Shared.Models.MUsersAnswersCourseMaterial>>(
#nullable restore
#line 149 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                                                                                         completed_questions_answers

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(147, "\r\n");
#nullable restore
#line 150 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                                }
                            }
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(148, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n");
#nullable restore
#line 160 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(154, "\r\n");
            __builder.OpenComponent<Blazored.Toast.BlazoredToasts>(155);
            __builder.AddAttribute(156, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.Configuration.ToastPosition>(
#nullable restore
#line 162 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                          ToastPosition.BottomCenter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(157, "Timeout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 163 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                         3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(158, "IconType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.IconType?>(
#nullable restore
#line 164 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\BlazorAppClient\Client\Pages\Course\CourseWork.razor"
                          IconType.FontAwesome

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(159, "SuccessClass", "success-toast-override");
            __builder.AddAttribute(160, "SuccessIcon", "fa fa-thumbs-up");
            __builder.AddAttribute(161, "ErrorIcon", "fa fa-bug");
            __builder.CloseComponent();
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
            PageData = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            PageData = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
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
                //StateHasChanged();
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

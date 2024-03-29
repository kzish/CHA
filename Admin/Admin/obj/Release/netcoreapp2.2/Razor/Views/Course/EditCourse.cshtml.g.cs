#pragma checksum "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\Course\EditCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0fe768f7d56dc7b4a75f191bb35eeb658130669"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_EditCourse), @"mvc.1.0.view", @"/Views/Course/EditCourse.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Course/EditCourse.cshtml", typeof(AspNetCore.Views_Course_EditCourse))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0fe768f7d56dc7b4a75f191bb35eeb658130669", @"/Views/Course/EditCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_EditCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Course/EditCourse"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\Course\EditCourse.cshtml"
  
    Layout = "~/Views/Shared/_LayoutMain.cshtml";
    var course_categories = (List<Admin.Models.ECourseCategory>)ViewBag.course_categories;
    var course = (Admin.Models.MCourse)ViewBag.course;


#line default
#line hidden
            BeginContext(208, 95, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            ");
            EndContext();
            BeginContext(303, 3971, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0fe768f7d56dc7b4a75f191bb35eeb6581306694145", async() => {
                BeginContext(352, 84, true);
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 436, "\"", 454, 1);
#line 13 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\Course\EditCourse.cshtml"
WriteAttributeValue("", 444, course.Id, 444, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(455, 218, true);
                WriteLiteral(" name=\"Id\" />\r\n\r\n\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-4\">\r\n                            <input type=\"text\" class=\"form-control\" placeholder=\"...\" required name=\"CourseName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 673, "\"", 699, 1);
#line 18 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\Course\EditCourse.cshtml"
WriteAttributeValue("", 681, course.CourseName, 681, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(700, 302, true);
                WriteLiteral(@">
                            <small><span style=""color:red;"">*</span> Course Name</small>
                        </div>
                        <div class=""col-md-4"">
                            <input type=""number"" min=""1"" class=""form-control"" placeholder=""1"" required name=""CourseDurationHours""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1002, "\"", 1037, 1);
#line 22 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\Course\EditCourse.cshtml"
WriteAttributeValue("", 1010, course.CourseDurationHours, 1010, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1038, 315, true);
                WriteLiteral(@">
                            <small><span style=""color:red;"">*</span> Course Duration (hours)</small>
                        </div>
                        <div class=""col-md-4"">
                            <input type=""number"" min=""1"" class=""form-control"" placeholder=""1"" required name=""CourseStudyTimeHours""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1353, "\"", 1389, 1);
#line 26 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\Course\EditCourse.cshtml"
WriteAttributeValue("", 1361, course.CourseStudyTimeHours, 1361, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1390, 369, true);
                WriteLiteral(@">
                            <small><span style=""color:red;"">*</span> Allocated Study Time (hours)</small>
                        </div>
                    </div>


                    <div class=""row"">
                        <div class=""col-md-4"">
                            <input type=""text"" class=""form-control"" placeholder="""" required name=""StartDate""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1759, "\"", 1784, 1);
#line 34 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\Course\EditCourse.cshtml"
WriteAttributeValue("", 1767, course.StartDate, 1767, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1785, 293, true);
                WriteLiteral(@" id=""StartDate"">
                            <small><span style=""color:red;"">*</span> Start Date</small>
                        </div>
                        <div class=""col-md-4"">
                            <input type=""text"" class=""form-control"" placeholder="""" required name=""EndDate""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2078, "\"", 2101, 1);
#line 38 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\Course\EditCourse.cshtml"
WriteAttributeValue("", 2086, course.EndDate, 2086, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2102, 337, true);
                WriteLiteral(@" id=""EndDate"">
                            <small><span style=""color:red;"">*</span> End Date</small>
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-md-12"">
                            <textarea name=""CourseDescription"" class=""form-control"">");
                EndContext();
                BeginContext(2440, 24, false);
#line 45 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\Course\EditCourse.cshtml"
                                                                               Write(course.CourseDescription);

#line default
#line hidden
                EndContext();
                BeginContext(2464, 334, true);
                WriteLiteral(@"</textarea>
                            <small><span style=""color:red;"">*</span> Description</small>
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-md-12"">
                            <textarea name=""CourseAudience"" class=""form-control"">");
                EndContext();
                BeginContext(2799, 21, false);
#line 52 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\Course\EditCourse.cshtml"
                                                                            Write(course.CourseAudience);

#line default
#line hidden
                EndContext();
                BeginContext(2820, 359, true);
                WriteLiteral(@"</textarea>
                            <small><span style=""color:red;"">*</span> Audience (who this course is for)</small>
                        </div>
                    </div>

                     <div class=""row"">
                        <div class=""col-md-12"">
                            <textarea name=""CourseObjectives"" class=""form-control"">");
                EndContext();
                BeginContext(3180, 23, false);
#line 59 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\Course\EditCourse.cshtml"
                                                                              Write(course.CourseObjectives);

#line default
#line hidden
                EndContext();
                BeginContext(3203, 360, true);
                WriteLiteral(@"</textarea>
                            <small><span style=""color:red;"">*</span>Course Objectives (one per line)</small>
                        </div>
                    </div>



                </div>
                <div class=""form-group"">
                    <select class=""form-control"" placeholder=""..."" required name=""ECourseCategoryIdFk"">
");
                EndContext();
#line 69 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\Course\EditCourse.cshtml"
                         foreach (var item in course_categories)
                        {

#line default
#line hidden
                BeginContext(3656, 35, true);
                WriteLiteral("                            <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3691, "\"", 3707, 1);
#line 71 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\Course\EditCourse.cshtml"
WriteAttributeValue("", 3699, item.Id, 3699, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("selected", " selected=\"", 3708, "\"", 3757, 1);
#line 71 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\Course\EditCourse.cshtml"
WriteAttributeValue("", 3719, course.ECourseCategoryIdFk==item.Id, 3719, 38, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3758, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(3760, 13, false);
#line 71 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\Course\EditCourse.cshtml"
                                                                                                  Write(item.Category);

#line default
#line hidden
                EndContext();
                BeginContext(3773, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 72 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\Course\EditCourse.cshtml"
                        }

#line default
#line hidden
                BeginContext(3811, 258, true);
                WriteLiteral(@"                    </select>
                    <small><span style=""color:red;"">*</span> Course Category</small>
                </div>

                <div class=""form-group"">
                    <input type=""checkbox"" name=""Published"" value=""true"" ");
                EndContext();
                BeginContext(4071, 33, false);
#line 78 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\Course\EditCourse.cshtml"
                                                                     Write(course.Published ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(4105, 162, true);
                WriteLiteral(">\r\n                    <small>Published</small>\r\n                </div>\r\n                <button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4274, 290, true);
            WriteLiteral(@"
        </div>
    </div>
</div>


<script>
    $('#StartDate').Zebra_DatePicker({
        format: 'Y-m-d',
        direction: true,
        pair: $('#EndDate')
    });
    $('#EndDate').Zebra_DatePicker({
        format: 'Y-m-d',
        direction: true,
    });
</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

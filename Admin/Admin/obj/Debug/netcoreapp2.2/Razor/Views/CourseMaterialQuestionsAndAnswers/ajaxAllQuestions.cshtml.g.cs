#pragma checksum "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\ajaxAllQuestions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96f5b3990500eea233b8bed54e22cc9d970b6b2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CourseMaterialQuestionsAndAnswers_ajaxAllQuestions), @"mvc.1.0.view", @"/Views/CourseMaterialQuestionsAndAnswers/ajaxAllQuestions.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CourseMaterialQuestionsAndAnswers/ajaxAllQuestions.cshtml", typeof(AspNetCore.Views_CourseMaterialQuestionsAndAnswers_ajaxAllQuestions))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96f5b3990500eea233b8bed54e22cc9d970b6b2e", @"/Views/CourseMaterialQuestionsAndAnswers/ajaxAllQuestions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/_ViewImports.cshtml")]
    public class Views_CourseMaterialQuestionsAndAnswers_ajaxAllQuestions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:green;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/CourseQuestionsAndAnswers/DeleteQuestion"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("f1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\ajaxAllQuestions.cshtml"
  
    var questions = (List<Admin.Models.MCourseWorkQuestion>)ViewBag.questions;

#line default
#line hidden
            BeginContext(87, 232, true);
            WriteLiteral("\r\n<table id=\"dt\" class=\"table tblsm\">\r\n    <thead>\r\n        <tr>\r\n            <th>Coure Material</th>\r\n            <th>Type</th>\r\n            <th>Sequence</th>\r\n            <th>Action</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 15 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\ajaxAllQuestions.cshtml"
         foreach (var item in questions)
        {

#line default
#line hidden
            BeginContext(372, 37, true);
            WriteLiteral("            <tr>\r\n                <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 409, "\"", 462, 1);
#line 18 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\ajaxAllQuestions.cshtml"
WriteAttributeValue("", 417, item.MCourseMaterialIdFkNavigation.PageTitle, 417, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(463, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(465, 44, false);
#line 18 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\ajaxAllQuestions.cshtml"
                                                                     Write(item.MCourseMaterialIdFkNavigation.PageTitle);

#line default
#line hidden
            EndContext();
            BeginContext(509, 26, true);
            WriteLiteral("</td>\r\n                <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 535, "\"", 581, 1);
#line 19 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\ajaxAllQuestions.cshtml"
WriteAttributeValue("", 543, item.EQuestionTypeIdFkNavigation.Type, 543, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(582, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(584, 37, false);
#line 19 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\ajaxAllQuestions.cshtml"
                                                              Write(item.EQuestionTypeIdFkNavigation.Type);

#line default
#line hidden
            EndContext();
            BeginContext(621, 26, true);
            WriteLiteral("</td>\r\n                <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 647, "\"", 677, 1);
#line 20 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\ajaxAllQuestions.cshtml"
WriteAttributeValue("", 655, item.QuestionSequence, 655, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(678, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(680, 21, false);
#line 20 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\ajaxAllQuestions.cshtml"
                                              Write(item.QuestionSequence);

#line default
#line hidden
            EndContext();
            BeginContext(701, 49, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(750, 217, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96f5b3990500eea233b8bed54e22cc9d970b6b2e8434", async() => {
                BeginContext(911, 52, true);
                WriteLiteral("\r\n                        Open\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 759, "~/CourseMaterialQuestionsAndAnswers/CreateQuestionAndAnswer?course_material_id=", 759, 79, true);
#line 22 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\ajaxAllQuestions.cshtml"
AddHtmlAttributeValue("", 838, item.MCourseMaterialIdFk, 838, 27, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 865, "&question_id=", 865, 13, true);
#line 22 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\ajaxAllQuestions.cshtml"
AddHtmlAttributeValue("", 878, item.Id, 878, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(967, 93, true);
            WriteLiteral("\r\n                    |\r\n                    <a href=\"javascript:void(0);\" style=\"color:red;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1060, "\"", 1096, 3);
            WriteAttributeValue("", 1070, "confirm_delete(\'", 1070, 16, true);
#line 26 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\ajaxAllQuestions.cshtml"
WriteAttributeValue("", 1086, item.Id, 1086, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1094, "\')", 1094, 2, true);
            EndWriteAttribute();
            BeginContext(1097, 103, true);
            WriteLiteral(">\r\n                        Delete\r\n                    </a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 31 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\ajaxAllQuestions.cshtml"
        }

#line default
#line hidden
            BeginContext(1211, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(1237, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96f5b3990500eea233b8bed54e22cc9d970b6b2e11876", async() => {
                BeginContext(1317, 48, true);
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"id\" id=\"id\"/>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1372, 691, true);
            WriteLiteral(@"

<script>

    $('#dt').DataTable({
        select: true,
        responsive: true,
        dom: 'lBfrtip',
        buttons: [
            'copyHtml5',
            'excelHtml5',
            'csvHtml5',
            'pdfHtml5'
        ]
    });


    function confirm_delete(id) {
        $.confirm({
            title: 'Information',
            type: ""red"",
            content: 'Delete this Question?',
            buttons: {
                Yes: function () {
                    $(""#id"").val(id);
                    $(""#f1"").submit();
                },
                No: function () {
                },

            }
        });

    }

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
#pragma checksum "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\BoardGame.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4f18dd805b4d5684914982631d750a44f801e87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CourseMaterialQuestionsAndAnswers_BoardGame), @"mvc.1.0.view", @"/Views/CourseMaterialQuestionsAndAnswers/BoardGame.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CourseMaterialQuestionsAndAnswers/BoardGame.cshtml", typeof(AspNetCore.Views_CourseMaterialQuestionsAndAnswers_BoardGame))]
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
#line 7 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\BoardGame.cshtml"
using Humanizer;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4f18dd805b4d5684914982631d750a44f801e87", @"/Views/CourseMaterialQuestionsAndAnswers/BoardGame.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/_ViewImports.cshtml")]
    public class Views_CourseMaterialQuestionsAndAnswers_BoardGame : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/BoardGame/AddTitle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/BoardGame/AddItem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/BoardGame/DeleteTitle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("delete_title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/BoardGame/DeleteItem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("delete_item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\BoardGame.cshtml"
  
    Layout = "~/Views/Shared/_LayoutMain.cshtml";
    var course_material = (Admin.Models.MCourseMaterial)ViewBag.course_material;
    var board_game = (Admin.Models.MBoardGame)ViewBag.board_game;
    

#line default
#line hidden
            BeginContext(231, 95, true);
            WriteLiteral("<div class=\"container\">\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            ");
            EndContext();
            BeginContext(326, 530, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4f18dd805b4d5684914982631d750a44f801e876680", async() => {
                BeginContext(389, 64, true);
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"course_material_id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 453, "\"", 480, 1);
#line 13 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\BoardGame.cshtml"
WriteAttributeValue("", 461, course_material.Id, 461, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(481, 41, true);
                WriteLiteral(" />\r\n                <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 522, "\"", 544, 1);
#line 14 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\BoardGame.cshtml"
WriteAttributeValue("", 530, board_game.Id, 530, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(545, 304, true);
                WriteLiteral(@" name=""MBoardGameIdFk"" />
                <div class=""form-group"">
                    title: <input placeholder=""title"" type=""text"" required name=""Title"" class=""form-control"" />
                </div>
                <button type=""submit"" class=""btn btn-success btn-sm"">Submit</button>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(856, 250, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <h3>titles</h3>\r\n    <table id=\"dt\" class=\"table tblsm\">\r\n        <thead>\r\n            <tr>\r\n                <th>title</th>\r\n                <th>Action</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 33 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\BoardGame.cshtml"
             foreach (var item in board_game.MBoardGameTitles)
            {

#line default
#line hidden
            BeginContext(1185, 45, true);
            WriteLiteral("                <tr>\r\n                    <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1230, "\"", 1249, 1);
#line 36 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\BoardGame.cshtml"
WriteAttributeValue("", 1238, item.Title, 1238, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1250, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1252, 10, false);
#line 36 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\BoardGame.cshtml"
                                       Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1262, 105, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a href=\"javascript:void(0);\" style=\"color:red;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1367, "\"", 1409, 3);
            WriteAttributeValue("", 1377, "confirm_delete_title(\'", 1377, 22, true);
#line 38 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\BoardGame.cshtml"
WriteAttributeValue("", 1399, item.Id, 1399, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1407, "\')", 1407, 2, true);
            EndWriteAttribute();
            BeginContext(1410, 119, true);
            WriteLiteral(">\r\n                            Delete\r\n                        </a>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 43 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\BoardGame.cshtml"
            }

#line default
#line hidden
            BeginContext(1544, 162, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <br />\r\n    <br />\r\n    <br />\r\n    <br />\r\n    <br />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            ");
            EndContext();
            BeginContext(1706, 929, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4f18dd805b4d5684914982631d750a44f801e8712382", async() => {
                BeginContext(1768, 64, true);
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"course_material_id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1832, "\"", 1859, 1);
#line 55 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\BoardGame.cshtml"
WriteAttributeValue("", 1840, course_material.Id, 1840, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1860, 41, true);
                WriteLiteral(" />\r\n                <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1901, "\"", 1923, 1);
#line 56 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\BoardGame.cshtml"
WriteAttributeValue("", 1909, board_game.Id, 1909, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1924, 346, true);
                WriteLiteral(@" name=""MBoardGameIdFk"" />
                <div class=""form-group"">
                    Item text: <input type=""text"" name=""ItemText"" placeholder=""ItemText"" required class=""form-control"" />
                </div>
                <div class=""form-group"">
                    CorrectTitle:<select name=""CorrectTitleIdFk"" class=""form-control"">
");
                EndContext();
#line 62 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\BoardGame.cshtml"
                         foreach (var item in board_game.MBoardGameTitles)
                        {

#line default
#line hidden
                BeginContext(2373, 35, true);
                WriteLiteral("                            <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2408, "\"", 2424, 1);
#line 64 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\BoardGame.cshtml"
WriteAttributeValue("", 2416, item.Id, 2416, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2425, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2427, 10, false);
#line 64 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\BoardGame.cshtml"
                                                Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(2437, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 65 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\BoardGame.cshtml"
                        }

#line default
#line hidden
                BeginContext(2475, 153, true);
                WriteLiteral("                    </select>\r\n                </div>\r\n                <button type=\"submit\" class=\"btn btn-success btn-sm\">Submit</button>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2635, 291, true);
            WriteLiteral(@"
        </div>
    </div>

    <br />
    <h3>items</h3>
    <table id=""dt1"" class=""table tblsm"">
        <thead>
            <tr>
                <th>text</th>
                <th>title</th>
                <th>Action</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 84 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\BoardGame.cshtml"
             foreach (var item in board_game.MBoardGameItems)
            {

#line default
#line hidden
            BeginContext(3004, 45, true);
            WriteLiteral("                <tr>\r\n                    <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 3049, "\"", 3071, 1);
#line 87 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\BoardGame.cshtml"
WriteAttributeValue("", 3057, item.ItemText, 3057, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3072, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3074, 13, false);
#line 87 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\BoardGame.cshtml"
                                          Write(item.ItemText);

#line default
#line hidden
            EndContext();
            BeginContext(3087, 30, true);
            WriteLiteral("</td>\r\n                    <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 3117, "\"", 3177, 1);
#line 88 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\BoardGame.cshtml"
WriteAttributeValue("", 3125, Globals.FetchBoardGameTitle(item.CorrectTitleIdNfk), 3125, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3178, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(3181, 51, false);
#line 88 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\BoardGame.cshtml"
                                                                                 Write(Globals.FetchBoardGameTitle(item.CorrectTitleIdNfk));

#line default
#line hidden
            EndContext();
            BeginContext(3232, 106, true);
            WriteLiteral(" </td>\r\n                    <td>\r\n                        <a href=\"javascript:void(0);\" style=\"color:red;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3338, "\"", 3379, 3);
            WriteAttributeValue("", 3348, "confirm_delete_item(\'", 3348, 21, true);
#line 90 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\BoardGame.cshtml"
WriteAttributeValue("", 3369, item.Id, 3369, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 3377, "\')", 3377, 2, true);
            EndWriteAttribute();
            BeginContext(3380, 119, true);
            WriteLiteral(">\r\n                            Delete\r\n                        </a>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 95 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\BoardGame.cshtml"
            }

#line default
#line hidden
            BeginContext(3514, 44, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(3558, 216, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4f18dd805b4d5684914982631d750a44f801e8720870", async() => {
                BeginContext(3629, 52, true);
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"course_material_id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3681, "\"", 3708, 1);
#line 102 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\BoardGame.cshtml"
WriteAttributeValue("", 3689, course_material.Id, 3689, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3709, 58, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"id\" id=\"title_id\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3774, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(3778, 213, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4f18dd805b4d5684914982631d750a44f801e8722937", async() => {
                BeginContext(3847, 52, true);
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"course_material_id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3899, "\"", 3926, 1);
#line 107 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterialQuestionsAndAnswers\BoardGame.cshtml"
WriteAttributeValue("", 3907, course_material.Id, 3907, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3927, 57, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"id\" id=\"item_id\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3991, 1382, true);
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

    $('#dt1').DataTable({
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


    function confirm_delete_title(id) {
        $.confirm({
            title: 'Information',
            type: ""red"",
            content: 'Delete this Title?',
            buttons: {
                Yes: function () {
                    $(""#title_id"").val(id);
                    $(""#delete_title"").submit();
                },
                No: function () {
                },
            }
        });
    }

    function confirm_delete_item(id) {
        $.confirm({
            title: '");
            WriteLiteral(@"Information',
            type: ""red"",
            content: 'Delete this Item?',
            buttons: {
                Yes: function () {
                    $(""#item_id"").val(id);
                    $(""#delete_item"").submit();
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
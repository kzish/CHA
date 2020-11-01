#pragma checksum "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterial\CreateCourseMaterial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f30b406458e56531217cfcad315cde10166500c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CourseMaterial_CreateCourseMaterial), @"mvc.1.0.view", @"/Views/CourseMaterial/CreateCourseMaterial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CourseMaterial/CreateCourseMaterial.cshtml", typeof(AspNetCore.Views_CourseMaterial_CreateCourseMaterial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f30b406458e56531217cfcad315cde10166500c9", @"/Views/CourseMaterial/CreateCourseMaterial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/_ViewImports.cshtml")]
    public class Views_CourseMaterial_CreateCourseMaterial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/CourseMaterial/CreateCourseMaterial"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterial\CreateCourseMaterial.cshtml"
  
    Layout = "~/Views/Shared/_LayoutMain.cshtml";
    var course = (Admin.Models.MCourse)ViewBag.course;
    var topics = (List<Admin.Models.MCourseTopic>)ViewBag.topics;

#line default
#line hidden
            BeginContext(181, 123, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            Create Material for Course: ");
            EndContext();
            BeginContext(305, 17, false);
#line 10 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterial\CreateCourseMaterial.cshtml"
                                   Write(course.CourseName);

#line default
#line hidden
            EndContext();
            BeginContext(322, 98, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            ");
            EndContext();
            BeginContext(420, 1673, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f30b406458e56531217cfcad315cde10166500c94822", async() => {
                BeginContext(487, 57, true);
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"MCourseIdFk\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 544, "\"", 562, 1);
#line 16 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterial\CreateCourseMaterial.cshtml"
WriteAttributeValue("", 552, course.Id, 552, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(563, 124, true);
                WriteLiteral(" />\r\n\r\n                <div class=\"form-group\">\r\n                    <select class=\"form-control\" name=\"MCourseTopicIdFk\">\r\n");
                EndContext();
#line 20 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterial\CreateCourseMaterial.cshtml"
                         foreach (var item in topics)
                        {

#line default
#line hidden
                BeginContext(769, 35, true);
                WriteLiteral("                            <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 804, "\"", 820, 1);
#line 22 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterial\CreateCourseMaterial.cshtml"
WriteAttributeValue("", 812, item.Id, 812, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(821, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(823, 10, false);
#line 22 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterial\CreateCourseMaterial.cshtml"
                                                Write(item.Topic);

#line default
#line hidden
                EndContext();
                BeginContext(833, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 23 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterial\CreateCourseMaterial.cshtml"
                        }

#line default
#line hidden
                BeginContext(871, 1215, true);
                WriteLiteral(@"                    </select>
                    <small><span style=""color:red;"">*</span> Course Topic</small>
                </div>

                <div class=""form-group"">
                    <input type=""text"" class=""form-control"" placeholder=""..."" required name=""PageTitle"" value="""">
                    <small><span style=""color:red;"">*</span> Title</small>
                </div>

                <div class=""form-group"">
                    <input type=""number"" class=""form-control"" placeholder=""..."" required name=""PageSequence"" min=""0"" value=""0"">
                    <small><span style=""color:red;"">*</span> Sequence</small>
                </div>

                <div class=""form-group"">
                    <textarea id=""editor"" class=""form-control"" placeholder=""..."" name=""PageData""></textarea>
                    <small><span style=""color:red;"">*</span> Page Data</small>
                </div>



                <div class=""form-group"">
                    <input type=""checkbox"" na");
                WriteLiteral("me=\"Published\" value=\"true\" />\r\n                    <small>Published</small>\r\n                </div>\r\n                <button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n            ");
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
            BeginContext(2093, 205, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n    ClassicEditor\r\n        .create(document.querySelector(\'#editor\'))\r\n        .catch(error => {\r\n            console.error(error);\r\n        });\r\n</script>");
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

#pragma checksum "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterial\EditCourseMaterial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06d6f48356c7bb3e11b19674942e461c99485c8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CourseMaterial_EditCourseMaterial), @"mvc.1.0.view", @"/Views/CourseMaterial/EditCourseMaterial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CourseMaterial/EditCourseMaterial.cshtml", typeof(AspNetCore.Views_CourseMaterial_EditCourseMaterial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06d6f48356c7bb3e11b19674942e461c99485c8f", @"/Views/CourseMaterial/EditCourseMaterial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/_ViewImports.cshtml")]
    public class Views_CourseMaterial_EditCourseMaterial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/CourseMaterial/EditCourseMaterial"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterial\EditCourseMaterial.cshtml"
  
    Layout = "~/Views/Shared/_LayoutMain.cshtml";
    var topics = (List<Admin.Models.MCourseTopic>)ViewBag.topics;
    var material = (Admin.Models.MCourseMaterial)ViewBag.material;

#line default
#line hidden
            BeginContext(193, 121, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            Edit Material for Course: ");
            EndContext();
            BeginContext(315, 41, false);
#line 10 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterial\EditCourseMaterial.cshtml"
                                 Write(material.MCourseIdFkNavigation.CourseName);

#line default
#line hidden
            EndContext();
            BeginContext(356, 98, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            ");
            EndContext();
            BeginContext(454, 1812, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06d6f48356c7bb3e11b19674942e461c99485c8f4834", async() => {
                BeginContext(519, 94, true);
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 613, "\"", 633, 1);
#line 17 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterial\EditCourseMaterial.cshtml"
WriteAttributeValue("", 621, material.Id, 621, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(634, 80, true);
                WriteLiteral(" />\r\n                    <select class=\"form-control\" name=\"MCourseTopicIdFk\">\r\n");
                EndContext();
#line 19 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterial\EditCourseMaterial.cshtml"
                         foreach (var item in topics)
                        {

#line default
#line hidden
                BeginContext(796, 35, true);
                WriteLiteral("                            <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 831, "\"", 847, 1);
#line 21 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterial\EditCourseMaterial.cshtml"
WriteAttributeValue("", 839, item.Id, 839, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("selected", " selected=\"", 848, "\"", 896, 1);
#line 21 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterial\EditCourseMaterial.cshtml"
WriteAttributeValue("", 859, material.MCourseTopicIdFk==item.Id, 859, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(897, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(899, 10, false);
#line 21 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterial\EditCourseMaterial.cshtml"
                                                                                                 Write(item.Topic);

#line default
#line hidden
                EndContext();
                BeginContext(909, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 22 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterial\EditCourseMaterial.cshtml"
                        }

#line default
#line hidden
                BeginContext(947, 285, true);
                WriteLiteral(@"                    </select>
                    <small><span style=""color:red;"">*</span> Course Topic</small>
                </div>

                <div class=""form-group"">
                    <input type=""text"" class=""form-control"" placeholder=""..."" required name=""PageTitle""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1232, "\"", 1259, 1);
#line 28 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterial\EditCourseMaterial.cshtml"
WriteAttributeValue("", 1240, material.PageTitle, 1240, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1260, 263, true);
                WriteLiteral(@">
                    <small><span style=""color:red;"">*</span> Title</small>
                </div>

                <div class=""form-group"">
                    <input type=""number"" class=""form-control"" placeholder=""..."" required name=""PageSequence"" min=""0""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1523, "\"", 1553, 1);
#line 33 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterial\EditCourseMaterial.cshtml"
WriteAttributeValue("", 1531, material.PageSequence, 1531, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1554, 247, true);
                WriteLiteral(">\r\n                    <small><span style=\"color:red;\">*</span> Sequence</small>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <textarea id=\"editor\" class=\"form-control\" placeholder=\"...\" name=\"PageData\">");
                EndContext();
                BeginContext(1802, 17, false);
#line 38 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterial\EditCourseMaterial.cshtml"
                                                                                            Write(material.PageData);

#line default
#line hidden
                EndContext();
                BeginContext(1819, 238, true);
                WriteLiteral("</textarea>\r\n                    <small><span style=\"color:red;\">*</span> Page Data</small>\r\n                </div>\r\n\r\n\r\n\r\n                <div class=\"form-group\">\r\n                    <input type=\"checkbox\" name=\"Published\" value=\"true\" ");
                EndContext();
                BeginContext(2059, 35, false);
#line 45 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\CourseMaterial\EditCourseMaterial.cshtml"
                                                                     Write(material.Published ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(2095, 164, true);
                WriteLiteral(" />\r\n                    <small>Published</small>\r\n                </div>\r\n                <button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n            ");
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
            BeginContext(2266, 205, true);
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

#pragma checksum "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\Course\EditCourseCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ec9dfc1ed84be6c6a9849b952619952a6dc5168"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_EditCourseCategory), @"mvc.1.0.view", @"/Views/Course/EditCourseCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Course/EditCourseCategory.cshtml", typeof(AspNetCore.Views_Course_EditCourseCategory))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ec9dfc1ed84be6c6a9849b952619952a6dc5168", @"/Views/Course/EditCourseCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_EditCourseCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Course/EditCourseCategory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\Course\EditCourseCategory.cshtml"
  
    Layout = "~/Views/Shared/_LayoutMain.cshtml";
    var course_category = (Admin.Models.ECourseCategory)ViewBag.course_category;

#line default
#line hidden
            BeginContext(140, 95, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            ");
            EndContext();
            BeginContext(235, 527, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ec9dfc1ed84be6c6a9849b952619952a6dc51684148", async() => {
                BeginContext(292, 84, true);
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 376, "\"", 403, 1);
#line 11 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\Course\EditCourseCategory.cshtml"
WriteAttributeValue("", 384, course_category.Id, 384, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(404, 117, true);
                WriteLiteral(" name=\"Id\" />\r\n                    <input type=\"text\" class=\"form-control\" placeholder=\"...\" required name=\"Category\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 521, "\"", 554, 1);
#line 12 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Admin\Admin\Views\Course\EditCourseCategory.cshtml"
WriteAttributeValue("", 529, course_category.Category, 529, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(555, 200, true);
                WriteLiteral(">\r\n                    <small><span style=\"color:red;\">*</span> Category Name</small>\r\n                </div>\r\n                <button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n            ");
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
            BeginContext(762, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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

#pragma checksum "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Company\Views\Home\AllRoles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fe919996472a1085e2551882e1198a3afc370ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AllRoles), @"mvc.1.0.view", @"/Views/Home/AllRoles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AllRoles.cshtml", typeof(AspNetCore.Views_Home_AllRoles))]
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
#line 1 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Company\Views\_ViewImports.cshtml"
using Company;

#line default
#line hidden
#line 2 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Company\Views\_ViewImports.cshtml"
using Company.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fe919996472a1085e2551882e1198a3afc370ad", @"/Views/Home/AllRoles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7476266b3089f8d281ffba0e0ee7fc97e38e65ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AllRoles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Company\Views\Home\AllRoles.cshtml"
  
    Layout = "~/Views/Shared/_LayoutMain.cshtml";
    var roles = (List<Microsoft.AspNetCore.Identity.IdentityRole>)ViewBag.roles;

#line default
#line hidden
            BeginContext(140, 9, true);
            WriteLiteral("<style>\r\n");
            EndContext();
            BeginContext(206, 133, true);
            WriteLiteral("    .custom-select\r\n    {\r\n        height:30px!important;\r\n        width:50px!important;\r\n        margin-left:5px!important;\r\n    }\r\n");
            EndContext();
            BeginContext(383, 426, true);
            WriteLiteral(@"    .dt-buttons
    {
        margin-left:4px!important;
    }
</style>



<div class=""container"">
    <div class=""row"">
        <div class=""col-md-12"">
            <table id=""dt"" class=""table tblsm"">
                <thead>
                    <tr>
                        <th>RoleName</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 33 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Company\Views\Home\AllRoles.cshtml"
                     foreach (var item in roles)
                    {

#line default
#line hidden
            BeginContext(882, 61, true);
            WriteLiteral("                        <tr>\r\n                            <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 943, "\"", 961, 1);
#line 36 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Company\Views\Home\AllRoles.cshtml"
WriteAttributeValue("", 951, item.Name, 951, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(962, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(964, 9, false);
#line 36 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Company\Views\Home\AllRoles.cshtml"
                                              Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(973, 41, true);
            WriteLiteral("</td>\r\n                            <td>\r\n");
            EndContext();
            BeginContext(1220, 66, true);
            WriteLiteral("                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 43 "C:\Users\Kudzai\Documents\Visual Studio 2019\Projects\CHAPROJECT\Company\Views\Home\AllRoles.cshtml"
                    }

#line default
#line hidden
            BeginContext(1309, 760, true);
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>
</div>

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
            content: 'Delete this Role?',
            buttons: {
                Yes: function () {
                    window.location = ""../Clients/DeleteRole/"" + id;
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

<<<<<<< HEAD
#pragma checksum "C:\Users\Mobashwir Hasan\Documents\GitHub\WorldHorseRescueDatabase\JobPortal\Views\Horses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96f46048cc7b2568b4c851b39d1c834a05d45ab1"
=======
#pragma checksum "D:\Rex Web Solution Bangladesh\WorldHorseRescueDatabase\WorldHorseRescueDatabase\JobPortal\Views\Horses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0d4330ff0b50ea5ab5b43b988f04ca462defaa9"
>>>>>>> d5641131623cf7faf9a31fe2881fc17e3c51ef4a
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Horses_Index), @"mvc.1.0.view", @"/Views/Horses/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Horses/Index.cshtml", typeof(AspNetCore.Views_Horses_Index))]
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
<<<<<<< HEAD
#line 1 "C:\Users\Mobashwir Hasan\Documents\GitHub\WorldHorseRescueDatabase\JobPortal\Views\_ViewImports.cshtml"
=======
#line 1 "D:\Rex Web Solution Bangladesh\WorldHorseRescueDatabase\WorldHorseRescueDatabase\JobPortal\Views\_ViewImports.cshtml"
>>>>>>> d5641131623cf7faf9a31fe2881fc17e3c51ef4a
using JobPortal;

#line default
#line hidden
<<<<<<< HEAD
#line 2 "C:\Users\Mobashwir Hasan\Documents\GitHub\WorldHorseRescueDatabase\JobPortal\Views\_ViewImports.cshtml"
=======
#line 2 "D:\Rex Web Solution Bangladesh\WorldHorseRescueDatabase\WorldHorseRescueDatabase\JobPortal\Views\_ViewImports.cshtml"
>>>>>>> d5641131623cf7faf9a31fe2881fc17e3c51ef4a
using JobPortal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0d4330ff0b50ea5ab5b43b988f04ca462defaa9", @"/Views/Horses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5746195fa5c04b1f3448d93ea0c4c81300dcf6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Horses_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JobPortal.Models.Horse>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success waves-effect waves-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 1, true);
            WriteLiteral("\n");
            EndContext();
<<<<<<< HEAD
#line 3 "C:\Users\Mobashwir Hasan\Documents\GitHub\WorldHorseRescueDatabase\JobPortal\Views\Horses\Index.cshtml"
=======
#line 3 "D:\Rex Web Solution Bangladesh\WorldHorseRescueDatabase\WorldHorseRescueDatabase\JobPortal\Views\Horses\Index.cshtml"
>>>>>>> d5641131623cf7faf9a31fe2881fc17e3c51ef4a
  
    Layout = "~/Views/Shared/_LayoutMain.cshtml";

#line default
#line hidden
            BeginContext(99, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("CssSection", async() => {
                BeginContext(120, 601, true);
                WriteLiteral(@"


    <style>
        .modal-title {
            margin: 0;
            line-height: 1.42857143;
        }

        h4 {
            display: block;
            margin-block-start: 1.33em;
            margin-block-end: 1.33em;
            margin-inline-start: 0px;
            margin-inline-end: 0px;
            font-weight: bold;
        }

        .modal-body {
            position: relative;
            -ms-flex: 1 1 auto;
            flex: 1 1 auto;
            /* padding: 1rem; */
            padding-left: 25px;
        }

        p {
            font-weight: bolder
        }
    </style>
");
                EndContext();
            }
            );
            BeginContext(723, 781, true);
            WriteLiteral(@"
<div class=""content"">
<div class=""container-fluid"">
<div class=""row"">
    <div class=""col-sm-12"">
        <div class=""page-title-box"">
            <h4 class=""page-title"">Horse List</h4>

            <div class=""state-information d-none d-sm-block"">

            </div>
        </div>
    </div>
</div>
<!-- end row -->
<div class=""row"">
<div class=""col-12"">
<div class=""card m-b-20"">
<div class=""card-body"">
<table id=""datatable"" class=""table table-bordered dt-responsive nowrap"" style=""border-collapse: collapse; border-spacing: 0; width: 100%;"">
    <thead>
    <tr>
        <th>HorseName</th>
        <th>RegistrationNumber</th>
        <th>Gender</th>
        <th>Color</th>
        <th>RegistrationAssociation</th>
        <th>Details</th>
    </tr>
    </thead>
    <tbody>
");
            EndContext();
<<<<<<< HEAD
#line 69 "C:\Users\Mobashwir Hasan\Documents\GitHub\WorldHorseRescueDatabase\JobPortal\Views\Horses\Index.cshtml"
=======
#line 69 "D:\Rex Web Solution Bangladesh\WorldHorseRescueDatabase\WorldHorseRescueDatabase\JobPortal\Views\Horses\Index.cshtml"
>>>>>>> d5641131623cf7faf9a31fe2881fc17e3c51ef4a
     foreach (var item in Model)
    {


#line default
#line hidden
            BeginContext(1544, 29, true);
            WriteLiteral("        <tr>\n            <td>");
            EndContext();
<<<<<<< HEAD
            BeginContext(1636, 14, false);
#line 73 "C:\Users\Mobashwir Hasan\Documents\GitHub\WorldHorseRescueDatabase\JobPortal\Views\Horses\Index.cshtml"
=======
            BeginContext(1574, 14, false);
#line 73 "D:\Rex Web Solution Bangladesh\WorldHorseRescueDatabase\WorldHorseRescueDatabase\JobPortal\Views\Horses\Index.cshtml"
>>>>>>> d5641131623cf7faf9a31fe2881fc17e3c51ef4a
           Write(item.HorseName);

#line default
#line hidden
            EndContext();
            BeginContext(1588, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
<<<<<<< HEAD
            BeginContext(1674, 23, false);
#line 74 "C:\Users\Mobashwir Hasan\Documents\GitHub\WorldHorseRescueDatabase\JobPortal\Views\Horses\Index.cshtml"
=======
            BeginContext(1611, 23, false);
#line 74 "D:\Rex Web Solution Bangladesh\WorldHorseRescueDatabase\WorldHorseRescueDatabase\JobPortal\Views\Horses\Index.cshtml"
>>>>>>> d5641131623cf7faf9a31fe2881fc17e3c51ef4a
           Write(item.RegistrationNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1634, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
<<<<<<< HEAD
            BeginContext(1721, 11, false);
#line 75 "C:\Users\Mobashwir Hasan\Documents\GitHub\WorldHorseRescueDatabase\JobPortal\Views\Horses\Index.cshtml"
=======
            BeginContext(1657, 11, false);
#line 75 "D:\Rex Web Solution Bangladesh\WorldHorseRescueDatabase\WorldHorseRescueDatabase\JobPortal\Views\Horses\Index.cshtml"
>>>>>>> d5641131623cf7faf9a31fe2881fc17e3c51ef4a
           Write(item.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(1668, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
<<<<<<< HEAD
            BeginContext(1756, 10, false);
#line 76 "C:\Users\Mobashwir Hasan\Documents\GitHub\WorldHorseRescueDatabase\JobPortal\Views\Horses\Index.cshtml"
=======
            BeginContext(1691, 10, false);
#line 76 "D:\Rex Web Solution Bangladesh\WorldHorseRescueDatabase\WorldHorseRescueDatabase\JobPortal\Views\Horses\Index.cshtml"
>>>>>>> d5641131623cf7faf9a31fe2881fc17e3c51ef4a
           Write(item.Color);

#line default
#line hidden
            EndContext();
            BeginContext(1701, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
<<<<<<< HEAD
            BeginContext(1790, 28, false);
#line 77 "C:\Users\Mobashwir Hasan\Documents\GitHub\WorldHorseRescueDatabase\JobPortal\Views\Horses\Index.cshtml"
=======
            BeginContext(1724, 28, false);
#line 77 "D:\Rex Web Solution Bangladesh\WorldHorseRescueDatabase\WorldHorseRescueDatabase\JobPortal\Views\Horses\Index.cshtml"
>>>>>>> d5641131623cf7faf9a31fe2881fc17e3c51ef4a
           Write(item.RegistrationAssociation);

#line default
#line hidden
            EndContext();
            BeginContext(1752, 23, true);
            WriteLiteral("</td>\n            <td>\n");
            EndContext();
            BeginContext(1968, 41, true);
            WriteLiteral("                <div class=\"float-right\">");
            EndContext();
<<<<<<< HEAD
            BeginContext(2078, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "070a859694cd40dc88ea8b2ff76075bf", async() => {
                BeginContext(2175, 27, true);
=======
            BeginContext(2009, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cf581e8452b4b4387647ae3238afc0b", async() => {
                BeginContext(2106, 27, true);
>>>>>>> d5641131623cf7faf9a31fe2881fc17e3c51ef4a
                WriteLiteral("<i class=\"fa fa-print\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
<<<<<<< HEAD
#line 80 "C:\Users\Mobashwir Hasan\Documents\GitHub\WorldHorseRescueDatabase\JobPortal\Views\Horses\Index.cshtml"
=======
#line 80 "D:\Rex Web Solution Bangladesh\WorldHorseRescueDatabase\WorldHorseRescueDatabase\JobPortal\Views\Horses\Index.cshtml"
>>>>>>> d5641131623cf7faf9a31fe2881fc17e3c51ef4a
                                                                   WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2137, 39, true);
            WriteLiteral("</div>\n            </td>\n        </tr>\n");
            EndContext();
<<<<<<< HEAD
#line 125 "C:\Users\Mobashwir Hasan\Documents\GitHub\WorldHorseRescueDatabase\JobPortal\Views\Horses\Index.cshtml"
=======
#line 125 "D:\Rex Web Solution Bangladesh\WorldHorseRescueDatabase\WorldHorseRescueDatabase\JobPortal\Views\Horses\Index.cshtml"
>>>>>>> d5641131623cf7faf9a31fe2881fc17e3c51ef4a
               
    }

#line default
#line hidden
            BeginContext(3564, 139, true);
            WriteLiteral("    </tbody>\n</table>\n\n</div>\n</div>\n</div>\n    <!-- end col -->\n</div>\n\n<!-- Modal -->\n       \n</div>\n    <!-- container-fluid -->\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JobPortal.Models.Horse>> Html { get; private set; }
    }
}
#pragma warning restore 1591

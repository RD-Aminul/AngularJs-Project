#pragma checksum "D:\IDB_Course\Core_Course\Project\Angular JS\Angular Js Project\Angular Js Project\Views\Classes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab984352d9bbf4b70297cdb07222090ba3b76c04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Angular_Js_Project.Classes.Views_Classes_Index), @"mvc.1.0.view", @"/Views/Classes/Index.cshtml")]
namespace Angular_Js_Project.Classes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\IDB_Course\Core_Course\Project\Angular JS\Angular Js Project\Angular Js Project\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\IDB_Course\Core_Course\Project\Angular JS\Angular Js Project\Angular Js Project\Views\_ViewImports.cshtml"
using Angular_Js_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\IDB_Course\Core_Course\Project\Angular JS\Angular Js Project\Angular Js Project\Views\_ViewImports.cshtml"
using Angular_Js_Project.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\IDB_Course\Core_Course\Project\Angular JS\Angular Js Project\Angular Js Project\Views\_ViewImports.cshtml"
using Angular_Js_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\IDB_Course\Core_Course\Project\Angular JS\Angular Js Project\Angular Js Project\Views\_ViewImports.cshtml"
using Angular_Js_Project.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab984352d9bbf4b70297cdb07222090ba3b76c04", @"/Views/Classes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62dc7a871abc8d480f8ae90a22934e20e0088a88", @"/Views/_ViewImports.cshtml")]
    public class Views_Classes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Class>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/twitter-bootstrap/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 2 "D:\IDB_Course\Core_Course\Project\Angular JS\Angular Js Project\Angular Js Project\Views\Classes\Index.cshtml"
  
    ViewData["Title"] = "| Class";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ab984352d9bbf4b70297cdb07222090ba3b76c044944", async() => {
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
            WriteLiteral("\r\n<h1>List of Class</h1>\r\n<div>\r\n    <p>");
#nullable restore
#line 12 "D:\IDB_Course\Core_Course\Project\Angular JS\Angular Js Project\Angular Js Project\Views\Classes\Index.cshtml"
  Write(Html.ActionLink("Create New Class", "Create", "Classes"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <table class=\"table table-bordered\">\r\n        <thead>\r\n            <tr style=\"text-align:center\">\r\n                <th>Class ID</th>\r\n                <th>Class Name</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 21 "D:\IDB_Course\Core_Course\Project\Angular JS\Angular Js Project\Angular Js Project\Views\Classes\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr style=\"text-align:center\">\r\n                    <td>");
#nullable restore
#line 24 "D:\IDB_Course\Core_Course\Project\Angular JS\Angular Js Project\Angular Js Project\Views\Classes\Index.cshtml"
                   Write(item.ClassID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "D:\IDB_Course\Core_Course\Project\Angular JS\Angular Js Project\Angular Js Project\Views\Classes\Index.cshtml"
                   Write(item.ClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 27 "D:\IDB_Course\Core_Course\Project\Angular JS\Angular Js Project\Angular Js Project\Views\Classes\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Class>> Html { get; private set; }
    }
}
#pragma warning restore 1591

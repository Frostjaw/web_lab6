#pragma checksum "D:\Учеба\3 course\Web-технология\Лабы 2 сем\lab6_v2-20190529T134624Z-001\lab6_v2\lab6_v2\Views\Topics\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c817ab224861c0dfcecf0e13269b04604b4d22b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Topics_Index), @"mvc.1.0.view", @"/Views/Topics/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Topics/Index.cshtml", typeof(AspNetCore.Views_Topics_Index))]
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
#line 1 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\lab6_v2-20190529T134624Z-001\lab6_v2\lab6_v2\Views\_ViewImports.cshtml"
using lab6_v2;

#line default
#line hidden
#line 2 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\lab6_v2-20190529T134624Z-001\lab6_v2\lab6_v2\Views\_ViewImports.cshtml"
using lab6_v2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c817ab224861c0dfcecf0e13269b04604b4d22b", @"/Views/Topics/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e87b585eb1e7ac41a0b19ca72916a66f91e81299", @"/Views/_ViewImports.cshtml")]
    public class Views_Topics_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<lab6_v2.Models.Topic>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\lab6_v2-20190529T134624Z-001\lab6_v2\lab6_v2\Views\Topics\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(85, 12, true);
            WriteLiteral("\r\n<h2>Forum ");
            EndContext();
            BeginContext(98, 12, false);
#line 7 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\lab6_v2-20190529T134624Z-001\lab6_v2\lab6_v2\Views\Topics\Index.cshtml"
     Write(ViewBag.name);

#line default
#line hidden
            EndContext();
            BeginContext(110, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(113, 10, false);
#line 7 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\lab6_v2-20190529T134624Z-001\lab6_v2\lab6_v2\Views\Topics\Index.cshtml"
                    Write(ViewBag.id);

#line default
#line hidden
            EndContext();
            BeginContext(123, 19, true);
            WriteLiteral(")</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(142, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8491222c3d184dc78cb356793384b37b", async() => {
                BeginContext(192, 10, true);
                WriteLiteral("Create New");
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
#line 10 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\lab6_v2-20190529T134624Z-001\lab6_v2\lab6_v2\Views\Topics\Index.cshtml"
                             WriteLiteral(ViewBag.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(206, 32, true);
            WriteLiteral("\r\n</p>\r\n\r\n<div class=\"main\">\r\n\r\n");
            EndContext();
#line 15 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\lab6_v2-20190529T134624Z-001\lab6_v2\lab6_v2\Views\Topics\Index.cshtml"
     foreach (var item in Model)
    {
        

#line default
#line hidden
#line 17 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\lab6_v2-20190529T134624Z-001\lab6_v2\lab6_v2\Views\Topics\Index.cshtml"
         if (@ViewBag.id == item.CategoryId)
        {

#line default
#line hidden
            BeginContext(336, 53, true);
            WriteLiteral("            <div class=\"main-item\">\r\n                ");
            EndContext();
            BeginContext(389, 314, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a937a536c86b4ced87c640c62146813a", async() => {
                BeginContext(437, 51, true);
                WriteLiteral("\r\n                    <h1 class=\"main-item__title\">");
                EndContext();
                BeginContext(489, 40, false);
#line 21 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\lab6_v2-20190529T134624Z-001\lab6_v2\lab6_v2\Views\Topics\Index.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
                EndContext();
                BeginContext(529, 37, true);
                WriteLiteral("</h1>\r\n\r\n                    <div>by ");
                EndContext();
                BeginContext(567, 43, false);
#line 23 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\lab6_v2-20190529T134624Z-001\lab6_v2\lab6_v2\Views\Topics\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
                EndContext();
                BeginContext(610, 44, true);
                WriteLiteral("</div>\r\n\r\n                    <div>Replies: ");
                EndContext();
                BeginContext(655, 18, false);
#line 25 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\lab6_v2-20190529T134624Z-001\lab6_v2\lab6_v2\Views\Topics\Index.cshtml"
                             Write(item.Posts.Count());

#line default
#line hidden
                EndContext();
                BeginContext(673, 26, true);
                WriteLiteral("</div>\r\n\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 20 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\lab6_v2-20190529T134624Z-001\lab6_v2\lab6_v2\Views\Topics\Index.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(703, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 29 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\lab6_v2-20190529T134624Z-001\lab6_v2\lab6_v2\Views\Topics\Index.cshtml"
        }

#line default
#line hidden
#line 29 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\lab6_v2-20190529T134624Z-001\lab6_v2\lab6_v2\Views\Topics\Index.cshtml"
         

    }

#line default
#line hidden
            BeginContext(745, 425, true);
            WriteLiteral(@"
</div>



<style>
    .main {
        border: 1px solid #ccc;
        border-radius: 5px;
        position: relative;
    }

    .main-item {
        border-bottom: 1px solid #ccc;
        width: 100%;
        text-decoration: none;
        color: black;
    }

        .main-item a:hover {
            text-decoration: none;
        }

    .main-item__title {
        color: blue;
    }
</style>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<lab6_v2.Models.Topic>> Html { get; private set; }
    }
}
#pragma warning restore 1591
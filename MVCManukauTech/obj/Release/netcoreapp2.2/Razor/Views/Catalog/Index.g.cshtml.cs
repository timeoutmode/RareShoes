#pragma checksum "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\Catalog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f78fedbe1b46cb0598dcc9e617fdd378ba584ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Index), @"mvc.1.0.view", @"/Views/Catalog/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalog/Index.cshtml", typeof(AspNetCore.Views_Catalog_Index))]
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
#line 1 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\_ViewImports.cshtml"
using MVCManukauTech;

#line default
#line hidden
#line 2 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\_ViewImports.cshtml"
using MVCManukauTech.Models;

#line default
#line hidden
#line 1 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\Catalog\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 2 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\Catalog\Index.cshtml"
using X.PagedList;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f78fedbe1b46cb0598dcc9e617fdd378ba584ac", @"/Views/Catalog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6d3974d37d441c37eea7a15ac3134927f63b44e", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/PagedList.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\Catalog\Index.cshtml"
  
   
        ViewBag.Title = "Catalog";

#line default
#line hidden
            BeginContext(99, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(106, 13, false);
#line 8 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\Catalog\Index.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(119, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
            BeginContext(128, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9f78fedbe1b46cb0598dcc9e617fdd378ba584ac5631", async() => {
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
            BeginContext(196, 317, true);
            WriteLiteral(@"

<table class=""table"">
    <tr>
        <th>
            Name
        </th>
        <th>
            Image
        </th>
        <th>
            Price
        </th>
        <th>
            Description
        </th>
        <th>
            Category
        </th>
        <th></th>
    </tr>

");
            EndContext();
#line 32 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\Catalog\Index.cshtml"
     foreach (var item in ViewBag.Model)
    {

#line default
#line hidden
            BeginContext(562, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(611, 9, false);
#line 36 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\Catalog\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(620, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(675, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9f78fedbe1b46cb0598dcc9e617fdd378ba584ac8053", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 685, "~/Images/Products/", 685, 18, true);
#line 39 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\Catalog\Index.cshtml"
AddHtmlAttributeValue("", 703, item.ImageFileName, 703, 19, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(746, 81, true);
            WriteLiteral("\r\n            </td>\r\n            <td style=\"text-align: right\">\r\n                ");
            EndContext();
            BeginContext(828, 13, false);
#line 42 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\Catalog\Index.cshtml"
           Write(item.UnitCost);

#line default
#line hidden
            EndContext();
            BeginContext(841, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(897, 16, false);
#line 45 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\Catalog\Index.cshtml"
           Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(913, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(969, 17, false);
#line 48 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\Catalog\Index.cshtml"
           Write(item.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(986, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1041, 133, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f78fedbe1b46cb0598dcc9e617fdd378ba584ac11112", async() => {
                BeginContext(1149, 21, true);
                WriteLiteral("Add&nbsp;to&nbsp;Cart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1050, "~/OrderDetails/ShoppingCart?ShoesId=", 1050, 36, true);
#line 51 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\Catalog\Index.cshtml"
AddHtmlAttributeValue("", 1086, item.ShoesId, 1086, 13, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1099, "&pageNumber=", 1099, 12, true);
#line 51 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\Catalog\Index.cshtml"
AddHtmlAttributeValue("", 1111, Context.Request.Query["pageNumber"], 1111, 36, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1174, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1229, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f78fedbe1b46cb0598dcc9e617fdd378ba584ac13273", async() => {
                BeginContext(1328, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1238, "~/Catalog/Details?ShoesId=", 1238, 26, true);
#line 54 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\Catalog\Index.cshtml"
AddHtmlAttributeValue("", 1264, item.ShoesId, 1264, 13, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1277, "&pageNumber=", 1277, 12, true);
#line 54 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\Catalog\Index.cshtml"
AddHtmlAttributeValue("", 1289, Context.Request.Query["pageNumber"], 1289, 36, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1339, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 57 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\Catalog\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1382, 23, true);
            WriteLiteral("    \r\n</table>\r\n<div>\r\n");
            EndContext();
            BeginContext(1625, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1630, 101, false);
#line 64 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\Catalog\Index.cshtml"
Write(Html.PagedListPager((IPagedList)ViewBag.Model, pageNumber => Url.Action("Index", new { pageNumber })));

#line default
#line hidden
            EndContext();
            BeginContext(1731, 14, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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

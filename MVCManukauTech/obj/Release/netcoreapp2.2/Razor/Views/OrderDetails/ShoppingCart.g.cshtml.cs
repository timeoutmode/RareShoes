#pragma checksum "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\OrderDetails\ShoppingCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "351583e7cc2aea0247c6cbbcdc343a5b1b2b6f72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderDetails_ShoppingCart), @"mvc.1.0.view", @"/Views/OrderDetails/ShoppingCart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OrderDetails/ShoppingCart.cshtml", typeof(AspNetCore.Views_OrderDetails_ShoppingCart))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"351583e7cc2aea0247c6cbbcdc343a5b1b2b6f72", @"/Views/OrderDetails/ShoppingCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6d3974d37d441c37eea7a15ac3134927f63b44e", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderDetails_ShoppingCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVCManukauTech.ViewModels.OrderDetailsQueryForCart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:10em"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Catalog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(72, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\OrderDetails\ShoppingCart.cshtml"
  
    ViewBag.Title = "Shopping Cart";
    //count lines as cart is built on server, then pass to javascript
    int initialLineCount = 0;

    //List<MVCManukauTech.ViewModels.OrderDetailsQueryForCart> cart = ViewBag.Cart;

#line default
#line hidden
            BeginContext(308, 176, true);
            WriteLiteral("<script src=\"https://www.paypal.com/sdk/js?client-id=AUzeYg9DsQj963kNdJVf2r1s4-yU0IG1SzqNtfjwexrCOq4_fmAHP-OzdZZi69vyLETPLZPo0v0_jQ9t&currency=NZD\">\r\n</script>\r\n\r\n<h2>Order no ");
            EndContext();
            BeginContext(485, 15, false);
#line 13 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\OrderDetails\ShoppingCart.cshtml"
        Write(ViewBag.OrderId);

#line default
#line hidden
            EndContext();
            BeginContext(500, 428, true);
            WriteLiteral(@"</h2>

<p>
  
</p>
<table class=""table"">
    <tr>
        <th>
            Line #
        </th>
        <th>
           Product Id
        </th>
        <th>
            Image
        </th>
        <th>
            Product Name
        </th>
        <th>
            Quantity
        </th>
        <th>
            Unit Cost
        </th>
        <th>
            Subtotal
        </th>
    </tr>

");
            EndContext();
#line 43 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\OrderDetails\ShoppingCart.cshtml"
 foreach (var item in Model) {
    string subTotal = Convert.ToDouble(Convert.ToDouble(item.Quantity) * Convert.ToDouble(item.UnitCost)).ToString("#0.00");
    //assuming here that quantities are always integers.  Needs change for products like tonnes of beer.  Half a tonne can be enough.
    string quantity = Convert.ToInt32(item.Quantity).ToString();
    //Note that for some industries you would have more than 2 decimal places - 4 is common - unitcost can be fractional
    string unitCost = Convert.ToDouble(item.UnitCost).ToString("#0.00");
    initialLineCount = item.LineNumber;

#line default
#line hidden
            BeginContext(1524, 36, true);
            WriteLiteral("    <tr>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1561, 15, false);
#line 52 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\OrderDetails\ShoppingCart.cshtml"
       Write(item.LineNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1576, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1620, 12, false);
#line 55 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\OrderDetails\ShoppingCart.cshtml"
       Write(item.ShoesId);

#line default
#line hidden
            EndContext();
            BeginContext(1632, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1675, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "351583e7cc2aea0247c6cbbcdc343a5b1b2b6f727761", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1685, "~/images/products/", 1685, 18, true);
#line 58 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\OrderDetails\ShoppingCart.cshtml"
AddHtmlAttributeValue("", 1703, item.ImageFileName, 1703, 19, false);

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
            BeginContext(1744, 42, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n           ");
            EndContext();
            BeginContext(1787, 14, false);
#line 61 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\OrderDetails\ShoppingCart.cshtml"
      Write(item.ShoesName);

#line default
#line hidden
            EndContext();
            BeginContext(1801, 31, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n");
            EndContext();
            BeginContext(2041, 49, true);
            WriteLiteral("            <input type=\"number\" min=\"0\" step=\"1\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2090, "\"", 2120, 2);
            WriteAttributeValue("", 2095, "quantity_", 2095, 9, true);
#line 66 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\OrderDetails\ShoppingCart.cshtml"
WriteAttributeValue("", 2104, item.LineNumber, 2104, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2121, 36, true);
            WriteLiteral(" style=\"text-align:right; width:5em\"");
            EndContext();
            BeginWriteAttribute("value", "\r\n             value=\"", 2157, "\"", 2188, 1);
#line 67 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\OrderDetails\ShoppingCart.cshtml"
WriteAttributeValue("", 2179, quantity, 2179, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2189, 24, true);
            WriteLiteral(" maxlength=\"6\"  required");
            EndContext();
            BeginWriteAttribute("onchange", " onchange=\"", 2213, "\"", 2273, 3);
            WriteAttributeValue("", 2224, "xAjaxChangeQuantity(this.value,", 2224, 31, true);
#line 67 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\OrderDetails\ShoppingCart.cshtml"
WriteAttributeValue(" ", 2255, item.LineNumber, 2256, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 2272, ")", 2272, 1, true);
            EndWriteAttribute();
            BeginContext(2274, 34, true);
            WriteLiteral(" />\r\n        </td>\r\n        <td>\r\n");
            EndContext();
            BeginContext(2532, 30, true);
            WriteLiteral("            <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2562, "\"", 2592, 2);
            WriteAttributeValue("", 2567, "unitcost_", 2567, 9, true);
#line 73 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\OrderDetails\ShoppingCart.cshtml"
WriteAttributeValue("", 2576, item.LineNumber, 2576, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2593, 36, true);
            WriteLiteral(" style=\"text-align:right; width:7em\"");
            EndContext();
            BeginWriteAttribute("value", "\r\n                   value=\"", 2629, "\"", 2666, 1);
#line 74 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\OrderDetails\ShoppingCart.cshtml"
WriteAttributeValue("", 2657, unitCost, 2657, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2667, 17, true);
            WriteLiteral("  data-unitcost=\"");
            EndContext();
            BeginContext(2685, 13, false);
#line 74 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\OrderDetails\ShoppingCart.cshtml"
                                                Write(item.UnitCost);

#line default
#line hidden
            EndContext();
            BeginContext(2698, 81, true);
            WriteLiteral("\"  maxlength=\"10\"  readonly /></td>\r\n        <td>\r\n            <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2779, "\"", 2809, 2);
            WriteAttributeValue("", 2784, "subTotal_", 2784, 9, true);
#line 76 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\OrderDetails\ShoppingCart.cshtml"
WriteAttributeValue("", 2793, item.LineNumber, 2793, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2810, 36, true);
            WriteLiteral(" style=\"text-align:right; width:7em\"");
            EndContext();
            BeginWriteAttribute("value", "\r\n                   value=\"", 2846, "\"", 2883, 1);
#line 77 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\OrderDetails\ShoppingCart.cshtml"
WriteAttributeValue("", 2874, subTotal, 2874, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2884, 56, true);
            WriteLiteral(" maxlength=\"10\"  readonly />\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 80 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\OrderDetails\ShoppingCart.cshtml"
}

#line default
#line hidden
            BeginContext(2943, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2992, 553, true);
            WriteLiteral(@"    <tr>
        <td>
            
        </td>
        <td>
            
        </td>
        <td>
            
        </td>
        <td>
            
        </td>
        <td>
           
        </td>
        <td style=""font-weight:bold; text-align:right"">
            Grand Total:
        </td>
        <td>
            <input type=""text"" id=""grandTotal"" style=""text-align:right; width:7em""  readonly />
        </td>

</table>
<div class=""container"">
    <div class=""row"">
        <div class=""col-sm-9"" >
            ");
            EndContext();
            BeginContext(3545, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "351583e7cc2aea0247c6cbbcdc343a5b1b2b6f7215438", async() => {
                BeginContext(3635, 17, true);
                WriteLiteral("Continue Shopping");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 110 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\OrderDetails\ShoppingCart.cshtml"
                                                                     WriteLiteral(ViewBag.PageNumber);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3656, 107, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-sm-3\" id=\"paypal-button-container\"></div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(3884, 38, true);
            WriteLiteral("<input id=\"hidLineCount\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3922, "\"", 3947, 1);
#line 118 "C:\Users\camac\OneDrive\Documents\Visual Studio\Full Stack\RareShoes\MVCManukauTech\Views\OrderDetails\ShoppingCart.cshtml"
WriteAttributeValue("", 3930, initialLineCount, 3930, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3948, 7, true);
            WriteLiteral(" />\r\n\r\n");
            EndContext();
            BeginContext(4202, 3033, true);
            WriteLiteral(@"<input id=""rootDirectory"" type=""hidden"" value=""/"" />

<script type=""text/javascript"">
    var lineCount = document.getElementById(""hidLineCount"").value;
    document.onload = DisplayGrandTotal();

    
    function DisplayGrandTotal() {
        //add up the subtotals to get a grand total
        var grandTotal = 0;
        for (i = 1; i <= lineCount; i++) {
            //educ - had i.toString at first, got errors, changed to i.toString() and it is sweet.
            var oeSubTotal = document.getElementById(""subTotal_"" + i.toString());
            grandTotal += oeSubTotal.value * 1;
        }
        oeGrandTotal = document.getElementById(""grandTotal"");
        oeGrandTotal.value = grandTotal;
    }

    function xAjaxChangeQuantity(qty, lineNumber) {
        //update the server to keep in sync with change here
        //code source for this is w3schools
        
        // use parseFloat rather than the more obvious parseInt because of possible future options
        var quantity = par");
            WriteLiteral(@"seFloat(qty);
        if(isNaN(quantity)) quantity = 0;
        //alert(""quantity="" + quantity + "" linenumber="" + lineNumber);
        var oeUnitCost = document.getElementById(""unitcost_"" + lineNumber.toString());
        var unitCost = parseFloat(oeUnitCost.value);
        var oeSubTotal = document.getElementById(""subTotal_"" + lineNumber.toString());
        oeSubTotal.value = (quantity * unitCost).toString();
        DisplayGrandTotal();
        //alert(""testing change of value at line "" + lineNumber);

        //AJAX!  ref  http://www.w3schools.com/ajax/ajax_xmlhttprequest_create.asp
        // Start by creating the xmlhttp object in Javascript to replace the older ""form"" methods
        var xmlhttp = new XMLHttpRequest();
       
        //Keep it simple and go sync rather than async
        //NOTE that xmlhttp is a LOT like the ""URLLoader"" class in Adobe Flash that we study in some other courses

        var requestString = document.getElementById(""rootDirectory"").value + ""OrderDetails/S");
            WriteLiteral(@"hoppingCartUpdate"";
        //JavaScript does not have the String.Format method of C# but we can get close 
        //and therefore keep to a similar style of code
        var postString = ""Quantity={0}&LineNumber={1}"";
        postString = postString.replace(""{0}"", quantity);
        postString = postString.replace(""{1}"", lineNumber);

        xmlhttp.open(""GET"", requestString + ""?"" + postString, false);
        xmlhttp.setRequestHeader(""Content-type"", ""application/x-www-form-urlencoded"");
        //xmlhttp.send(postString);
        xmlhttp.send();
        //alert(""PostString="" + postString);
        var response = xmlhttp.responseText;
        //140903 JPC TODO replace the ugly alert user interface with something better
        //  alert is very much for early prototyping
        if(response == ""ERROR"") {
            alert(""ERROR - please redo the previous data entry"");
        } else {
            //alert(response);
        }

    }

</script>
");
            EndContext();
            BeginContext(7281, 1157, true);
            WriteLiteral(@"<script>
    var total = document.getElementById('grandTotal').value;
    paypal.Buttons({
        style: {
            label: ""checkout""
        },
        createOrder: function (data, actions) {
            return actions.order.create({
                purchase_units: [{
                    amount: {
                        value: total
                    }
                }]
            });
        },
        onApprove: function (data, actions) {
            return actions.order.capture().then(function (details) {
                alert(""Successful. Thank you for shopping with us, "" + details.payer.name.given_name);
                // Call your server to save the transaction
                return fetch('/orderdetails/saveorder', {
                    method: 'post',
                    headers: {
                        'content-type': 'application/json'
                    },
                    body: JSON.stringify({
                        orderID: data.orderID
               ");
            WriteLiteral("     })\r\n                });\r\n            });\r\n        }\r\n    }).render(\'#paypal-button-container\');\r\n</script>\r\n\r\n                \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVCManukauTech.ViewModels.OrderDetailsQueryForCart>> Html { get; private set; }
    }
}
#pragma warning restore 1591

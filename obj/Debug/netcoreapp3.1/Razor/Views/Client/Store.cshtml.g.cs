#pragma checksum "C:\Users\dell\OneDrive\Máy tính\FptProject\FptProject\Views\Client\Store.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05d3ee483e633feb397e0c00abf71d6c5464bb24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Store), @"mvc.1.0.view", @"/Views/Client/Store.cshtml")]
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
#nullable restore
#line 1 "C:\Users\dell\OneDrive\Máy tính\FptProject\FptProject\Views\_ViewImports.cshtml"
using FPTBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dell\OneDrive\Máy tính\FptProject\FptProject\Views\_ViewImports.cshtml"
using FPTBook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05d3ee483e633feb397e0c00abf71d6c5464bb24", @"/Views/Client/Store.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b403cc31bb01cfeedfe65003c50473b64c687176", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Client_Store : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Client", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\dell\OneDrive\Máy tính\FptProject\FptProject\Views\Client\Store.cshtml"
  
    Layout = "_Layout1";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\" style=\"padding: 20px\">\r\n    <h2 class=\"text-info text-center\"><b>LIST PRODUCT</b></h2>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 7 "C:\Users\dell\OneDrive\Máy tính\FptProject\FptProject\Views\Client\Store.cshtml"
         foreach (var books in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card col-md-3 text-center\" style=\"width: 18rem;\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 312, "\"", 330, 1);
#nullable restore
#line 10 "C:\Users\dell\OneDrive\Máy tính\FptProject\FptProject\Views\Client\Store.cshtml"
WriteAttributeValue("", 318, books.Image, 318, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" width=\"300\" height=\"300\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 12 "C:\Users\dell\OneDrive\Máy tính\FptProject\FptProject\Views\Client\Store.cshtml"
                                      Write(books.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h5 class=\"card-title text-danger\"><strong>$ ");
#nullable restore
#line 13 "C:\Users\dell\OneDrive\Máy tính\FptProject\FptProject\Views\Client\Store.cshtml"
                                                            Write(books.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h5>\r\n                    <h6 class=\"card-title\">Quantity: ");
#nullable restore
#line 14 "C:\Users\dell\OneDrive\Máy tính\FptProject\FptProject\Views\Client\Store.cshtml"
                                                Write(books.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <input type=\"hidden\" name=\"laptop\"");
            BeginWriteAttribute("value", " value=\"", 705, "\"", 722, 1);
#nullable restore
#line 15 "C:\Users\dell\OneDrive\Máy tính\FptProject\FptProject\Views\Client\Store.cshtml"
WriteAttributeValue("", 713, books.Id, 713, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <br>\r\n                    <div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05d3ee483e633feb397e0c00abf71d6c5464bb246696", async() => {
                WriteLiteral("Order");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "C:\Users\dell\OneDrive\Máy tính\FptProject\FptProject\Views\Client\Store.cshtml"
                                                                                              WriteLiteral(books.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 22 "C:\Users\dell\OneDrive\Máy tính\FptProject\FptProject\Views\Client\Store.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\TNT\OneDrive\Máy tính\1670-dotnet core\FPTBook\Views\Client\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "480b365ca04a1e78422901fff7e06b4a4d0afba8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Detail), @"mvc.1.0.view", @"/Views/Client/Detail.cshtml")]
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
#line 1 "C:\Users\TNT\OneDrive\Máy tính\1670-dotnet core\FPTBook\Views\_ViewImports.cshtml"
using FPTBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TNT\OneDrive\Máy tính\1670-dotnet core\FPTBook\Views\_ViewImports.cshtml"
using FPTBook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"480b365ca04a1e78422901fff7e06b4a4d0afba8", @"/Views/Client/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b403cc31bb01cfeedfe65003c50473b64c687176", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Client_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FPTBook.Models.Book>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Client", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Store", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin:50px 40px 0px 0px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\TNT\OneDrive\Máy tính\1670-dotnet core\FPTBook\Views\Client\Detail.cshtml"
  
    Layout = "_Layout1";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row container\" style=\"padding-bottom: 300px; padding-top:20px\">\r\n    <div style=\"padding-top: 45px\" class=\"col-md-4 text-center\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 218, "\"", 236, 1);
#nullable restore
#line 8 "C:\Users\TNT\OneDrive\Máy tính\1670-dotnet core\FPTBook\Views\Client\Detail.cshtml"
WriteAttributeValue("", 224, Model.Image, 224, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"300\" height=\"300\" /><br />\r\n           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "480b365ca04a1e78422901fff7e06b4a4d0afba85261", async() => {
                WriteLiteral("Back to Store");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("  \r\n    </div>\r\n    \r\n\r\n    <div class=\"col-md-8\">\r\n        <h3 class=\"text-info text-center\">Infomation</h3>\r\n        <table class=\"table table-info table-bordered\">\r\n            <tr>\r\n                <th>Title</th>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\TNT\OneDrive\Máy tính\1670-dotnet core\FPTBook\Views\Client\Detail.cshtml"
               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Author</th>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\TNT\OneDrive\Máy tính\1670-dotnet core\FPTBook\Views\Client\Detail.cshtml"
               Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Category</th>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\TNT\OneDrive\Máy tính\1670-dotnet core\FPTBook\Views\Client\Detail.cshtml"
               Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Quantity</th>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\TNT\OneDrive\Máy tính\1670-dotnet core\FPTBook\Views\Client\Detail.cshtml"
               Write(Model.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Price</th>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\TNT\OneDrive\Máy tính\1670-dotnet core\FPTBook\Views\Client\Detail.cshtml"
               Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Description</th>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\TNT\OneDrive\Máy tính\1670-dotnet core\FPTBook\Views\Client\Detail.cshtml"
               Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n        <div class=\"text-center row\"style=\"margin-left:520px\">\r\n          \r\n            <div class=\"col-md-3 mr-4\" >\r\n                <input type=\"number\" name=\"quantity\" min=\"1\"");
            BeginWriteAttribute("max", " max=\"", 1447, "\"", 1468, 1);
#nullable restore
#line 44 "C:\Users\TNT\OneDrive\Máy tính\1670-dotnet core\FPTBook\Views\Client\Detail.cshtml"
WriteAttributeValue("", 1453, Model.Quantity, 1453, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" value=""1"" class=""form-control"" style=""width: 70px"">
            </div>
            <div class=""col-md-3"">
                <input class=""btn btn-success"" type=""submit"" value=""Order"" style=""width:100px"">
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FPTBook.Models.Book> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

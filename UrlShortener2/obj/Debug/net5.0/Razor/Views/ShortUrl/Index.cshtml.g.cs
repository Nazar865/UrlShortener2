#pragma checksum "C:\Users\nben\OneDrive\Рабочий стол\UrlShortener2\UrlShortener2\Views\ShortUrl\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88070173f26b7b59d7e5d4b8180fd7061b426bc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShortUrl_Index), @"mvc.1.0.view", @"/Views/ShortUrl/Index.cshtml")]
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
#line 1 "C:\Users\nben\OneDrive\Рабочий стол\UrlShortener2\UrlShortener2\Views\_ViewImports.cshtml"
using UrlShortener2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nben\OneDrive\Рабочий стол\UrlShortener2\UrlShortener2\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nben\OneDrive\Рабочий стол\UrlShortener2\UrlShortener2\Views\_ViewImports.cshtml"
using UrlShortener2.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\nben\OneDrive\Рабочий стол\UrlShortener2\UrlShortener2\Views\ShortUrl\Index.cshtml"
using UrlShortener2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nben\OneDrive\Рабочий стол\UrlShortener2\UrlShortener2\Views\ShortUrl\Index.cshtml"
using UrlShortener2.Data.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88070173f26b7b59d7e5d4b8180fd7061b426bc4", @"/Views/ShortUrl/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6ac65dbb2749f4a6a690b7d99b6619dfc24a01c", @"/Views/_ViewImports.cshtml")]
    public class Views_ShortUrl_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark btn btn-success mb-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShortUrl", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Short", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"text-center\">\r\n");
#nullable restore
#line 6 "C:\Users\nben\OneDrive\Рабочий стол\UrlShortener2\UrlShortener2\Views\ShortUrl\Index.cshtml"
     if (SignInManager.IsSignedIn(User))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88070173f26b7b59d7e5d4b8180fd7061b426bc45006", async() => {
                WriteLiteral("Add Url");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\nben\OneDrive\Рабочий стол\UrlShortener2\UrlShortener2\Views\ShortUrl\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th scope=\"col\">Original Url</th>\r\n");
#nullable restore
#line 15 "C:\Users\nben\OneDrive\Рабочий стол\UrlShortener2\UrlShortener2\Views\ShortUrl\Index.cshtml"
                 if (SignInManager.IsSignedIn(User))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th scope=\"col\">Short Url</th>\r\n                    <th scope=\"col\">Created At</th>\r\n                    <th scope=\"col\"></th>\r\n");
#nullable restore
#line 20 "C:\Users\nben\OneDrive\Рабочий стол\UrlShortener2\UrlShortener2\Views\ShortUrl\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 24 "C:\Users\nben\OneDrive\Рабочий стол\UrlShortener2\UrlShortener2\Views\ShortUrl\Index.cshtml"
             foreach (var item in ViewBag.Urls)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"to-short\">");
#nullable restore
#line 27 "C:\Users\nben\OneDrive\Рабочий стол\UrlShortener2\UrlShortener2\Views\ShortUrl\Index.cshtml"
                                Write(item.OriginalUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 28 "C:\Users\nben\OneDrive\Рабочий стол\UrlShortener2\UrlShortener2\Views\ShortUrl\Index.cshtml"
                 if (SignInManager.IsSignedIn(User))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><a");
            BeginWriteAttribute("href", " href=\"", 958, "\"", 982, 1);
#nullable restore
#line 30 "C:\Users\nben\OneDrive\Рабочий стол\UrlShortener2\UrlShortener2\Views\ShortUrl\Index.cshtml"
WriteAttributeValue("", 965, item.OriginalUrl, 965, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span>");
#nullable restore
#line 30 "C:\Users\nben\OneDrive\Рабочий стол\UrlShortener2\UrlShortener2\Views\ShortUrl\Index.cshtml"
                                                     Write(item.ShortUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a></td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\nben\OneDrive\Рабочий стол\UrlShortener2\UrlShortener2\Views\ShortUrl\Index.cshtml"
                   Write(item.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 32 "C:\Users\nben\OneDrive\Рабочий стол\UrlShortener2\UrlShortener2\Views\ShortUrl\Index.cshtml"
                     if (User.Identity.Name == @item.UserName)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                      <td>");
#nullable restore
#line 34 "C:\Users\nben\OneDrive\Рабочий стол\UrlShortener2\UrlShortener2\Views\ShortUrl\Index.cshtml"
                     Write(Html.ActionLink("Delete", "DeleteUrl", new { id = @item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 35 "C:\Users\nben\OneDrive\Рабочий стол\UrlShortener2\UrlShortener2\Views\ShortUrl\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\nben\OneDrive\Рабочий стол\UrlShortener2\UrlShortener2\Views\ShortUrl\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\nben\OneDrive\Рабочий стол\UrlShortener2\UrlShortener2\Views\ShortUrl\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> SignInManager { get; private set; }
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

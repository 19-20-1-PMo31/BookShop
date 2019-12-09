#pragma checksum "C:\Users\misha\University\C#\BookMagazine\BookShop\BookShop\Views\User\GetBucketInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bc0fc0a6b1e9f5ee4c0de112de05f36af6fbf9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_GetBucketInfo), @"mvc.1.0.view", @"/Views/User/GetBucketInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/GetBucketInfo.cshtml", typeof(AspNetCore.Views_User_GetBucketInfo))]
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
#line 1 "C:\Users\misha\University\C#\BookMagazine\BookShop\BookShop\Views\_ViewImports.cshtml"
using BookShop;

#line default
#line hidden
#line 2 "C:\Users\misha\University\C#\BookMagazine\BookShop\BookShop\Views\_ViewImports.cshtml"
using BookShop.Models;

#line default
#line hidden
#line 1 "C:\Users\misha\University\C#\BookMagazine\BookShop\BookShop\Views\User\GetBucketInfo.cshtml"
using BookShop.Application;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bc0fc0a6b1e9f5ee4c0de112de05f36af6fbf9a", @"/Views/User/GetBucketInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ee4735df80bb67d1ce7d40fc94d37240032cc50", @"/Views/_ViewImports.cshtml")]
    public class Views_User_GetBucketInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BucketDisplay>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/User/CreateOrder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\misha\University\C#\BookMagazine\BookShop\BookShop\Views\User\GetBucketInfo.cshtml"
  
    ViewData["Title"] = "GetBucketInfo";

#line default
#line hidden
            BeginContext(102, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\misha\University\C#\BookMagazine\BookShop\BookShop\Views\User\GetBucketInfo.cshtml"
 if (Model.Books.Count == 0)
{

#line default
#line hidden
            BeginContext(137, 35, true);
            WriteLiteral("    <h1>Your Bucket is Empty</h1>\r\n");
            EndContext();
#line 10 "C:\Users\misha\University\C#\BookMagazine\BookShop\BookShop\Views\User\GetBucketInfo.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(184, 64, true);
            WriteLiteral("    <h1>BucketInfo</h1>\r\n    <table class=\"table table-hover\">\r\n");
            EndContext();
#line 15 "C:\Users\misha\University\C#\BookMagazine\BookShop\BookShop\Views\User\GetBucketInfo.cshtml"
         foreach (var book in Model.Books)
        {

#line default
#line hidden
            BeginContext(303, 64, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <h3>");
            EndContext();
            BeginContext(368, 9, false);
#line 19 "C:\Users\misha\University\C#\BookMagazine\BookShop\BookShop\Views\User\GetBucketInfo.cshtml"
                   Write(book.Name);

#line default
#line hidden
            EndContext();
            BeginContext(377, 76, true);
            WriteLiteral("</h3>\r\n                </td>\r\n                <td>\r\n                    <h3>");
            EndContext();
            BeginContext(454, 11, false);
#line 22 "C:\Users\misha\University\C#\BookMagazine\BookShop\BookShop\Views\User\GetBucketInfo.cshtml"
                   Write(book.Author);

#line default
#line hidden
            EndContext();
            BeginContext(465, 119, true);
            WriteLiteral("</h3>\r\n                </td>\r\n                <td>\r\n                    <h3 class=\"book_price\" style=\"color:cadetblue\">");
            EndContext();
            BeginContext(585, 10, false);
#line 25 "C:\Users\misha\University\C#\BookMagazine\BookShop\BookShop\Views\User\GetBucketInfo.cshtml"
                                                              Write(book.Price);

#line default
#line hidden
            EndContext();
            BeginContext(595, 102, true);
            WriteLiteral("</h3>\r\n                </td>\r\n                <td>\r\n                    <button class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 697, "\"", 778, 3);
            WriteAttributeValue("", 707, "location.href=\'", 707, 15, true);
#line 28 "C:\Users\misha\University\C#\BookMagazine\BookShop\BookShop\Views\User\GetBucketInfo.cshtml"
WriteAttributeValue("", 722, Url.Action("CancelBook", "User", new { id = book.Id }), 722, 55, false);

#line default
#line hidden
            WriteAttributeValue("", 777, "\'", 777, 1, true);
            EndWriteAttribute();
            BeginContext(779, 60, true);
            WriteLiteral(">Cancel</button>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 31 "C:\Users\misha\University\C#\BookMagazine\BookShop\BookShop\Views\User\GetBucketInfo.cshtml"
        }

#line default
#line hidden
            BeginContext(850, 34, true);
            WriteLiteral("    </table>\r\n    <h1>Total price:");
            EndContext();
            BeginContext(885, 16, false);
#line 33 "C:\Users\misha\University\C#\BookMagazine\BookShop\BookShop\Views\User\GetBucketInfo.cshtml"
               Write(Model.TotalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(901, 11, true);
            WriteLiteral("</h1>\r\n    ");
            EndContext();
            BeginContext(912, 346, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bc0fc0a6b1e9f5ee4c0de112de05f36af6fbf9a8066", async() => {
                BeginContext(959, 292, true);
                WriteLiteral(@"
        <div class=""form-group"">
            <label for=""Address"">Post Address</label>
            <input type=""text"" class=""form-control"" name=""Address"" placeholder=""NovaPosta Adrress"" required>
        </div>
        <button type=""submit"" class=""btn btn-success"">Submit</button>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1258, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 41 "C:\Users\misha\University\C#\BookMagazine\BookShop\BookShop\Views\User\GetBucketInfo.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BucketDisplay> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\Huda\Desktop\src\WebPushService\WebPushService\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b7ffc4fe74ce4016b5717572410122279162758"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/List.cshtml", typeof(AspNetCore.Views_Home_List))]
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
#line 1 "C:\Users\Huda\Desktop\src\WebPushService\WebPushService\Views\_ViewImports.cshtml"
using WebPushService;

#line default
#line hidden
#line 2 "C:\Users\Huda\Desktop\src\WebPushService\WebPushService\Views\_ViewImports.cshtml"
using WebPushService.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b7ffc4fe74ce4016b5717572410122279162758", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be9cef417431fe57f037e819415f034bbe4c08d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebPushService.Models.Application>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateApplication", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Huda\Desktop\src\WebPushService\WebPushService\Views\Home\List.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
            BeginContext(102, 41, true);
            WriteLiteral("\r\n<h2>Project Dashboard</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(143, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f563cdf160c40bc8a411b2a4dfec002", async() => {
                BeginContext(177, 18, true);
                WriteLiteral("Create New Project");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(199, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(292, 38, false);
#line 16 "C:\Users\Huda\Desktop\src\WebPushService\WebPushService\Views\Home\List.cshtml"
           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(330, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(386, 40, false);
#line 19 "C:\Users\Huda\Desktop\src\WebPushService\WebPushService\Views\Home\List.cshtml"
           Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(426, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(482, 45, false);
#line 22 "C:\Users\Huda\Desktop\src\WebPushService\WebPushService\Views\Home\List.cshtml"
           Write(Html.DisplayNameFor(model => model.publicKey));

#line default
#line hidden
            EndContext();
            BeginContext(527, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(583, 45, false);
#line 25 "C:\Users\Huda\Desktop\src\WebPushService\WebPushService\Views\Home\List.cshtml"
           Write(Html.DisplayNameFor(model => model.createdAt));

#line default
#line hidden
            EndContext();
            BeginContext(628, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(684, 47, false);
#line 28 "C:\Users\Huda\Desktop\src\WebPushService\WebPushService\Views\Home\List.cshtml"
           Write(Html.DisplayNameFor(model => model.lastUpdated));

#line default
#line hidden
            EndContext();
            BeginContext(731, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "C:\Users\Huda\Desktop\src\WebPushService\WebPushService\Views\Home\List.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(849, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(898, 37, false);
#line 37 "C:\Users\Huda\Desktop\src\WebPushService\WebPushService\Views\Home\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
            EndContext();
            BeginContext(935, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(991, 39, false);
#line 40 "C:\Users\Huda\Desktop\src\WebPushService\WebPushService\Views\Home\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
            EndContext();
            BeginContext(1030, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1086, 44, false);
#line 43 "C:\Users\Huda\Desktop\src\WebPushService\WebPushService\Views\Home\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.publicKey));

#line default
#line hidden
            EndContext();
            BeginContext(1130, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1186, 44, false);
#line 46 "C:\Users\Huda\Desktop\src\WebPushService\WebPushService\Views\Home\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.createdAt));

#line default
#line hidden
            EndContext();
            BeginContext(1230, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1286, 46, false);
#line 49 "C:\Users\Huda\Desktop\src\WebPushService\WebPushService\Views\Home\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.lastUpdated));

#line default
#line hidden
            EndContext();
            BeginContext(1332, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1388, 56, false);
#line 52 "C:\Users\Huda\Desktop\src\WebPushService\WebPushService\Views\Home\List.cshtml"
           Write(Html.ActionLink("Send Push", "Send", new { id=item.id }));

#line default
#line hidden
            EndContext();
            BeginContext(1444, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 55 "C:\Users\Huda\Desktop\src\WebPushService\WebPushService\Views\Home\List.cshtml"
}

#line default
#line hidden
            BeginContext(1483, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebPushService.Models.Application>> Html { get; private set; }
    }
}
#pragma warning restore 1591

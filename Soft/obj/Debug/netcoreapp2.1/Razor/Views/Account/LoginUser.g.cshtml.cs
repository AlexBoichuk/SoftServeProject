#pragma checksum "D:\TestForGit2\Soft\Views\Account\LoginUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01c2d6f6626ca755ab98c27110449adc6ec5b179"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_LoginUser), @"mvc.1.0.view", @"/Views/Account/LoginUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/LoginUser.cshtml", typeof(AspNetCore.Views_Account_LoginUser))]
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
#line 1 "D:\TestForGit2\Soft\Views\_ViewImports.cshtml"
using Soft;

#line default
#line hidden
#line 2 "D:\TestForGit2\Soft\Views\_ViewImports.cshtml"
using Soft.Models;

#line default
#line hidden
#line 1 "D:\TestForGit2\Soft\Views\Account\LoginUser.cshtml"
using Soft.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01c2d6f6626ca755ab98c27110449adc6ec5b179", @"/Views/Account/LoginUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f466bb13d199bf44f8f7345b7bc332ed84ac6a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_LoginUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\TestForGit2\Soft\Views\Account\LoginUser.cshtml"
  
    ViewData["Title"] = "LoginUser";

#line default
#line hidden
            BeginContext(92, 34, true);
            WriteLiteral("\r\n<h2>Login User</h2>\r\n\r\n<table>\r\n");
            EndContext();
#line 10 "D:\TestForGit2\Soft\Views\Account\LoginUser.cshtml"
     using (Html.BeginForm("Login", "Account",FormMethod.Post))
                {

#line default
#line hidden
            BeginContext(210, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(265, 27, false);
#line 13 "D:\TestForGit2\Soft\Views\Account\LoginUser.cshtml"
                       Write(Html.LabelFor(x => x.Email));

#line default
#line hidden
            EndContext();
            BeginContext(292, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(328, 28, false);
#line 14 "D:\TestForGit2\Soft\Views\Account\LoginUser.cshtml"
                       Write(Html.EditorFor(x => x.Email));

#line default
#line hidden
            EndContext();
            BeginContext(356, 88, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(445, 30, false);
#line 17 "D:\TestForGit2\Soft\Views\Account\LoginUser.cshtml"
                       Write(Html.LabelFor(x => x.Password));

#line default
#line hidden
            EndContext();
            BeginContext(475, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(511, 31, false);
#line 18 "D:\TestForGit2\Soft\Views\Account\LoginUser.cshtml"
                       Write(Html.EditorFor(x => x.Password));

#line default
#line hidden
            EndContext();
            BeginContext(542, 88, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(631, 32, false);
#line 21 "D:\TestForGit2\Soft\Views\Account\LoginUser.cshtml"
                       Write(Html.LabelFor(x => x.RememberMe));

#line default
#line hidden
            EndContext();
            BeginContext(663, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(699, 33, false);
#line 22 "D:\TestForGit2\Soft\Views\Account\LoginUser.cshtml"
                       Write(Html.EditorFor(x => x.RememberMe));

#line default
#line hidden
            EndContext();
            BeginContext(732, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(768, 45, false);
#line 23 "D:\TestForGit2\Soft\Views\Account\LoginUser.cshtml"
                       Write(Html.HiddenFor(x => x.ReturnUrl, "ReturnUrl"));

#line default
#line hidden
            EndContext();
            BeginContext(813, 112, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr><td><input type=\"submit\" value=\"Log In\" /></td></tr>\r\n");
            EndContext();
#line 26 "D:\TestForGit2\Soft\Views\Account\LoginUser.cshtml"
                }

#line default
#line hidden
            BeginContext(944, 16, true);
            WriteLiteral("</table>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

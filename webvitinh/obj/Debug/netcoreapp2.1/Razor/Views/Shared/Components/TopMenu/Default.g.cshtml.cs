#pragma checksum "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Shared\Components\TopMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00409e1bb1316d8ffe9e61d539ac69a983f165a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TopMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TopMenu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/TopMenu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_TopMenu_Default))]
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
#line 1 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\_ViewImports.cshtml"
using webvitinh;

#line default
#line hidden
#line 2 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\_ViewImports.cshtml"
using webvitinh.Models;

#line default
#line hidden
#line 2 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Shared\Components\TopMenu\Default.cshtml"
using System.Security.Claims;

#line default
#line hidden
#line 3 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Shared\Components\TopMenu\Default.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00409e1bb1316d8ffe9e61d539ac69a983f165a9", @"/Views/Shared/Components/TopMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5427c4b52471c22b8c211fe7218ba363cfc6a1d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TopMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Model.Menus>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(92, 152, true);
            WriteLiteral("\r\n\r\n<div class=\"call\">\r\n    <p><span>Need help?</span> call us <span class=\"number\">1-22-3456789</span></span></p>\r\n</div>\r\n<div class=\"account_desc\">\r\n");
            EndContext();
#line 10 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Shared\Components\TopMenu\Default.cshtml"
      
        /*var session = (UserLogin)Session[webvitinh.Common.CommonConstant.USER_SESSION]*/
        var session_2 = User.Identity.Name;
        var session = ViewBag.Login;
    

#line default
#line hidden
            BeginContext(434, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 15 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Shared\Components\TopMenu\Default.cshtml"
     if (session == null && session_2 == null)
    {

#line default
#line hidden
            BeginContext(489, 14, true);
            WriteLiteral("        <ul>\r\n");
            EndContext();
#line 18 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Shared\Components\TopMenu\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(560, 22, true);
            WriteLiteral("                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 582, "\"", 599, 1);
#line 20 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 589, item.Link, 589, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("target", " target=\"", 600, "\"", 621, 1);
#line 20 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 609, item.Target, 609, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(622, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(624, 9, false);
#line 20 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Shared\Components\TopMenu\Default.cshtml"
                                                          Write(item.Text);

#line default
#line hidden
            EndContext();
            BeginContext(633, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 21 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Shared\Components\TopMenu\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(659, 15, true);
            WriteLiteral("        </ul>\r\n");
            EndContext();
#line 23 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Shared\Components\TopMenu\Default.cshtml"
    }
    else
    {
        if (session != null & session_2 == null)
        {

#line default
#line hidden
            BeginContext(759, 45, true);
            WriteLiteral("            <ul>\r\n                <li>Hello: ");
            EndContext();
            BeginContext(805, 7, false);
#line 29 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Shared\Components\TopMenu\Default.cshtml"
                      Write(session);

#line default
#line hidden
            EndContext();
            BeginContext(812, 27, true);
            WriteLiteral("</li>\r\n                <li>");
            EndContext();
            BeginContext(840, 41, false);
#line 30 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Shared\Components\TopMenu\Default.cshtml"
               Write(Html.ActionLink("Exit", "Logout", "User"));

#line default
#line hidden
            EndContext();
            BeginContext(881, 26, true);
            WriteLiteral("</li>\r\n            </ul>\r\n");
            EndContext();
#line 32 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Shared\Components\TopMenu\Default.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(943, 45, true);
            WriteLiteral("            <ul>\r\n                <li>Hello: ");
            EndContext();
            BeginContext(989, 9, false);
#line 36 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Shared\Components\TopMenu\Default.cshtml"
                      Write(session_2);

#line default
#line hidden
            EndContext();
            BeginContext(998, 27, true);
            WriteLiteral("</li>\r\n                <li>");
            EndContext();
            BeginContext(1026, 45, false);
#line 37 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Shared\Components\TopMenu\Default.cshtml"
               Write(Html.ActionLink("Exit", "LogoutFace", "User"));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 26, true);
            WriteLiteral("</li>\r\n            </ul>\r\n");
            EndContext();
#line 39 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Shared\Components\TopMenu\Default.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(1115, 33, true);
            WriteLiteral("</div>\r\n<div class=\"clear\"><span>");
            EndContext();
            BeginContext(1149, 37, false);
#line 42 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Shared\Components\TopMenu\Default.cshtml"
                    Write(Context.Session.GetString("username"));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 15, true);
            WriteLiteral("</span></div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Model.Menus>> Html { get; private set; }
    }
}
#pragma warning restore 1591
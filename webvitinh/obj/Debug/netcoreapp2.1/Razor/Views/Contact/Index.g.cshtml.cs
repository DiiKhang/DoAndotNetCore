#pragma checksum "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "007c22264b6f3847059eed638d7178fa000f937c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contact/Index.cshtml", typeof(AspNetCore.Views_Contact_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"007c22264b6f3847059eed638d7178fa000f937c", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5427c4b52471c22b8c211fe7218ba363cfc6a1d", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Model.Contact>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Client/js/Controller/ContactController.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Contact\Index.cshtml"
  
    ViewBag.Title = "Lien he";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(108, 165, true);
            WriteLiteral("<!--Key API google map-->\r\n<!--?key=AIzaSyAqctkwkgNdKkD4ZBZVd3PCf0F5sxGn6_o&callback=initMap-->\r\n<style>\r\n    #mapCanvas {\r\n        height: 600px;\r\n    }\r\n</style>\r\n");
            EndContext();
            DefineSection("jsFooter", async() => {
                BeginContext(291, 142, true);
                WriteLiteral("\r\n    <script src=\"https://maps.googleapis.com/maps/api/js?key=AIzaSyAqctkwkgNdKkD4ZBZVd3PCf0F5sxGn6_o\" type=\"text/javascript\"></script>\r\n    ");
                EndContext();
                BeginContext(433, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dc5356d1a6545e6a1161c78bce0fad6", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(500, 497, true);
                WriteLiteral(@"
    <script type=""text/javascript"">

        // This example displays a marker at the center of Australia.
        // When the user clicks the marker, an info window opens.
        //21.046300, 105.793266
        function initMap() {
            var uluru = { lat: 10.725062, lng: 106.630314 };
            var map = new google.maps.Map(document.getElementById('mapCanvas'), {
                zoom: 18,
                center: uluru
            });

            var contentString = '");
                EndContext();
                BeginContext(998, 23, false);
#line 28 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Contact\Index.cshtml"
                            Write(Html.Raw(Model.Content));

#line default
#line hidden
                EndContext();
                BeginContext(1021, 502, true);
                WriteLiteral(@"';

            var infowindow = new google.maps.InfoWindow({
                content: contentString
            });

            var marker = new google.maps.Marker({
                position: uluru,
                map: map,
                title: 'my hood'
            });
            marker.addListener('click', function () {
                infowindow.open(map, marker);
            });
        }
        google.maps.event.addDomListener(window, 'load', initMap);

    </script>
");
                EndContext();
            }
            );
            BeginContext(1526, 177, true);
            WriteLiteral("<div class=\"content\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <div class=\"col-md-6\">\r\n                <h2>Contact Information</h2>\r\n                ");
            EndContext();
            BeginContext(1704, 23, false);
#line 52 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Contact\Index.cshtml"
           Write(Html.Raw(Model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(1727, 87, true);
            WriteLiteral("\r\n\r\n                <h2>Send information</h2>\r\n                <br />\r\n                ");
            EndContext();
            BeginContext(1814, 1190, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb70a8dce3a84e73aa8f191baadbd8ec", async() => {
                BeginContext(1820, 1177, true);
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label>Name:</label>
                        <input type=""text"" id=""txtName"" class=""form-control"">
                    </div>
                    <div class=""form-group"">
                        <label>Phone's number:</label>
                        <input type=""text"" id=""txtMobile"" class=""form-control"">
                    </div>
                    <div class=""form-group"">
                        <label>Address:</label>
                        <input type=""text"" id=""txtAddress"" class=""form-control"">
                    </div>
                    <div class=""form-group"">
                        <label>Email:</label>
                        <input type=""text"" id=""txtEmail"" class=""form-control"">
                    </div>
                    <div class=""form-group"">
                        <label>Request:</label>
                        <textarea id=""txtContent"" class=""form-control"">
                            
        ");
                WriteLiteral("                </textarea>\r\n                    </div>\r\n                    <button id=\"btnSend\" class=\"btn btn-success\">Send</button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3004, 213, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <h2>Our location</h2>\r\n                <div class=\"map\" id=\"mapCanvas\"></div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Model.Contact> Html { get; private set; }
    }
}
#pragma warning restore 1591
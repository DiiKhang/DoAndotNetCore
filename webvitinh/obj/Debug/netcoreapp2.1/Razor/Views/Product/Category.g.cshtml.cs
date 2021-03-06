#pragma checksum "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "432927bb3f1d0a350d131208338ace8ab13ffc64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Category), @"mvc.1.0.view", @"/Views/Product/Category.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Category.cshtml", typeof(AspNetCore.Views_Product_Category))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"432927bb3f1d0a350d131208338ace8ab13ffc64", @"/Views/Product/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5427c4b52471c22b8c211fe7218ba363cfc6a1d", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Model.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 73, true);
            WriteLiteral("\r\n<!-- neu muon join su dung --><!--Model.ViewModel.ProductViewModel-->\r\n");
            EndContext();
#line 4 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
  
    var category = (Model.ProductCategory)ViewBag.Category;
    ViewBag.Title = category.Name;
    Layout = "~/Views/Shared/_Layout.cshtml"; ;


#line default
#line hidden
            BeginContext(256, 101, true);
            WriteLiteral("<div class=\"content\">\r\n    <div class=\"content_top\">\r\n        <div class=\"heading\">\r\n            <h3>");
            EndContext();
            BeginContext(358, 13, false);
#line 13 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
           Write(category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(371, 199, true);
            WriteLiteral("</h3>\r\n        </div>\r\n        <div class=\"see\">\r\n            <p><a href=\"#\">See all Products</a></p>\r\n        </div>\r\n        <div class=\"clear\"></div>\r\n    </div>\r\n    <div class=\"section group\">\r\n");
            EndContext();
#line 21 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
         foreach (var item in Model)
        {
            var link = "/chi-tiet/" + item.MetalTitle + "-" + item.Id;

#line default
#line hidden
            BeginContext(691, 71, true);
            WriteLiteral("            <div class=\"grid_1_of_4 images_1_of_4\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 762, "\"", 774, 1);
#line 25 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
WriteAttributeValue("", 769, link, 769, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(775, 5, true);
            WriteLiteral("><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 780, "\"", 814, 2);
            WriteAttributeValue("", 786, "/imgaes_vitinh_2/", 786, 17, true);
#line 25 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
WriteAttributeValue("", 803, item.Image, 803, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(815, 36, true);
            WriteLiteral(" alt=\"\" /></a>\r\n                <h2>");
            EndContext();
            BeginContext(852, 9, false);
#line 26 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(861, 29, true);
            WriteLiteral("</h2>\r\n                <span>");
            EndContext();
            BeginContext(891, 15, false);
#line 27 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
                 Write(item.CategoryId);

#line default
#line hidden
            EndContext();
            BeginContext(906, 150, true);
            WriteLiteral("</span>\r\n                <div class=\"price-details\">\r\n                    <div class=\"price-number\">\r\n                        <p><span class=\"rupees\">");
            EndContext();
            BeginContext(1058, 65, false);
#line 30 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
                                            Write(item.Price.HasValue ? item.Price.Value.ToString("N0") : "Liên hệ");

#line default
#line hidden
            EndContext();
            BeginContext(1124, 115, true);
            WriteLiteral("</span></p>\r\n                    </div>\r\n                    <div class=\"add-cart\">\r\n                        <h4><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1239, "\"", 1290, 3);
            WriteAttributeValue("", 1246, "/them-gio-hang?productID=", 1246, 25, true);
#line 33 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
WriteAttributeValue("", 1271, item.Id, 1271, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1279, "&quantity=1", 1279, 11, true);
            EndWriteAttribute();
            BeginContext(1291, 144, true);
            WriteLiteral(">Add to Cart</a></h4>\r\n                    </div>\r\n                    <div class=\"clear\"></div>\r\n                </div>\r\n\r\n            </div>\r\n");
            EndContext();
#line 39 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
        }

#line default
#line hidden
            BeginContext(1446, 62, true);
            WriteLiteral("        <div class=\"clear\"></div>\r\n        <!--Phân trang-->\r\n");
            EndContext();
#line 42 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
         if (ViewBag.TotalPage > 1)
        {
            var pageDisplay = (int)ViewBag.MaxPage;
            int totalPage = (int)ViewBag.TotalPage;
            int currentPage = ((int)ViewBag.Page);

            // Create numeric links
            var startPageIndex = Math.Max(1, currentPage - pageDisplay / 2);
            var endPageIndex = Math.Min(totalPage, currentPage + pageDisplay / 2);

            var link = "/san-pham/" + category.MetaTitle + "-" + category.Id;

#line default
#line hidden
            BeginContext(1996, 60, true);
            WriteLiteral("            <nav>\r\n                <ul class=\"pagination\">\r\n");
            EndContext();
#line 55 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
                     if (currentPage > ViewBag.First)
                    {

#line default
#line hidden
            BeginContext(2134, 30, true);
            WriteLiteral("                        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2164, "\"", 2196, 3);
#line 57 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
WriteAttributeValue("", 2171, link, 2171, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 2176, "?page=", 2176, 6, true);
#line 57 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
WriteAttributeValue("", 2182, ViewBag.First, 2182, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2197, 144, true);
            WriteLiteral(" title=\"Front page\" class=\"first\"><i class=\"fa fa-angle-double-left\"></i></a></li>\r\n                        <li>\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2341, "\"", 2372, 3);
#line 59 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
WriteAttributeValue("", 2348, link, 2348, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 2353, "?page=", 2353, 6, true);
#line 59 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
WriteAttributeValue("", 2359, ViewBag.Prev, 2359, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2373, 101, true);
            WriteLiteral(" title=\"Last page\" class=\"prev\"><i class=\"fa fa-angle-left\"></i></a>\r\n                        </li>\r\n");
            EndContext();
#line 61 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"

                    }

#line default
#line hidden
            BeginContext(2499, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 63 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
                     for (int i = startPageIndex; i <= endPageIndex; i++)
                    {
                        if (currentPage == i)
                        {


#line default
#line hidden
            BeginContext(2673, 35, true);
            WriteLiteral("                            <li> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2708, "\"", 2728, 3);
#line 68 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
WriteAttributeValue("", 2715, link, 2715, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 2720, "?page=", 2720, 6, true);
#line 68 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
WriteAttributeValue("", 2726, i, 2726, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2729, 15, true);
            WriteLiteral(" class=\"active\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2744, "\"", 2759, 2);
            WriteAttributeValue("", 2752, "Page", 2752, 4, true);
#line 68 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
WriteAttributeValue(" ", 2756, i, 2757, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2760, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2762, 1, false);
#line 68 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
                                                                                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2763, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 69 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2858, 34, true);
            WriteLiteral("                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2892, "\"", 2912, 3);
#line 72 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
WriteAttributeValue("", 2899, link, 2899, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 2904, "?page=", 2904, 6, true);
#line 72 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
WriteAttributeValue("", 2910, i, 2910, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2913, "\"", 2929, 2);
            WriteAttributeValue("", 2921, "Trang", 2921, 5, true);
#line 72 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
WriteAttributeValue(" ", 2926, i, 2927, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2930, 13, true);
            WriteLiteral(" class=\"pos\">");
            EndContext();
            BeginContext(2944, 1, false);
#line 72 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
                                                                                Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2945, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 73 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(3006, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 75 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
                     if (currentPage < totalPage)
                    {

#line default
#line hidden
            BeginContext(3080, 30, true);
            WriteLiteral("                        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3110, "\"", 3141, 3);
#line 77 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
WriteAttributeValue("", 3117, link, 3117, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 3122, "?page=", 3122, 6, true);
#line 77 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
WriteAttributeValue("", 3128, ViewBag.Next, 3128, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3142, 108, true);
            WriteLiteral(" class=\"next\" title=\"Front page\"><i class=\"fa fa-angle-right\"></i></a></li>\r\n                        <li> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3250, "\"", 3281, 3);
#line 78 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
WriteAttributeValue("", 3257, link, 3257, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 3262, "?page=", 3262, 6, true);
#line 78 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
WriteAttributeValue("", 3268, ViewBag.Last, 3268, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3282, 83, true);
            WriteLiteral(" class=\"last\" title=\"Last page\"><i class=\"fa fa-angle-double-right\"></i></a></li>\r\n");
            EndContext();
#line 79 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"
                    }

#line default
#line hidden
            BeginContext(3388, 45, true);
            WriteLiteral("\r\n                </ul>\r\n            </nav>\r\n");
            EndContext();
#line 83 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Views\Product\Category.cshtml"

        }
        else
        {
        }

#line default
#line hidden
            BeginContext(3482, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Model.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591

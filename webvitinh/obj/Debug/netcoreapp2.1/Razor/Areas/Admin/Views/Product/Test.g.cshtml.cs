#pragma checksum "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Areas\Admin\Views\Product\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1b71f49f45e71455092fb7fa2550b33957bb1ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Test), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Test.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Product/Test.cshtml", typeof(AspNetCore.Areas_Admin_Views_Product_Test))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1b71f49f45e71455092fb7fa2550b33957bb1ef", @"/Areas/Admin/Views/Product/Test.cshtml")]
    public class Areas_Admin_Views_Product_Test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Model.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/Admin/Scripts/jqGrid/grid.locale-en.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/Admin/Scripts/jqGrid/jquery.jqGrid.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Areas\Admin\Views\Product\Test.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(124, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("header", async() => {
                BeginContext(142, 31, true);
                WriteLiteral("\r\n    Test local data product\r\n");
                EndContext();
            }
            );
            BeginContext(176, 75, true);
            WriteLiteral("<Environment include=\"Development\">\r\n    <script>\r\n        var mydata = [\r\n");
            EndContext();
#line 13 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Areas\Admin\Views\Product\Test.cshtml"
         foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(304, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(322, 7, true);
            WriteLiteral("{ id: \'");
            EndContext();
            BeginContext(330, 7, false);
#line 15 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Areas\Admin\Views\Product\Test.cshtml"
                    Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(337, 10, true);
            WriteLiteral("\', name: \'");
            EndContext();
            BeginContext(348, 9, false);
#line 15 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Areas\Admin\Views\Product\Test.cshtml"
                                      Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(357, 9, true);
            WriteLiteral("\',price:\"");
            EndContext();
            BeginContext(367, 10, false);
#line 15 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Areas\Admin\Views\Product\Test.cshtml"
                                                         Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(377, 16, true);
            WriteLiteral("\",description: \'");
            EndContext();
            BeginContext(394, 10, false);
#line 15 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Areas\Admin\Views\Product\Test.cshtml"
                                                                                    Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(404, 22, true);
            WriteLiteral("\' + \"$\", categoryId: \'");
            EndContext();
            BeginContext(427, 15, false);
#line 15 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Areas\Admin\Views\Product\Test.cshtml"
                                                                                                                     Write(item.CategoryId);

#line default
#line hidden
            EndContext();
            BeginContext(442, 11, true);
            WriteLiteral("\', status:\"");
            EndContext();
            BeginContext(454, 11, false);
#line 15 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Areas\Admin\Views\Product\Test.cshtml"
                                                                                                                                                Write(item.Status);

#line default
#line hidden
            EndContext();
            BeginContext(465, 5, true);
            WriteLiteral("\"},\r\n");
            EndContext();
#line 16 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Areas\Admin\Views\Product\Test.cshtml"
            }

#line default
#line hidden
            BeginContext(485, 3581, true);
            WriteLiteral(@"        ];


        $(document).ready(function () {
            $(""#jqGrid"").jqGrid({
                //url: ""GetData"",
                // we set the changes to be made at client side using predefined word clientArray
                datatype: ""local"",
                data: mydata,
                shrinkToFit: false,
                colModel: [
                    { key: true, label: 'id', name: 'id' },
                    { label: 'name', name: 'name', editable: true },
                    { label: 'description', name: 'description', editable: true },
                    { label: 'price', name: 'price', editable: true },
                    { label: 'categoryId', name: 'categoryId', editable: true },
                    { label: 'status', name: 'status', editable: true },
                ],
                loadonce: true,
                viewrecords: true,
                width: 1000,
                height: 600,
                rowNum: 30,
                rowList: [10, 15, 20, 30, 50");
            WriteLiteral(@"],
                pager: ""#jqGridPager""
            });
            $('#jqGrid').navGrid('#jqGridPager',
                // the buttons to appear on the toolbar of the grid
                { edit: true, add: true, del: true, search: true, refresh: false, view: false, position: ""left"", cloneToTop: false },
                // options for the Edit Dialog
                {
                    editCaption: ""The Edit Dialog"",
                    url: 'EditProductJson',
                    afterSubmit: function () {
                        $(this).jqGrid(""setGridParam"", { datatype: 'local' });
                        return [true];
                    },
                    beforeSubmit: function (postdata, form, oper) {
                        if (confirm('Are you sure you want to update this row?')) {
                            return [true, ''];
                        } else {
                            return [false, 'You can not submit!'];
                        }
                    },");
            WriteLiteral(@"
                    closeAfterEdit: true,
                    errorTextFormat: function (data) {
                        return 'Error: ' + data.responseText
                    }
                },
                // options for the Add Dialog
                {
                    url: ""AddProductJson"",
                    afterSubmit: function () {
                        $(this).jqGrid(""setGridParam"", {
                            datatype: 'local'
                        });
                        return [true];
                    },
                    closeAfterAdd: true,
                },
                // options for the Delete Dailog
                {
                    url: ""DeleteProductJson"",
                    beforeSubmit: function (postdata, form, oper) {
                        if (confirm('Are you wanna delete?')) {

                            return [true, ''];
                        } else {
                            return [false, 'You can not delete!'];");
            WriteLiteral(@"
                        }
                    },
                    afterSubmit: function () {
                        $(this).jqGrid(""setGridParam"", {
                            datatype: 'local'
                        });
                        return [true];
                    },
                    errorTextFormat: function (data) {
                        return 'Error: ' + data.responseText
                    }
                });
        });
    </script>
</Environment>


");
            EndContext();
            DefineSection("jsFooter", async() => {
                BeginContext(4084, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4090, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "611198d6db6a4f19bfc5602b2d4f8a8a", async() => {
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
                BeginContext(4160, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4166, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "377eefbb3263478cacf669be0f4cf79d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4235, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(4240, 135, true);
            WriteLiteral("\r\n<table id=\"jqGrid\" align=\"center\"></table>\r\n<div id=\"jqGridPager\"></div>\r\n<!--<input id=\"btn\" type=\"button\" value=\"Load data\" />-->\r\n");
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

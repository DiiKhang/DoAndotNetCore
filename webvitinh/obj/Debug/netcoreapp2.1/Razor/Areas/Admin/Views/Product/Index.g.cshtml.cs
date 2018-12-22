#pragma checksum "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Areas\Admin\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a1b2933386fdabc1328b6a21e105f6f8837afa4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Product/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Product_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a1b2933386fdabc1328b6a21e105f6f8837afa4", @"/Areas/Admin/Views/Product/Index.cshtml")]
    public class Areas_Admin_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Model.Product>>
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
#line 2 "D:\.NET ILETS HAO\DoAndotNetCore\webvitinh\Areas\Admin\Views\Product\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(124, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("header", async() => {
                BeginContext(142, 27, true);
                WriteLiteral("\r\n    Product\'s mangament\r\n");
                EndContext();
            }
            );
            BeginContext(172, 3968, true);
            WriteLiteral(@"<Environment include=""Development"">
    <script>
        $(document).ready(function () {
            $(""#jqGrid"").jqGrid({
                url: ""GetData"",
                // we set the changes to be made at client side using predefined word clientArray
                datatype: ""json"",
                autowidth: false,
                shrinkToFit: true,
                colModel: [
                    { label: 'categoryId', name: 'categoryId', editable: true },
                    { label: 'name', name: 'name', editable: true },
                    { label: 'description', name: 'description', editable: true },
                    { label: 'price', name: 'price', editable: true },
                    { key: true, label: 'id', name: 'id' },
                    { label: 'status', name: 'status', editable: true },
                ],
                loadonce: true,
                viewrecords: true,
                width: 1000,
                height: 600,
                grouping: true,
     ");
            WriteLiteral(@"           groupingView: {
                    groupField: ['categoryId'],
                    groupColumnShow: [true],
                    groupText: ['<b>{0} - {1} Items(s)</b>'], //{0} la id - {1} la count
                    groupCollapse: false,
                    groupOrder: ['asc']
                },
                rowNum: 20,
                rowList: [10, 15, 20, 30, 50],
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
                        $(this).jqGrid(""setGridParam"", { datatype: 'json' });
                        retu");
            WriteLiteral(@"rn [true];
                    },
                    beforeSubmit: function (postdata, form, oper) {
                        if (confirm('Are you sure you want to update this row?')) {
                            return [true, ''];
                        } else {
                            return [false, 'You can not submit!'];
                        }
                    },
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
                            datatype: 'json'
                        });
                        return [true];
                    },
                    closeAfterAdd: true,
                },
            ");
            WriteLiteral(@"    // options for the Delete Dailog
                {
                    url: ""DeleteProductJson"",
                    beforeSubmit: function (postdata, form, oper) {
                        if (confirm('Are you wanna delete?')) {

                            return [true, ''];
                        } else {
                            return [false, 'You can not delete!'];
                        }
                    },
                    afterSubmit: function () {
                        $(this).jqGrid(""setGridParam"", {
                            datatype: 'json'
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
                BeginContext(4158, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4164, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d94a64c8abc54509ab34c6f6f5d0a8aa", async() => {
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
                BeginContext(4234, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4240, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e51790464de4581b517db4db9058cc0", async() => {
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
                BeginContext(4309, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(4314, 135, true);
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
#pragma checksum "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\QTV0\ViTriDo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bfe5fc8f3c5767f42e760aef696b6a0e77e8db5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QTV0_ViTriDo), @"mvc.1.0.view", @"/Views/QTV0/ViTriDo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/QTV0/ViTriDo.cshtml", typeof(AspNetCore.Views_QTV0_ViTriDo))]
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
#line 1 "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\_ViewImports.cshtml"
using QuanLyBenXeWebApp;

#line default
#line hidden
#line 2 "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\_ViewImports.cshtml"
using QuanLyBenXeWebApp.Models;

#line default
#line hidden
#line 3 "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bfe5fc8f3c5767f42e760aef696b6a0e77e8db5", @"/Views/QTV0/ViTriDo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a743be3cae5d0a00d61f43ba3e212f472d72e39", @"/Views/_ViewImports.cshtml")]
    public class Views_QTV0_ViTriDo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViTriDo[]>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\QTV0\ViTriDo.cshtml"
  
	Layout = "~/Views/Qtv0/_Qtv0Layout.cshtml";
	ViewData["Title"] = "CRUD vị trí đỗ trong bến";


#line default
#line hidden
            BeginContext(123, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(130, 17, false);
#line 8 "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\QTV0\ViTriDo.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(147, 33, true);
            WriteLiteral("</h1>\r\n<div class=\"container\">\r\n\t");
            EndContext();
            BeginContext(180, 968, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bfe5fc8f3c5767f42e760aef696b6a0e77e8db54619", async() => {
                BeginContext(200, 188, true);
                WriteLiteral("\r\n\t\t<div class=\"input-group\">\r\n\t\t\t<table id=\"vtd-data-grid\" class=\"table-bordered\">\r\n\t\t\t\t<thead>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<th scope=\"col\">Mã vị trí</th>\r\n\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t</thead>\r\n\t\t\t\t<tbody>\r\n");
                EndContext();
#line 20 "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\QTV0\ViTriDo.cshtml"
                     foreach (ViTriDo viTri in Model)
					{

#line default
#line hidden
                BeginContext(436, 50, true);
                WriteLiteral("\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t<td><input readonly type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 486, "\"", 508, 1);
#line 23 "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\QTV0\ViTriDo.cshtml"
WriteAttributeValue("", 494, viTri.MaViTri, 494, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(509, 25, true);
                WriteLiteral(" /></td>\r\n\r\n\t\t\t\t\t\t</tr>\r\n");
                EndContext();
#line 26 "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\QTV0\ViTriDo.cshtml"
					}

#line default
#line hidden
                BeginContext(542, 381, true);
                WriteLiteral(@"					<tr>
						<td><input readonly type=""text"" value="""" list=""ma-vi-tri"" /></td>

					</tr>
				</tbody>
			</table>
			<div class=""input-group"">
				<button type=""button"" id=""create-vtd"">Tạo mới</button>
				<button type=""button"" id=""update-vtd"">Cập nhật mới</button>
				<button type=""button"" id=""delete-vtd"">Xoá</button>
			</div>
			<datalist id=""ma-vi-tri"">
				");
                EndContext();
                BeginContext(923, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bfe5fc8f3c5767f42e760aef696b6a0e77e8db56759", async() => {
                    BeginContext(933, 39, false);
#line 39 "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\QTV0\ViTriDo.cshtml"
                    Write("MB" + ViewBag.NextViTriId.Substring(2));

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(982, 6, true);
                WriteLiteral("\r\n\t\t\t\t");
                EndContext();
                BeginContext(988, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bfe5fc8f3c5767f42e760aef696b6a0e77e8db58184", async() => {
                    BeginContext(998, 39, false);
#line 40 "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\QTV0\ViTriDo.cshtml"
                    Write("MT" + ViewBag.NextViTriId.Substring(2));

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1047, 6, true);
                WriteLiteral("\r\n\t\t\t\t");
                EndContext();
                BeginContext(1053, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bfe5fc8f3c5767f42e760aef696b6a0e77e8db59611", async() => {
                    BeginContext(1063, 39, false);
#line 41 "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\QTV0\ViTriDo.cshtml"
                    Write("MN" + ViewBag.NextViTriId.Substring(2));

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1112, 29, true);
                WriteLiteral("\r\n\t\t\t</datalist>\r\n\t\t</div>\r\n\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1148, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViTriDo[]> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\code\WebAppQuanLyBenXe\QuanLyBenXeWebApp\Views\Home\TaiXe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2134007a50f84dae0d494d8b024add410a993f45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TaiXe), @"mvc.1.0.view", @"/Views/Home/TaiXe.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/TaiXe.cshtml", typeof(AspNetCore.Views_Home_TaiXe))]
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
#line 1 "D:\code\WebAppQuanLyBenXe\QuanLyBenXeWebApp\Views\_ViewImports.cshtml"
using QuanLyBenXeWebApp;

#line default
#line hidden
#line 2 "D:\code\WebAppQuanLyBenXe\QuanLyBenXeWebApp\Views\_ViewImports.cshtml"
using QuanLyBenXeWebApp.Models;

#line default
#line hidden
#line 3 "D:\code\WebAppQuanLyBenXe\QuanLyBenXeWebApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2134007a50f84dae0d494d8b024add410a993f45", @"/Views/Home/TaiXe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a743be3cae5d0a00d61f43ba3e212f472d72e39", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TaiXe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaiXe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\code\WebAppQuanLyBenXe\QuanLyBenXeWebApp\Views\Home\TaiXe.cshtml"
  
    ViewData["Title"] = "Tài xế "+Model.ToString();

#line default
#line hidden
            BeginContext(74, 239, true);
            WriteLiteral("\r\n<section>\r\n    <div class=\"view-container p-3\">\r\n        <div class=\"container\">\r\n            <div class=\"row border-nx\">\r\n                <div class=\"col-12 col-sm-12 col-md-12 col-lg-12 col-xl-12 text-center\">\r\n                    <h4>");
            EndContext();
            BeginContext(314, 13, false);
#line 11 "D:\code\WebAppQuanLyBenXe\QuanLyBenXeWebApp\Views\Home\TaiXe.cshtml"
                   Write(Model.MaTaiXe);

#line default
#line hidden
            EndContext();
            BeginContext(327, 144, true);
            WriteLiteral("</h4>\r\n                </div>\r\n                <div class=\"col-6 col-sm-6 col-md-6 col-lg-6 col-xl-6\"><span style=\"font-size: 15px;\">Họ và tên: ");
            EndContext();
            BeginContext(472, 16, false);
#line 13 "D:\code\WebAppQuanLyBenXe\QuanLyBenXeWebApp\Views\Home\TaiXe.cshtml"
                                                                                                            Write(Model.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(488, 129, true);
            WriteLiteral(" </span></div>\r\n                <div class=\"col-6 col-sm-6 col-md-6 col-lg-6 col-xl-6\"><span style=\"font-size: 15px;\">Giới tính: ");
            EndContext();
            BeginContext(619, 25, false);
#line 14 "D:\code\WebAppQuanLyBenXe\QuanLyBenXeWebApp\Views\Home\TaiXe.cshtml"
                                                                                                             Write(Model.GioiTinh?"Nam":"Nữ");

#line default
#line hidden
            EndContext();
            BeginContext(645, 128, true);
            WriteLiteral(" </span></div>\r\n                <div class=\"col-6 col-sm-6 col-md-6 col-lg-6 col-xl-6\"><span style=\"font-size: 15px;\">Nơi Sinh: ");
            EndContext();
            BeginContext(774, 13, false);
#line 15 "D:\code\WebAppQuanLyBenXe\QuanLyBenXeWebApp\Views\Home\TaiXe.cshtml"
                                                                                                           Write(Model.NoiSinh);

#line default
#line hidden
            EndContext();
            BeginContext(787, 133, true);
            WriteLiteral(" </span></div>\r\n                <div class=\"col-6 col-sm-6 col-md-6 col-lg-6 col-xl-6\"><span style=\"font-size: 15px;\">Số điện thoại: ");
            EndContext();
            BeginContext(921, 9, false);
#line 16 "D:\code\WebAppQuanLyBenXe\QuanLyBenXeWebApp\Views\Home\TaiXe.cshtml"
                                                                                                                Write(Model.Sdt);

#line default
#line hidden
            EndContext();
            BeginContext(930, 76, true);
            WriteLiteral(" </span></div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaiXe> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\Home\TaiXe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "115f126c7f8c1584080d17ade312cdf59cfc843b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"115f126c7f8c1584080d17ade312cdf59cfc843b", @"/Views/Home/TaiXe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a743be3cae5d0a00d61f43ba3e212f472d72e39", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TaiXe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaiXe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\Home\TaiXe.cshtml"
  
    ViewData["Title"] = "Tài xế "+Model.ToString();

#line default
#line hidden
            BeginContext(74, 138, true);
            WriteLiteral("\r\n<section>\r\n\t<div class=\"view-container\">\r\n\t\t<div class=\"row\">\r\n\t\t\t<div class=\"col-12 col-sm-12 col-md-12 col-lg-12 col-xl-12\">\r\n\t\t\t\t<h4>");
            EndContext();
            BeginContext(213, 13, false);
#line 10 "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\Home\TaiXe.cshtml"
               Write(Model.MaTaiXe);

#line default
#line hidden
            EndContext();
            BeginContext(226, 118, true);
            WriteLiteral("</h4>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col-6 col-sm-6 col-md-6 col-lg-6 col-xl-6\"><span style=\"font-size: 13px;\">Họ và tên: ");
            EndContext();
            BeginContext(345, 16, false);
#line 12 "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\Home\TaiXe.cshtml"
                                                                                                        Write(Model.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(361, 116, true);
            WriteLiteral(" </span></div>\r\n\t\t\t<div class=\"col-6 col-sm-6 col-md-6 col-lg-6 col-xl-6\"><span style=\"font-size: 13px;\">Giới tính: ");
            EndContext();
            BeginContext(479, 25, false);
#line 13 "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\Home\TaiXe.cshtml"
                                                                                                         Write(Model.GioiTinh?"Nam":"Nữ");

#line default
#line hidden
            EndContext();
            BeginContext(505, 115, true);
            WriteLiteral(" </span></div>\r\n\t\t\t<div class=\"col-6 col-sm-6 col-md-6 col-lg-6 col-xl-6\"><span style=\"font-size: 13px;\">Nơi Sinh: ");
            EndContext();
            BeginContext(621, 13, false);
#line 14 "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\Home\TaiXe.cshtml"
                                                                                                       Write(Model.NoiSinh);

#line default
#line hidden
            EndContext();
            BeginContext(634, 120, true);
            WriteLiteral(" </span></div>\r\n\t\t\t<div class=\"col-6 col-sm-6 col-md-6 col-lg-6 col-xl-6\"><span style=\"font-size: 13px;\">Số điện thoại: ");
            EndContext();
            BeginContext(755, 9, false);
#line 15 "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\Home\TaiXe.cshtml"
                                                                                                            Write(Model.Sdt);

#line default
#line hidden
            EndContext();
            BeginContext(764, 47, true);
            WriteLiteral(" </span></div>\r\n\t\t</div>\r\n\t</div>\r\n</section>\r\n");
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

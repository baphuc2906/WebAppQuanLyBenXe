#pragma checksum "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a8f66c177a800557321c2ccd37e32f31efb3b6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a8f66c177a800557321c2ccd37e32f31efb3b6c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a743be3cae5d0a00d61f43ba3e212f472d72e39", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\Home\Index.cshtml"
  
	ViewData["Title"] = "Trang chủ";

#line default
#line hidden
            BeginContext(130, 588, true);
            WriteLiteral(@"
<div class=""wrap"">
	<div class=""wrap-admin"">
		<div class=""search-block"">
			<div class=""container"">
				<div class=""row"">
					<h2 class=""search-title col-12 col-sm-12 col-md-12 col-lg-12 col-xl-12"">
						Chào mừng đến với bến xe trung tâm TP.Đà Nẵng
					</h2>
						<div class=""col-12 col-sm-12 col-md-12 col-lg-4 col-xl-4"">
							<div class=""input-group"">
								<label for="""" class=""label"">Từ</label>
								<input id=""input-start""  class=""form-control mx-auto my-auto"" placeholder=""điểm bắt đầu"" list=""start-points"" required>
								<datalist id=""start-points"">
");
            EndContext();
#line 19 "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\Home\Index.cshtml"
                                     foreach(DiemDung diemDung in Model.DiemDungList)
									{

#line default
#line hidden
            BeginContext(790, 10, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(800, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a8f66c177a800557321c2ccd37e32f31efb3b6c4561", async() => {
                BeginContext(810, 18, false);
#line 21 "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\Home\Index.cshtml"
                                            Write(diemDung.TenTinhTp);

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
            BeginContext(838, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 22 "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\Home\Index.cshtml"
									}

#line default
#line hidden
            BeginContext(852, 374, true);
            WriteLiteral(@"								</datalist>foreach
							</div>
						</div>
						<div class="" col-12 col-sm-12 col-md-12 col-lg-4 col-xl-4"">
							<div class=""input-group"">
								<label for="""" class=""label"">Đến</label>
								<input id=""input-stop"" class=""form-control mx-auto my-auto"" name="""" placeholder=""Điểm dừng"" list=""stop-points"" required>
								<datalist id=""stop-points"">
");
            EndContext();
#line 31 "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\Home\Index.cshtml"
                                     foreach (DiemDung diemDung in Model.DiemDungList)
									{

#line default
#line hidden
            BeginContext(1299, 10, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1309, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a8f66c177a800557321c2ccd37e32f31efb3b6c6907", async() => {
                BeginContext(1319, 18, false);
#line 33 "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\Home\Index.cshtml"
                                            Write(diemDung.TenTinhTp);

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
            BeginContext(1347, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 34 "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\Home\Index.cshtml"
									}

#line default
#line hidden
            BeginContext(1361, 676, true);
            WriteLiteral(@"								</datalist>
							</div>
						</div>
						<div class="" col-12 col-sm-12 col-md-12 col-lg-4 col-xl-4"">
							<div class=""input-group"">
								<span class=""label"">Ngày</span>
								<input id=""input-date"" class=""form-control mx-auto my-auto"" type=""date"" required>
							</div>
						</div>
						<div class=""nangcao col-12 col-sm-12 col-md-12 col-lg-12 col-xl-12"" id=""toogle"">
							<div class=""row"">
								<div class=""col-12 col-sm-12 col-md-12 col-lg-6 col-xl-6"">
									<div class=""input-group"">
										<label for="""" class=""label"">Nhà Xe</label>
										<select id=""input-bus"" class=""form-control mx-auto my-auto"" name="""" >
											");
            EndContext();
            BeginContext(2037, 17, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a8f66c177a800557321c2ccd37e32f31efb3b6c9212", async() => {
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
            BeginContext(2054, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 51 "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\Home\Index.cshtml"
                                             foreach(NhaXe nhaXe in Model.NhaXeList)
											{

#line default
#line hidden
            BeginContext(2123, 12, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(2135, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a8f66c177a800557321c2ccd37e32f31efb3b6c10631", async() => {
                BeginContext(2145, 14, false);
#line 53 "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\Home\Index.cshtml"
                                                    Write(nhaXe.TenNhaXe);

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
            BeginContext(2169, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 54 "C:\Users\FPTSHOP 671\source\repos\QuanLyBenXeWebApp\QuanLyBenXeWebApp\Views\Home\Index.cshtml"
											}

#line default
#line hidden
            BeginContext(2185, 697, true);
            WriteLiteral(@"										</select>foreach
									</div>
								</div>
								<div class=""col-12 col-sm-12 col-md-12 col-lg-6 col-xl-6"">
									<div class=""input-group"">
										<label for=""quantity"" class=""label"">Khoang t/g:</label>
										<input id=""input-interval"" type=""number"" class=""form-control mx-auto my-auto"" name=""quantity"" min=""1"" max=""48"" step=""0.5"">
									</div>
								</div>
								<div class=""col-12 col-sm-12 col-md-12 col-lg-6 col-xl-6"">
									<div class=""input-group"">
										<label for="""" class=""label"">Loại Xe</label>
										<input id=""input-type"" class=""form-control mx-auto my-auto"" list=""seat-types"">
										<datalist id=""seat-types"">
											");
            EndContext();
            BeginContext(2882, 23, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a8f66c177a800557321c2ccd37e32f31efb3b6c12970", async() => {
                BeginContext(2890, 6, true);
                WriteLiteral("12 Ghế");
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
            BeginContext(2905, 13, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(2918, 23, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a8f66c177a800557321c2ccd37e32f31efb3b6c14169", async() => {
                BeginContext(2926, 6, true);
                WriteLiteral("16 Ghế");
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
            BeginContext(2941, 13, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(2954, 23, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a8f66c177a800557321c2ccd37e32f31efb3b6c15368", async() => {
                BeginContext(2962, 6, true);
                WriteLiteral("24 Ghế");
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
            BeginContext(2977, 13, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(2990, 23, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a8f66c177a800557321c2ccd37e32f31efb3b6c16567", async() => {
                BeginContext(2998, 6, true);
                WriteLiteral("29 Ghế");
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
            BeginContext(3013, 13, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(3026, 23, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a8f66c177a800557321c2ccd37e32f31efb3b6c17766", async() => {
                BeginContext(3034, 6, true);
                WriteLiteral("35 Ghế");
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
            BeginContext(3049, 13, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(3062, 23, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a8f66c177a800557321c2ccd37e32f31efb3b6c18965", async() => {
                BeginContext(3070, 6, true);
                WriteLiteral("45 Ghế");
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
            BeginContext(3085, 13, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(3098, 23, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a8f66c177a800557321c2ccd37e32f31efb3b6c20164", async() => {
                BeginContext(3106, 6, true);
                WriteLiteral("50 Ghế");
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
            BeginContext(3121, 6924, true);
            WriteLiteral(@"
										</datalist>
									</div>
								</div>
								<div class=""col-12 col-sm-12 col-md-12 col-lg-6 col-xl-6"">
									<div class=""input-group"">
										<label for=""quantity"" class=""label"">Giá Vé:</label>
										<input id=""input-cost"" type=""number"" class=""form-control mx-auto my-auto"" name=""quantity"" min=""50000"" max=""500000"" step=""50000"">
									</div>
								</div>
							</div>
						</div>
						<div class=""col-12 col-sm-12 col-md-12 col-lg-12 col-xl-12 mx-auto mb-3"">
							<button id=""toogle-button"" type=""button"" class=""btn  d-block"" style=""background-color: #ffc312;width: 50%; margin:auto"" >
								<i class=""fas fa-caret-down""></i> Tìm Kiếm Nâng Cao
							</button>
						</div>
						<div class=""col-12 col-sm-12 col-md-12 col-lg-12 col-xl-12 mx-auto mb-3"">
							<button id=""button-find"" type=""button"" class=""btn  d-block"" style=""background-color:#ffc312; width:50%; margin:auto"">
								<i class=""fas fa-search""></i> Tìm Kiếm
							</button>
						</div>
				</");
            WriteLiteral(@"div>
			</div>
		</div>
	</div>
	<div id=""result-holder"" class =""container"" ></div>
	<div class=""promotion"">
		<div class=""container"">
			<h2 class=""text-uppercase font-bolder"">Ưu Đãi</h2>
			<div class=""row blog"">
				<div class=""col-md-12 mx-auto"">
					<div id=""blogCarousel"" class=""carousel slide"" data-ride=""carousel"">
						<ol class=""carousel-indicators"">
							<li data-target=""#blogCarousel"" data-slide-to=""0"" class=""active""></li>
							<li data-target=""#blogCarousel"" data-slide-to=""1""></li>
						</ol>
						<!-- Carousel items -->
						<div class=""carousel-inner"">
							<div class=""carousel-item active"">
								<div class=""row"">
									<div class=""col-md-3"">
										<a href=""#"">
											<img src=""http://placehold.it/250x250"" alt=""Image"" style=""max-width:100%;"">
										</a>
									</div>
									<div class=""col-md-3"">
										<a href=""#"">
											<img src=""http://placehold.it/250x250"" alt=""Image"" style=""max-width:100%;"">
										</a>
									</div>
");
            WriteLiteral(@"									<div class=""col-md-3"">
										<a href=""#"">
											<img src=""http://placehold.it/250x250"" alt=""Image"" style=""max-width:100%;"">
										</a>
									</div>
									<div class=""col-md-3"">
										<a href=""#"">
											<img src=""http://placehold.it/250x250"" alt=""Image"" style=""max-width:100%;"">
										</a>
									</div>
								</div>
								<!--.row-->
							</div>
							<!--.item-->

							<div class=""carousel-item"">
								<div class=""row"">
									<div class=""col-md-3"">
										<a href=""#"">
											<img src=""http://placehold.it/250x250"" alt=""Image"" style=""max-width:100%;"">
										</a>
									</div>
									<div class=""col-md-3"">
										<a href=""#"">
											<img src=""http://placehold.it/250x250"" alt=""Image"" style=""max-width:100%;"">
										</a>
									</div>
									<div class=""col-md-3"">
										<a href=""#"">
											<img src=""http://placehold.it/250x250"" alt=""Image"" style=""max-width:100%;"">
										</a>
									</di");
            WriteLiteral(@"v>
									<div class=""col-md-3"">
										<a href=""#"">
											<img src=""http://placehold.it/250x250"" alt=""Image"" style=""max-width:100%;"">
										</a>
									</div>
								</div>
								<!--.row-->
							</div>
							<!--.item-->

						</div>
						<!--.carousel-inner-->
					</div>
					<!--.Carousel-->

				</div>
			</div>
		</div>
	</div>
	<div class=""about-system"">
		<div class=""container"">
			<div class=""row"">
				<div class=""contents col-12 col-sm-12 col-md-12 col-lg-12 col-xl-12"">
					<h3 class=""about-title"">
						Tuyến Đường
					</h3>
					<p class="" about-text"">
						Đến Đà Nẵng, ngoài việc đi bằng máy bay, tàu hỏa thì xe khách cũng là phương tiện được rất nhiều du khách lựa chọn, ở các bến xe Đà Nẵng bạn có thể tìm cho mình rất nhiều các nhà xe với những lộ trình đi tới nhiều tỉnh thành trên cả nước, điều đó khiến
						xe khách trở thành một trong những phương tiện đem lại sự thuận tiện cho những chuyến đi xa. <br> Một số tuyến xe chính tại Bến xe t");
            WriteLiteral(@"rung tâm Đà Nẵng: Đà Nẵng – Hà Nội, Đà Nẵng – Quảng Bình, Đà Nẵng
						– Ninh Bình, Đà Nẵng – Thanh Hóa, Đà Nẵng – Nghệ An, Đà Nẵng – Thừa Thiên Huế, Đà Nẵng – Lâm Đồng, Đà Nẵng – TP. HCM, Đà Nẵng – Quảng Ngãi, Đà Nẵng – Bình Định, Đà Nẵng – Đắk Lắk, Đà Nẵng – Khánh Hòa, Đà Nẵng – Phú Yên, Đà
						Nẵng – Ninh Thuận, Đà Nẵng – Gia Lai, Đà Nẵng – Hải Phòng.
					</p>
				</div>
				<div class=""contents col-12 col-sm-12 col-md-12 col-lg-12 col-xl-12"">
					<h3 class=""about-title"">
						Nhà Xe
					</h3>
					<p class="" about-text"">
						- Bến xe khách thành phố Đà Nẵng có sự liên kết chặc chẽ với các nhà xe trên khắp thành phố, với phương tiện hiện đại và giá thành phải chăng có thể kể đến những nhà xe nổi tiếng như sau:Xe khách Tiến tuyến Tp Hồ Chí Minh-Đà nẵng,nhà xe Hiếu Viện, xe
						khách Thọ Mười, xe khách Hoàng Long,nhà xe Phúc Thuận…
					</p>
				</div>
				<div class=""contents col-12 col-sm-12 col-md-12 col-lg-12 col-xl-12"">
					<h3 class=""about-title"">
						Đại Lý Bán Vé
					<");
            WriteLiteral(@"/h3>
					<p class="" about-text"">
						Đến Đà Nẵng, ngoài việc đi bằng máy bay, tàu hỏa thì xe khách cũng là phương tiện được rất nhiều du khách lựa chọn, ở các bến xe Đà Nẵng bạn có thể tìm cho mình rất nhiều các nhà xe với những lộ trình đi tới nhiều tỉnh thành trên cả nước, điều đó khiến
						xe khách trở thành một trong những phương tiện đem lại sự thuận tiện cho những chuyến đi xa. <br> Một số tuyến xe chính tại Bến xe trung tâm Đà Nẵng: Đà Nẵng – Hà Nội, Đà Nẵng – Quảng Bình, Đà Nẵng
						– Ninh Bình, Đà Nẵng – Thanh Hóa, Đà Nẵng – Nghệ An, Đà Nẵng – Thừa Thiên Huế, Đà Nẵng – Lâm Đồng, Đà Nẵng – TP. HCM, Đà Nẵng – Quảng Ngãi, Đà Nẵng – Bình Định, Đà Nẵng – Đắk Lắk, Đà Nẵng – Khánh Hòa, Đà Nẵng – Phú Yên, Đà
						Nẵng – Ninh Thuận, Đà Nẵng – Gia Lai, Đà Nẵng – Hải Phòng.
					</p>
				</div>
				<div class=""contents col-12 col-sm-12 col-md-12 col-lg-12 col-xl-12"">
					<h3 class=""about-title"">
						Bến Xe
					</h3>
					<p class="" about-text"">
						Đến Đà Nẵng, ngoài việc đi bằng máy ");
            WriteLiteral(@"bay, tàu hỏa thì xe khách cũng là phương tiện được rất nhiều du khách lựa chọn, ở các bến xe Đà Nẵng bạn có thể tìm cho mình rất nhiều các nhà xe với những lộ trình đi tới nhiều tỉnh thành trên cả nước, điều đó khiến
						xe khách trở thành một trong những phương tiện đem lại sự thuận tiện cho những chuyến đi xa. <br> Một số tuyến xe chính tại Bến xe trung tâm Đà Nẵng: Đà Nẵng – Hà Nội, Đà Nẵng – Quảng Bình, Đà Nẵng
						– Ninh Bình, Đà Nẵng – Thanh Hóa, Đà Nẵng – Nghệ An, Đà Nẵng – Thừa Thiên Huế, Đà Nẵng – Lâm Đồng, Đà Nẵng – TP. HCM, Đà Nẵng – Quảng Ngãi, Đà Nẵng – Bình Định, Đà Nẵng – Đắk Lắk, Đà Nẵng – Khánh Hòa, Đà Nẵng – Phú Yên, Đà
						Nẵng – Ninh Thuận, Đà Nẵng – Gia Lai, Đà Nẵng – Hải Phòng.
					</p>
				</div>
			</div>
		</div>
	</div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

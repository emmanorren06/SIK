#pragma checksum "D:\SIK\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "487f33df66c6e70e9b287383fb05aff533c751f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "D:\SIK\Views\_ViewImports.cshtml"
using SIK;

#line default
#line hidden
#line 2 "D:\SIK\Views\_ViewImports.cshtml"
using SIK.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"487f33df66c6e70e9b287383fb05aff533c751f8", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22b03716ade0850a7964f5294df88c80ec803379", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/fontawesome-free/css/all.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/sb-admin-2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-none d-sm-inline-block form-inline mr-auto ml-md-3 my-2 my-md-0 mw-100 navbar-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline mr-auto w-100 navbar-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/bootstrap/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/jquery-easing/jquery.easing.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/sb-admin-2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 37, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(37, 679, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "487f33df66c6e70e9b287383fb05aff533c751f87749", async() => {
                BeginContext(43, 326, true);
                WriteLiteral(@"

  <meta charset=""utf-8"">
  <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
  <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
  <meta name=""description"" content="""">
  <meta name=""author"" content="""">

  <title>SI KUAT</title>

  <!-- Custom fonts for this template-->
  ");
                EndContext();
                BeginContext(369, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "487f33df66c6e70e9b287383fb05aff533c751f88472", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(457, 193, true);
                WriteLiteral("\r\n  <link href=\"https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i\" rel=\"stylesheet\">\r\n\r\n  <!-- Custom styles for this template-->\r\n  ");
                EndContext();
                BeginContext(650, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "487f33df66c6e70e9b287383fb05aff533c751f810091", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(705, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(716, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(720, 17255, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "487f33df66c6e70e9b287383fb05aff533c751f812231", async() => {
                BeginContext(740, 311, true);
                WriteLiteral(@"

  <!-- Page Wrapper -->
  <div id=""wrapper"">

    <!-- Sidebar -->
    <ul class=""navbar-nav bg-gradient-primary sidebar sidebar-dark accordion"" id=""accordionSidebar"">

      <!-- Sidebar - Brand -->
      <a class=""sidebar-brand d-flex align-items-center justify-content-center"" href=""index.html"">
");
                EndContext();
                BeginContext(1172, 317, true);
                WriteLiteral(@"        <img src=""/img/fox.png"" alt=""fox"" style=""width:65%"">
        <div class=""sidebar-brand-text mx-4"">SI KUAT</div>
      </a>

      <!-- Divider -->
      <hr class=""sidebar-divider my-0"">

      <!-- Nav Item - Dashboard -->
      <li class=""nav-item"">
        <a class=""nav-link"" href=""index.html"">
");
                EndContext();
                BeginContext(1550, 72, true);
                WriteLiteral("          <span>HOME</span></a>\r\n      </li>\r\n\r\n      <!-- Divider -->\r\n");
                EndContext();
                BeginContext(1664, 26, true);
                WriteLiteral("\r\n      <!-- Heading -->\r\n");
                EndContext();
                BeginContext(1766, 226, true);
                WriteLiteral("\r\n      <!-- Nav Item - Pages Collapse Menu -->\r\n      <li class=\"nav-item\">\r\n        <a class=\"nav-link collapsed\" href=\"#\" data-toggle=\"collapse\" data-target=\"#collapseTwo\" aria-expanded=\"true\" aria-controls=\"collapseTwo\">\r\n");
                EndContext();
                BeginContext(2042, 218, true);
                WriteLiteral("          <span>LAPORAN</span>\r\n        </a>\r\n        <div id=\"collapseTwo\" class=\"collapse\" aria-labelledby=\"headingTwo\" data-parent=\"#accordionSidebar\">\r\n          <div class=\"bg-white py-2 collapse-inner rounded\">\r\n");
                EndContext();
                BeginContext(2328, 262, true);
                WriteLiteral(@"            <a class=""collapse-item"" href=""buttons.html"">Laporan Penyusutan</a>
            <a class=""collapse-item"" href=""cards.html"">Laporan Aktiva Tetap</a>
          </div>
        </div>
      </li>

      <!-- Nav Item - Utilities Collapse Menu -->
");
                EndContext();
                BeginContext(3505, 79, true);
                WriteLiteral("\r\n      <li class=\"nav-item\">\r\n        <a class=\"nav-link\" href=\"index.html\">\r\n");
                EndContext();
                BeginContext(3645, 208, true);
                WriteLiteral("          <span>SETUP DATA ADMIN</span></a>\r\n      </li>\r\n\r\n      <!-- Divider -->\r\n      <hr class=\"sidebar-divider\">\r\n\r\n      <!-- Heading -->\r\n      <div class=\"sidebar-heading\">\r\n       \r\n      </div>\r\n\r\n");
                EndContext();
                BeginContext(4960, 112, true);
                WriteLiteral("       <!-- Nav Item - Charts -->\r\n      <li class=\"nav-item\">\r\n        <a class=\"nav-link\" href=\"Index.html\">\r\n");
                EndContext();
                BeginContext(5129, 172, true);
                WriteLiteral("          <span>SETUP DATA AKTIVA</span></a>\r\n      </li>\r\n\r\n      <!-- Nav Item - Charts -->\r\n      <li class=\"nav-item\">\r\n        <a class=\"nav-link\" href=\"Index.html\">\r\n");
                EndContext();
                BeginContext(5358, 176, true);
                WriteLiteral("          <span>KATEGORI AKTIVA TETAP</span></a>\r\n      </li>\r\n\r\n      <!-- Nav Item - Tables -->\r\n      <li class=\"nav-item\">\r\n        <a class=\"nav-link\" href=\"Index.html\">\r\n");
                EndContext();
                BeginContext(5586, 886, true);
                WriteLiteral(@"          <span>HITUNG PENYUSUTAN</span></a>
      </li>

      <!-- Divider -->
      <hr class=""sidebar-divider d-none d-md-block"">

      <!-- Sidebar Toggler (Sidebar) -->
      <div class=""text-center d-none d-md-inline"">
        <button class=""rounded-circle border-0"" id=""sidebarToggle""></button>
      </div>

    </ul>
    <!-- End of Sidebar -->

    <!-- Content Wrapper -->
    <div id=""content-wrapper"" class=""d-flex flex-column"">

      <!-- Main Content -->
      <div id=""content"">

        <!-- Topbar -->
        <nav class=""navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow"">

          <!-- Sidebar Toggle (Topbar) -->
          <button id=""sidebarToggleTop"" class=""btn btn-link d-md-none rounded-circle mr-3"">
            <i class=""fa fa-bars""></i>
          </button>

          <!-- Topbar Search -->
          ");
                EndContext();
                BeginContext(6472, 555, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "487f33df66c6e70e9b287383fb05aff533c751f817241", async() => {
                    BeginContext(6573, 447, true);
                    WriteLiteral(@"
            <div class=""input-group"">
              <input type=""text"" class=""form-control bg-light border-0 small"" placeholder=""Search for..."" aria-label=""Search"" aria-describedby=""basic-addon2"">
              <div class=""input-group-append"">
                <button class=""btn btn-primary"" type=""button"">
                  <i class=""fas fa-search fa-sm""></i>
                </button>
              </div>
            </div>
          ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7027, 632, true);
                WriteLiteral(@"

          <!-- Topbar Navbar -->
          <ul class=""navbar-nav ml-auto"">

            <!-- Nav Item - Search Dropdown (Visible Only XS) -->
            <li class=""nav-item dropdown no-arrow d-sm-none"">
              <a class=""nav-link dropdown-toggle"" href=""#"" id=""searchDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <i class=""fas fa-search fa-fw""></i>
              </a>
              <!-- Dropdown - Messages -->
              <div class=""dropdown-menu dropdown-menu-right p-3 shadow animated--grow-in"" aria-labelledby=""searchDropdown"">
                ");
                EndContext();
                BeginContext(7659, 562, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "487f33df66c6e70e9b287383fb05aff533c751f819987", async() => {
                    BeginContext(7713, 501, true);
                    WriteLiteral(@"
                  <div class=""input-group"">
                    <input type=""text"" class=""form-control bg-light border-0 small"" placeholder=""Search for..."" aria-label=""Search"" aria-describedby=""basic-addon2"">
                    <div class=""input-group-append"">
                      <button class=""btn btn-primary"" type=""button"">
                        <i class=""fas fa-search fa-sm""></i>
                      </button>
                    </div>
                  </div>
                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8221, 7743, true);
                WriteLiteral(@"
              </div>
            </li>

            <!-- Nav Item - Alerts -->
            <li class=""nav-item dropdown no-arrow mx-1"">
              <a class=""nav-link dropdown-toggle"" href=""#"" id=""alertsDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <i class=""fas fa-bell fa-fw""></i>
                <!-- Counter - Alerts -->
                <span class=""badge badge-danger badge-counter"">3+</span>
              </a>
              <!-- Dropdown - Alerts -->
              <div class=""dropdown-list dropdown-menu dropdown-menu-right shadow animated--grow-in"" aria-labelledby=""alertsDropdown"">
                <h6 class=""dropdown-header"">
                  Alerts Center
                </h6>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                  <div class=""mr-3"">
                    <div class=""icon-circle bg-primary"">
                      <i class=""fas fa-file-alt text-white""></i>
             ");
                WriteLiteral(@"       </div>
                  </div>
                  <div>
                    <div class=""small text-gray-500"">December 12, 2019</div>
                    <span class=""font-weight-bold"">A new monthly report is ready to download!</span>
                  </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                  <div class=""mr-3"">
                    <div class=""icon-circle bg-success"">
                      <i class=""fas fa-donate text-white""></i>
                    </div>
                  </div>
                  <div>
                    <div class=""small text-gray-500"">December 7, 2019</div>
                    $290.29 has been deposited into your account!
                  </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                  <div class=""mr-3"">
                    <div class=""icon-circle bg-warning"">
                      <i class=""fas fa-exclamat");
                WriteLiteral(@"ion-triangle text-white""></i>
                    </div>
                  </div>
                  <div>
                    <div class=""small text-gray-500"">December 2, 2019</div>
                    Spending Alert: We've noticed unusually high spending for your account.
                  </div>
                </a>
                <a class=""dropdown-item text-center small text-gray-500"" href=""#"">Show All Alerts</a>
              </div>
            </li>

            <!-- Nav Item - Messages -->
            <li class=""nav-item dropdown no-arrow mx-1"">
              <a class=""nav-link dropdown-toggle"" href=""#"" id=""messagesDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <i class=""fas fa-envelope fa-fw""></i>
                <!-- Counter - Messages -->
                <span class=""badge badge-danger badge-counter"">7</span>
              </a>
              <!-- Dropdown - Messages -->
              <div class=""dropdown-list dropdown-m");
                WriteLiteral(@"enu dropdown-menu-right shadow animated--grow-in"" aria-labelledby=""messagesDropdown"">
                <h6 class=""dropdown-header"">
                  Message Center
                </h6>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                  <div class=""dropdown-list-image mr-3"">
                    <img class=""rounded-circle"" src=""https://source.unsplash.com/fn_BT9fwg_E/60x60"" alt="""">
                    <div class=""status-indicator bg-success""></div>
                  </div>
                  <div class=""font-weight-bold"">
                    <div class=""text-truncate"">Hi there! I am wondering if you can help me with a problem I've been having.</div>
                    <div class=""small text-gray-500"">Emily Fowler · 58m</div>
                  </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                  <div class=""dropdown-list-image mr-3"">
                    <img class=""rounded-circle"" sr");
                WriteLiteral(@"c=""https://source.unsplash.com/AU4VPcFN4LE/60x60"" alt="""">
                    <div class=""status-indicator""></div>
                  </div>
                  <div>
                    <div class=""text-truncate"">I have the photos that you ordered last month, how would you like them sent to you?</div>
                    <div class=""small text-gray-500"">Jae Chun · 1d</div>
                  </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                  <div class=""dropdown-list-image mr-3"">
                    <img class=""rounded-circle"" src=""https://source.unsplash.com/CS2uCrpNzJY/60x60"" alt="""">
                    <div class=""status-indicator bg-warning""></div>
                  </div>
                  <div>
                    <div class=""text-truncate"">Last month's report looks great, I am very happy with the progress so far, keep up the good work!</div>
                    <div class=""small text-gray-500"">Morgan Alvarez · 2d</div>
                WriteLiteral(@"
                  </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                  <div class=""dropdown-list-image mr-3"">
                    <img class=""rounded-circle"" src=""https://source.unsplash.com/Mv9hjnEUHR4/60x60"" alt="""">
                    <div class=""status-indicator bg-success""></div>
                  </div>
                  <div>
                    <div class=""text-truncate"">Am I a good boy? The reason I ask is because someone told me that people say this to all dogs, even if they aren't good...</div>
                    <div class=""small text-gray-500"">Chicken the Dog · 2w</div>
                  </div>
                </a>
                <a class=""dropdown-item text-center small text-gray-500"" href=""#"">Read More Messages</a>
              </div>
            </li>

            <div class=""topbar-divider d-none d-sm-block""></div>

            <!-- Nav Item - User Information -->
            <li class=""nav-item dropd");
                WriteLiteral(@"own no-arrow"">
              <a class=""nav-link dropdown-toggle"" href=""#"" id=""userDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <span class=""mr-2 d-none d-lg-inline text-gray-600 small"">Valerie Luna</span>
                <img class=""img-profile rounded-circle"" src=""https://source.unsplash.com/QAB-WJcbgJk/60x60"">
              </a>
              <!-- Dropdown - User Information -->
              <div class=""dropdown-menu dropdown-menu-right shadow animated--grow-in"" aria-labelledby=""userDropdown"">
                <a class=""dropdown-item"" href=""#"">
                  <i class=""fas fa-user fa-sm fa-fw mr-2 text-gray-400""></i>
                  Profile
                </a>
                <a class=""dropdown-item"" href=""#"">
                  <i class=""fas fa-cogs fa-sm fa-fw mr-2 text-gray-400""></i>
                  Settings
                </a>
                <a class=""dropdown-item"" href=""#"">
                  <i class=""fas fa-list fa");
                WriteLiteral(@"-sm fa-fw mr-2 text-gray-400""></i>
                  Activity Log
                </a>
                <div class=""dropdown-divider""></div>
                <a class=""dropdown-item"" href=""#"" data-toggle=""modal"" data-target=""#logoutModal"">
                  <i class=""fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400""></i>
                  Logout
                </a>
              </div>
            </li>

          </ul>

        </nav>
        <!-- End of Topbar -->

        <!-- Begin Page Content -->
        <div class=""container-fluid"">

        ");
                EndContext();
                BeginContext(15965, 12, false);
#line 347 "D:\SIK\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(15977, 1662, true);
                WriteLiteral(@"

           <!-- Page Heading 
          <h1 class=""h3 mb-4 text-gray-800"">Blank Page</h1> -->

        </div>
        <!-- /.container-fluid -->

      </div>
      <!-- End of Main Content -->

      <!-- Footer -->
      <footer class=""sticky-footer bg-white"">
        <div class=""container my-auto"">
          <div class=""copyright text-center my-auto"">
            <span>Copyright &copy; SI KUAT 2020</span>
          </div>
        </div>
      </footer>
      <!-- End of Footer -->

    </div>
    <!-- End of Content Wrapper -->

  </div>
  <!-- End of Page Wrapper -->

  <!-- Scroll to Top Button-->
  <a class=""scroll-to-top rounded"" href=""#page-top"">
    <i class=""fas fa-angle-up""></i>
  </a>

  <!-- Logout Modal-->
  <div class=""modal fade"" id=""logoutModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
      <div class=""modal-content"">
        <div class=""modal-header"">
          <h");
                WriteLiteral(@"5 class=""modal-title"" id=""exampleModalLabel"">Ready to Leave?</h5>
          <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
            <span aria-hidden=""true"">×</span>
          </button>
        </div>
        <div class=""modal-body"">Select ""Logout"" below if you are ready to end your current session.</div>
        <div class=""modal-footer"">
          <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Cancel</button>
          <a class=""btn btn-primary"" href=""login.html"">Logout</a>
        </div>
      </div>
    </div>
  </div>

  <!-- Bootstrap core JavaScript-->
  ");
                EndContext();
                BeginContext(17639, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "487f33df66c6e70e9b287383fb05aff533c751f832422", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(17692, 4, true);
                WriteLiteral("\r\n  ");
                EndContext();
                BeginContext(17696, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "487f33df66c6e70e9b287383fb05aff533c751f833678", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(17765, 40, true);
                WriteLiteral("\r\n\r\n  <!-- Core plugin JavaScript-->\r\n  ");
                EndContext();
                BeginContext(17805, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "487f33df66c6e70e9b287383fb05aff533c751f834975", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(17872, 46, true);
                WriteLiteral("\r\n\r\n  <!-- Custom scripts for all pages-->\r\n  ");
                EndContext();
                BeginContext(17918, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "487f33df66c6e70e9b287383fb05aff533c751f836278", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(17964, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(17975, 13, true);
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
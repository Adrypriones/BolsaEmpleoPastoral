#pragma checksum "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Login\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5f72135cdfedf01f228af1241a6bd664ae6797c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Login), @"mvc.1.0.view", @"/Views/Login/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Login.cshtml", typeof(AspNetCore.Views_Login_Login))]
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
#line 1 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\_ViewImports.cshtml"
using PastoralEmpleo;

#line default
#line hidden
#line 2 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\_ViewImports.cshtml"
using PastoralEmpleo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5f72135cdfedf01f228af1241a6bd664ae6797c", @"/Views/Login/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"928166129b11b939891901ba6c4b6f1f2c82cf50", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PastoralEmpleo.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal m-t-20"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("index.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Login\Login.cshtml"
  

    ViewData["Title"] = "Login";
    Layout = "~/Views/Shared/LayoutSecondary.cshtml";

#line default
#line hidden
            BeginContext(133, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            EndContext();
            BeginContext(162, 3537, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "164b8532bd894a728e2de4c5d04491c5", async() => {
                BeginContext(168, 550, true);
                WriteLiteral(@"

    <div class=""account-pages""></div>
    <div class=""clearfix""></div>
    <div class=""wrapper-page"">
        <div class=""text-center"">
            <a href=""index.html"" class=""logo""><span>Pastoral<span>Empleo</span></span></a>
            <h5 class=""text-muted m-t-0 font-600"">Trabaja con Nosotros</h5>
        </div>
        <div class=""m-t-40 card-box"">
            <div class=""text-center"">
                <h4 class=""text-uppercase font-bold m-b-0"">Ingresa</h4>
            </div>

            <div class=""p-20"">
                ");
                EndContext();
                BeginContext(718, 1888, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b12b314137134c1e9577fc61722962d9", async() => {
                    BeginContext(775, 74, true);
                    WriteLiteral("\r\n\r\n                    <div class=\"form-group\">\r\n                        ");
                    EndContext();
                    BeginContext(850, 84, false);
#line 29 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Login\Login.cshtml"
                   Write(Html.LabelFor(model => model.Mail, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(934, 26, true);
                    WriteLiteral("\r\n                        ");
                    EndContext();
                    BeginContext(961, 92, false);
#line 30 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Login\Login.cshtml"
                   Write(Html.TextBoxFor(model => model.Mail, new { @class = "form-control", required = "required" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(1053, 102, true);
                    WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"form-group\">\r\n                        ");
                    EndContext();
                    BeginContext(1156, 88, false);
#line 34 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Login\Login.cshtml"
                   Write(Html.LabelFor(model => model.Password, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(1244, 26, true);
                    WriteLiteral("\r\n                        ");
                    EndContext();
                    BeginContext(1271, 96, false);
#line 35 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Login\Login.cshtml"
                   Write(Html.TextBoxFor(model => model.Password, new { @class = "form-control", required = "required" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(1367, 693, true);
                    WriteLiteral(@"
                    </div>

                    
                    <div class=""form-group "">
                        <div class=""col-xs-12"">
                            <div class=""checkbox checkbox-custom"">
                                <input id=""checkbox-signup"" type=""checkbox"">
                                <label for=""checkbox-signup"">
                                    Recuérdame
                                </label>
                            </div>

                        </div>
                    </div>

                    <div class=""form-group text-center m-t-30"">
                        <div class=""col-xs-12"">
                            <a");
                    EndContext();
                    BeginWriteAttribute("href", " href=\"", 2060, "\"", 2097, 1);
#line 53 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Login\Login.cshtml"
WriteAttributeValue("", 2067, Url.Action("Contact", "Home"), 2067, 30, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(2098, 298, true);
                    WriteLiteral(@" class=""btn btn-custom btn-bordred btn-block waves-effect waves-light"" type=""submit"">Iniciar</a>
                        </div>
                    </div>

                    <div class=""form-group m-t-30 m-b-0"">
                        <div class=""col-sm-12"">
                            <a");
                    EndContext();
                    BeginWriteAttribute("href", " href=\"", 2396, "\"", 2440, 1);
#line 59 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Login\Login.cshtml"
WriteAttributeValue("", 2403, Url.Action("ResetPassword", "Login"), 2403, 37, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(2441, 158, true);
                    WriteLiteral(" class=\"text-muted\"><i class=\"fa fa-lock m-r-5\"></i> Olvidades tu cotraseña?</a>\r\n                        </div>\r\n                    </div>\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2606, 206, true);
                WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n        <!-- end card-box-->\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-12 text-center\">\r\n                <p class=\"text-muted\">No tienes cuenta? <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2812, "\"", 2851, 1);
#line 70 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Login\Login.cshtml"
WriteAttributeValue("", 2819, Url.Action("Register", "Login"), 2819, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2852, 840, true);
                WriteLiteral(@" class=""text-primary m-l-5""><b>Registrate</b></a></p>
            </div>
        </div>

    </div>
    <!-- end wrapper page -->
    <!-- jQuery  -->
    <script src=""assets/js/jquery.min.js""></script>
    <script src=""assets/js/popper.min.js""></script>
    <script src=""assets/js/bootstrap.min.js""></script>
    <script src=""assets/js/detect.js""></script>
    <script src=""assets/js/fastclick.js""></script>
    <script src=""assets/js/jquery.blockUI.js""></script>
    <script src=""assets/js/waves.js""></script>
    <script src=""assets/js/jquery.nicescroll.js""></script>
    <script src=""assets/js/jquery.slimscroll.js""></script>
    <script src=""assets/js/jquery.scrollTo.min.js""></script>

    <!-- App js -->
    <script src=""assets/js/jquery.core.js""></script>
    <script src=""assets/js/jquery.app.js""></script>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3699, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PastoralEmpleo.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591

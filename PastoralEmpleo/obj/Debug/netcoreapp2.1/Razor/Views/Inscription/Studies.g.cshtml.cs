#pragma checksum "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Studies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c5f2a39f8e6e4a61bfa9697250146ec1c9c92f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inscription_Studies), @"mvc.1.0.view", @"/Views/Inscription/Studies.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inscription/Studies.cshtml", typeof(AspNetCore.Views_Inscription_Studies))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c5f2a39f8e6e4a61bfa9697250146ec1c9c92f9", @"/Views/Inscription/Studies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"928166129b11b939891901ba6c4b6f1f2c82cf50", @"/Views/_ViewImports.cshtml")]
    public class Views_Inscription_Studies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PastoralEmpleo.ViewModel.StudiesInformationViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Studies.cshtml"
  
    ViewData["Title"] = "Studies";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(155, 98, true);
            WriteLiteral("\r\n\r\n<section>\r\n\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-xs-12 col-sm-3\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 253, "\"", 299, 1);
#line 15 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Studies.cshtml"
WriteAttributeValue("", 260, Url.Action("Candidate", "Inscription"), 260, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(300, 172, true);
            WriteLiteral(" class=\"btn btn-info\" style=\"color:#004D97\"><i class=\"zmdi zmdi-plus\"></i> &nbsp; PERSONALES</a>\r\n        </div>\r\n\r\n        <div class=\"col-xs-12 col-sm-3\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 472, "\"", 516, 1);
#line 19 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Studies.cshtml"
WriteAttributeValue("", 479, Url.Action("Studies", "Inscription"), 479, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(517, 190, true);
            WriteLiteral(" class=\"btn btn-success\" style=\"color:#004D97\"><i class=\"zmdi zmdi-format-list-bulleted\"></i> &nbsp; FORMACIÓN</a>\r\n        </div>\r\n\r\n        <div class=\"col-xs-12 col-sm-3\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 707, "\"", 754, 1);
#line 23 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Studies.cshtml"
WriteAttributeValue("", 714, Url.Action("Experience", "Inscription"), 714, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(755, 178, true);
            WriteLiteral(" class=\"btn btn-primary\" style=\"color:#004D97\"><i class=\"zmdi zmdi-search\"></i> &nbsp; EXPERIENCIA</a>\r\n        </div>\r\n\r\n        <div class=\"col-xs-12 col-sm-3\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 933, "\"", 978, 1);
#line 27 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Studies.cshtml"
WriteAttributeValue("", 940, Url.Action("Document", "Inscription"), 940, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(979, 454, true);
            WriteLiteral(@" class=""btn btn-danger"" style=""color:#004D97""><i class=""zmdi zmdi-comment-list""></i> &nbsp; OTROS DOCUMENTOS</a>
        </div>

        <div class=""container-fluid"">
            <div class=""page-header"">
                <h1 class=""text-titles""><i class=""zmdi zmdi-account zmdi-hc-fw""></i> <small>Académicos</small></h1>
            </div>
        </div>



        <div class=""container-fluid"">
            <div class=""panel panel-info"">

");
            EndContext();
#line 41 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Studies.cshtml"
                 using (Html.BeginForm("Continuar", "Inscription", FormMethod.Post))
                {

                    

#line default
#line hidden
            BeginContext(1561, 23, false);
#line 44 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Studies.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1588, 325, true);
            WriteLiteral(@"                    <fieldset>



                        <div class=""container-fluid"">
                            <div class=""row"">

                                <div class=""col-xs-12 col-sm-6"">
                                    <div class=""form-group label-floating"">
                                        ");
            EndContext();
            BeginContext(1914, 86, false);
#line 55 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Studies.cshtml"
                                   Write(Html.LabelFor(model => model.School, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(2000, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(2043, 71, false);
#line 56 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Studies.cshtml"
                                   Write(Html.TextBoxFor(model => model.School, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2114, 271, true);
            WriteLiteral(@"
                                    </div>
                                </div>

                                <div class=""col-xs-12 col-sm-6"">
                                    <div class=""form-group label-floating"">
                                        ");
            EndContext();
            BeginContext(2386, 92, false);
#line 62 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Studies.cshtml"
                                   Write(Html.LabelFor(model => model.Idstudylevel, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(2478, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(2521, 108, false);
#line 63 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Studies.cshtml"
                                   Write(Html.DropDownListFor(model => model.Idstudylevel, Model.StudyLevelList, "", new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2629, 271, true);
            WriteLiteral(@"
                                    </div>
                                </div>

                                <div class=""col-xs-12 col-sm-6"">
                                    <div class=""form-group label-floating"">
                                        ");
            EndContext();
            BeginContext(2901, 93, false);
#line 69 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Studies.cshtml"
                                   Write(Html.LabelFor(model => model.Obtainedtitle, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(2994, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(3037, 78, false);
#line 70 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Studies.cshtml"
                                   Write(Html.TextBoxFor(model => model.Obtainedtitle, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3115, 271, true);
            WriteLiteral(@"
                                    </div>
                                </div>

                                <div class=""col-xs-12 col-sm-6"">
                                    <div class=""form-group label-floating"">
                                        ");
            EndContext();
            BeginContext(3387, 95, false);
#line 76 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Studies.cshtml"
                                   Write(Html.LabelFor(model => model.Idacademicstate, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(3482, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(3525, 114, false);
#line 77 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Studies.cshtml"
                                   Write(Html.DropDownListFor(model => model.Idacademicstate, Model.academicStateList, "", new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3639, 271, true);
            WriteLiteral(@"
                                    </div>
                                </div>

                                <div class=""col-xs-12 col-sm-6"">
                                    <div class=""form-group label-floating"">
                                        ");
            EndContext();
            BeginContext(3911, 89, false);
#line 83 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Studies.cshtml"
                                   Write(Html.LabelFor(model => model.Startdate, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(4000, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(4043, 113, false);
#line 84 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Studies.cshtml"
                                   Write(Html.TextBoxFor(model => model.Startdate, new { @class = "form-control", required = "required", @type = "Date" }));

#line default
#line hidden
            EndContext();
            BeginContext(4156, 271, true);
            WriteLiteral(@"
                                    </div>
                                </div>

                                <div class=""col-xs-12 col-sm-6"">
                                    <div class=""form-group label-floating"">
                                        ");
            EndContext();
            BeginContext(4428, 87, false);
#line 90 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Studies.cshtml"
                                   Write(Html.LabelFor(model => model.Enddate, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(4515, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(4558, 111, false);
#line 91 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Studies.cshtml"
                                   Write(Html.TextBoxFor(model => model.Enddate, new { @class = "form-control", required = "required", @type = "Date" }));

#line default
#line hidden
            EndContext();
            BeginContext(4669, 271, true);
            WriteLiteral(@"
                                    </div>
                                </div>

                                <div class=""col-xs-12 col-sm-6"">
                                    <div class=""form-group label-floating"">
                                        ");
            EndContext();
            BeginContext(4941, 93, false);
#line 97 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Studies.cshtml"
                                   Write(Html.LabelFor(model => model.Idperiodicity, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(5034, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(5077, 110, false);
#line 98 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Studies.cshtml"
                                   Write(Html.DropDownListFor(model => model.Idperiodicity, Model.PeriodicityList, "", new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(5187, 603, true);
            WriteLiteral(@"
                                    </div>
                                </div>

                                <div class=""col-xs-12 col-sm-6"">
                                    <div class=""form-group label-floating"">
                                        <label for=""Document"">Adjuntar Titulo ó Certificación</label>
                                        <input type=""file"" class=""form-control"">
                                    </div>
                                </div>

                            </div>
                        </div>
                    </fieldset>
");
            EndContext();
            BeginContext(5792, 277, true);
            WriteLiteral(@"                    <div class=""text-center"">
                        <div class=""margin-top: 20px"">
                            <input type=""submit"" value=""Continuar"" class=""btn btn-primary btn-bordred btn-sm"" />
                        </div>
                    </div>
");
            EndContext();
            BeginContext(6071, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6093, "\"", 6136, 1);
#line 119 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Studies.cshtml"
WriteAttributeValue("", 6100, Url.Action("Index", "StudyListing"), 6100, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6137, 135, true);
            WriteLiteral(" button type=\"button\" class=\"btn btn-outline-success btn-rounded w-md waves-effect waves-light m-b-5\" style=\"color:#ffffff\">Lista</a>\r\n");
            EndContext();
#line 120 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Studies.cshtml"
                }

#line default
#line hidden
            BeginContext(6291, 64, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PastoralEmpleo.ViewModel.StudiesInformationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

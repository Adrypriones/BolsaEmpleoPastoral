#pragma checksum "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Experience.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d220629a021b66a6411d932f7565915b21e9559"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inscription_Experience), @"mvc.1.0.view", @"/Views/Inscription/Experience.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inscription/Experience.cshtml", typeof(AspNetCore.Views_Inscription_Experience))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d220629a021b66a6411d932f7565915b21e9559", @"/Views/Inscription/Experience.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"928166129b11b939891901ba6c4b6f1f2c82cf50", @"/Views/_ViewImports.cshtml")]
    public class Views_Inscription_Experience : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PastoralEmpleo.ViewModel.ExperienceInformationViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Experience.cshtml"
  
    ViewData["Title"] = "Experience";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(157, 96, true);
            WriteLiteral("\r\n<section>\r\n\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-xs-12 col-sm-3\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 253, "\"", 299, 1);
#line 12 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Experience.cshtml"
WriteAttributeValue("", 260, Url.Action("Candidate", "Inscription"), 260, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(300, 172, true);
            WriteLiteral(" class=\"btn btn-info\" style=\"color:#004D97\"><i class=\"zmdi zmdi-plus\"></i> &nbsp; PERSONALES</a>\r\n        </div>\r\n\r\n        <div class=\"col-xs-12 col-sm-3\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 472, "\"", 516, 1);
#line 16 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Experience.cshtml"
WriteAttributeValue("", 479, Url.Action("Studies", "Inscription"), 479, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(517, 190, true);
            WriteLiteral(" class=\"btn btn-success\" style=\"color:#004D97\"><i class=\"zmdi zmdi-format-list-bulleted\"></i> &nbsp; FORMACIÓN</a>\r\n        </div>\r\n\r\n        <div class=\"col-xs-12 col-sm-3\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 707, "\"", 754, 1);
#line 20 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Experience.cshtml"
WriteAttributeValue("", 714, Url.Action("Experience", "Inscription"), 714, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(755, 178, true);
            WriteLiteral(" class=\"btn btn-primary\" style=\"color:#004D97\"><i class=\"zmdi zmdi-search\"></i> &nbsp; EXPERIENCIA</a>\r\n        </div>\r\n\r\n        <div class=\"col-xs-12 col-sm-3\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 933, "\"", 978, 1);
#line 24 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Experience.cshtml"
WriteAttributeValue("", 940, Url.Action("Document", "Inscription"), 940, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(979, 463, true);
            WriteLiteral(@" class=""btn btn-danger"" style=""color:#004D97""><i class=""zmdi zmdi-comment-list""></i> &nbsp; OTROS DOCUMENTOS</a>
        </div>

        <div class=""container-fluid"">
            <div class=""page-header"">
                <h1 class=""text-titles""><i class=""zmdi zmdi-account zmdi-hc-fw""></i> <small>Experiencia Laboral</small></h1>
            </div>
        </div>



        <div class=""container-fluid"">
            <div class=""panel panel-info"">

");
            EndContext();
#line 38 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Experience.cshtml"
                 using (Html.BeginForm("Guardarlo", "Inscription", FormMethod.Post))
                {

                    

#line default
#line hidden
            BeginContext(1570, 23, false);
#line 41 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Experience.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1597, 325, true);
            WriteLiteral(@"                    <fieldset>



                        <div class=""container-fluid"">
                            <div class=""row"">

                                <div class=""col-xs-12 col-sm-6"">
                                    <div class=""form-group label-floating"">
                                        ");
            EndContext();
            BeginContext(1923, 91, false);
#line 52 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Experience.cshtml"
                                   Write(Html.LabelFor(model => model.Companyname, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(2014, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(2057, 76, false);
#line 53 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Experience.cshtml"
                                   Write(Html.TextBoxFor(model => model.Companyname, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2133, 271, true);
            WriteLiteral(@"
                                    </div>
                                </div>

                                <div class=""col-xs-12 col-sm-6"">
                                    <div class=""form-group label-floating"">
                                        ");
            EndContext();
            BeginContext(2405, 88, false);
#line 59 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Experience.cshtml"
                                   Write(Html.LabelFor(model => model.Position, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(2493, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(2536, 73, false);
#line 60 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Experience.cshtml"
                                   Write(Html.TextBoxFor(model => model.Position, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2609, 271, true);
            WriteLiteral(@"
                                    </div>
                                </div>

                                <div class=""col-xs-12 col-sm-6"">
                                    <div class=""form-group label-floating"">
                                        ");
            EndContext();
            BeginContext(2881, 92, false);
#line 66 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Experience.cshtml"
                                   Write(Html.LabelFor(model => model.Idworkstatus, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(2973, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(3016, 108, false);
#line 67 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Experience.cshtml"
                                   Write(Html.DropDownListFor(model => model.Idworkstatus, Model.WorkStatusList, "", new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3124, 190, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n\r\n                                <div class=\"col-xs-12 col-sm-6\">\r\n                                    ");
            EndContext();
            BeginContext(3315, 93, false);
#line 72 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Experience.cshtml"
                               Write(Html.LabelFor(model => model.initialperiod, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(3408, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(3447, 117, false);
#line 73 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Experience.cshtml"
                               Write(Html.TextBoxFor(model => model.initialperiod, new { @class = "form-control", required = "required", @type = "Date" }));

#line default
#line hidden
            EndContext();
            BeginContext(3564, 227, true);
            WriteLiteral("\r\n                                </div>\r\n\r\n                                <div class=\"col-xs-12 col-sm-6\">\r\n                                    <div class=\"form-group label-floating\">\r\n                                        ");
            EndContext();
            BeginContext(3792, 89, false);
#line 78 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Experience.cshtml"
                                   Write(Html.LabelFor(model => model.Endperiod, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(3881, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(3924, 113, false);
#line 79 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Experience.cshtml"
                                   Write(Html.TextBoxFor(model => model.Endperiod, new { @class = "form-control", required = "required", @type = "Date" }));

#line default
#line hidden
            EndContext();
            BeginContext(4037, 271, true);
            WriteLiteral(@"
                                    </div>
                                </div>

                                <div class=""col-xs-12 col-sm-6"">
                                    <div class=""form-group label-floating"">
                                        ");
            EndContext();
            BeginContext(4309, 93, false);
#line 85 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Experience.cshtml"
                                   Write(Html.LabelFor(model => model.Inmediateboss, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(4402, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(4445, 78, false);
#line 86 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Experience.cshtml"
                                   Write(Html.TextBoxFor(model => model.Inmediateboss, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(4523, 271, true);
            WriteLiteral(@"
                                    </div>
                                </div>

                                <div class=""col-xs-12 col-sm-6"">
                                    <div class=""form-group label-floating"">
                                        ");
            EndContext();
            BeginContext(4795, 100, false);
#line 92 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Experience.cshtml"
                                   Write(Html.LabelFor(model => model.Inmediatechiefnumbre, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(4895, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(4938, 85, false);
#line 93 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Experience.cshtml"
                                   Write(Html.TextBoxFor(model => model.Inmediatechiefnumbre, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(5023, 591, true);
            WriteLiteral(@"
                                    </div>
                                </div>

                                <div class=""col-xs-12 col-sm-6"">
                                    <div class=""form-group label-floating"">
                                        <label for=""Document"">Adjunte Certificado</label>
                                        <input type=""file"" class=""form-control"">
                                    </div>
                                </div>

                            </div>
                        </div>
                    </fieldset>
");
            EndContext();
            BeginContext(5616, 277, true);
            WriteLiteral(@"                    <div class=""text-center"">
                        <div class=""margin-top: 20px"">
                            <input type=""submit"" value=""Guardarlo"" class=""btn btn-primary btn-bordred btn-sm"" />
                        </div>
                    </div>
");
            EndContext();
            BeginContext(5895, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5917, "\"", 5964, 1);
#line 114 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Experience.cshtml"
WriteAttributeValue("", 5924, Url.Action("EmploymentListing", "List"), 5924, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5965, 135, true);
            WriteLiteral(" button type=\"button\" class=\"btn btn-outline-primary btn-rounded w-md waves-effect waves-light m-b-5\" style=\"color:#ffffff\">Lista</a>\r\n");
            EndContext();
#line 115 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\Inscription\Experience.cshtml"
                }

#line default
#line hidden
            BeginContext(6119, 68, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PastoralEmpleo.ViewModel.ExperienceInformationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

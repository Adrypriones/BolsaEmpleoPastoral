#pragma checksum "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\List\EmploymentListing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16c12be1705275297f276192e7c3f0efa27c56f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_List_EmploymentListing), @"mvc.1.0.view", @"/Views/List/EmploymentListing.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/List/EmploymentListing.cshtml", typeof(AspNetCore.Views_List_EmploymentListing))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16c12be1705275297f276192e7c3f0efa27c56f4", @"/Views/List/EmploymentListing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"928166129b11b939891901ba6c4b6f1f2c82cf50", @"/Views/_ViewImports.cshtml")]
    public class Views_List_EmploymentListing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PastoralEmpleo.Models.Experience>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\List\EmploymentListing.cshtml"
  
    ViewData["Title"] = "EmploymentListing";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(154, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(158, 4413, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef79b9a2563d40f8b7463dd13febc605", async() => {
                BeginContext(164, 1211, true);
                WriteLiteral(@"

    <section>

        <div class=""container-fluid"">
            <div class=""page-header"">
                <h1 class=""text-titles""><i class=""zmdi zmdi-account zmdi-hc-fw""></i> <small>Listado Empleo</small></h1>
            </div>
        </div>


        
        <section>            

            <div class=""container-fluid"">
                <div class=""panel panel-success"">

                    <div class=""panel-body"">
                        <div class=""table-responsive"">
                            <table class=""table table-hover text-center"">
                                <thead>
                                    <tr>
                                        <th class=""text-center"">EMPRESA</th>
                                        <th class=""text-center"">CARGO</th>
                                        <th class=""text-center"">INGRESO</th>
                                        <th class=""text-center"">SALIDA</th>
                                        <th class=""text-");
                WriteLiteral("center\">JEFE</th>\r\n                                        <th class=\"text-center\">TELÈFONO</th>\r\n\r\n                                    </tr>\r\n                                </thead>\r\n\r\n");
                EndContext();
#line 40 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\List\EmploymentListing.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
                BeginContext(1472, 132, true);
                WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
                EndContext();
                BeginContext(1605, 46, false);
#line 44 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\List\EmploymentListing.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Companyname));

#line default
#line hidden
                EndContext();
                BeginContext(1651, 139, true);
                WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
                EndContext();
                BeginContext(1791, 43, false);
#line 47 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\List\EmploymentListing.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Position));

#line default
#line hidden
                EndContext();
                BeginContext(1834, 139, true);
                WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
                EndContext();
                BeginContext(1974, 48, false);
#line 50 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\List\EmploymentListing.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Initialperiod));

#line default
#line hidden
                EndContext();
                BeginContext(2022, 139, true);
                WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
                EndContext();
                BeginContext(2162, 44, false);
#line 53 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\List\EmploymentListing.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Endperiod));

#line default
#line hidden
                EndContext();
                BeginContext(2206, 139, true);
                WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
                EndContext();
                BeginContext(2346, 48, false);
#line 56 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\List\EmploymentListing.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Inmediateboss));

#line default
#line hidden
                EndContext();
                BeginContext(2394, 139, true);
                WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
                EndContext();
                BeginContext(2534, 55, false);
#line 59 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\List\EmploymentListing.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Inmediatechiefnumbre));

#line default
#line hidden
                EndContext();
                BeginContext(2589, 288, true);
                WriteLiteral(@"
                                        </td>
                                        <td>
                                            <ul class=""breadcrumb breadcrumb-tabs"">
                                                <li>
                                                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2877, "\"", 2954, 1);
#line 64 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\List\EmploymentListing.cshtml"
WriteAttributeValue("", 2884, Url.Action("Experience", "Inscription", new { id=item.Idexperience }), 2884, 70, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2955, 245, true);
                WriteLiteral(" class=\"btn btn-success btn-rounded small\" style=\"color:#000000\">\r\n                                                        Editar\r\n                                                    </a>\r\n\r\n                                                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3200, "\"", 3277, 1);
#line 68 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\List\EmploymentListing.cshtml"
WriteAttributeValue("", 3207, Url.Action("Experience", "Inscription", new { id=item.Idexperience }), 3207, 70, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3278, 245, true);
                WriteLiteral(" class=\"btn btn-custom btn-rounded small\" style=\"color:#000000\">\r\n                                                        Agregar\r\n                                                    </a>\r\n\r\n                                                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3523, "\"", 3600, 1);
#line 72 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\List\EmploymentListing.cshtml"
WriteAttributeValue("", 3530, Url.Action("Experience", "Inscription", new { id=item.Idexperience }), 3530, 70, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3601, 435, true);
                WriteLiteral(@" class=""btn btn-danger btn-rounded small"" style=""color:#000000"">
                                                        Eliminar
                                                    </a>

                                                </li>                                             

                                            </ul>
                                        </td>
                                    </tr>
");
                EndContext();
#line 81 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\List\EmploymentListing.cshtml"
                                }

#line default
#line hidden
                BeginContext(4071, 179, true);
                WriteLiteral("\r\n\r\n                            </table>\r\n                            \r\n                                <div class=\"col-sm-12 text-right\">\r\n                                     <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4250, "\"", 4294, 1);
#line 87 "C:\Proyect\BolsaEmpleoPastoral\PastoralEmpleo\Views\List\EmploymentListing.cshtml"
WriteAttributeValue("", 4257, Url.Action("Studies", "Inscription"), 4257, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4295, 269, true);
                WriteLiteral(@" class=""text-primary m-l-5""><b>Siguiente</b></a></p>
                                </div>
                            
                        </div>

                    </div>

                </div>
            </div>
        </section>
   </section>

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
            BeginContext(4571, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PastoralEmpleo.Models.Experience>> Html { get; private set; }
    }
}
#pragma warning restore 1591

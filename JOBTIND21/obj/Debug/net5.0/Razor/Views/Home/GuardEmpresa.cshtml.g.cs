#pragma checksum "C:\Users\Josss_k4ptalp\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "781629af0661f2d4242b9ae0b04a3877720f59da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GuardEmpresa), @"mvc.1.0.view", @"/Views/Home/GuardEmpresa.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Josss_k4ptalp\Documents\GitHub\JOBTIND21\JOBTIND21\Views\_ViewImports.cshtml"
using JOBTIND21;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Josss_k4ptalp\Documents\GitHub\JOBTIND21\JOBTIND21\Views\_ViewImports.cshtml"
using JOBTIND21.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"781629af0661f2d4242b9ae0b04a3877720f59da", @"/Views/Home/GuardEmpresa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d0ec2803711a05f97201b5028a1f592ff90dc1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GuardEmpresa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JOBTIND21.Dominio.Empresa>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Josss_k4ptalp\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
  
    ViewData["Title"] = "GuardEmpresa";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 style=""color: royalblue"" class="" animate__animated animate__fadeInUp"">GuardEmpresa</h1>

<link rel=""stylesheet""
      href=""https://kit.fontawesome.com/ffd11ebe0f.js"" crossorigin=""anonymous"" />

<link rel=""stylesheet""
      href=""https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css"" />

<link rel=""stylesheet""
      href=""https://cdnjs.cloudflare.com/ajax/libs/wow/1.1.2/wow.js>"" />

<script src=""https://kit.fontawesome.com/ffd11ebe0f.js"" crossorigin=""anonymous""></script>

");
#nullable restore
#line 20 "C:\Users\Josss_k4ptalp\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
 using (Html.BeginForm("GuardEmpresa", "Home", FormMethod.Post))
{



#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <h2 style=""color: royalblue"" class="" animate__animated animate__fadeInUp"">Bienvenido, Ingrese los datos de la empresa para registrarla</h2>
    <br>
    <i class=""fas fa-globe""></i>
    <label class="" animate__animated animate__fadeInUp"">Nombre de empresa</label>
    <br />
");
#nullable restore
#line 29 "C:\Users\Josss_k4ptalp\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
Write(Html.TextBoxFor(m => m.Nombre_Empresa));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Josss_k4ptalp\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
Write(Html.ValidationMessageFor(m => m.Nombre_Empresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n    <i class=\"fas fa-phone-square-alt\"></i>\r\n    <label class=\" animate__animated animate__fadeInUp\">Telefono</label>\r\n    <br />\r\n");
#nullable restore
#line 36 "C:\Users\Josss_k4ptalp\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
Write(Html.TextBoxFor(m => m.TelefonoEmp));

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Josss_k4ptalp\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
Write(Html.ValidationMessageFor(m => m.TelefonoEmp));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n    <i class=\"fas fa-at\"></i>\r\n    <label class=\" animate__animated animate__fadeInUp\">Email</label>\r\n    <br />\r\n");
#nullable restore
#line 43 "C:\Users\Josss_k4ptalp\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
Write(Html.TextBoxFor(m => m.EmailEmp));

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Josss_k4ptalp\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
Write(Html.ValidationMessageFor(m => m.EmailEmp));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n");
            WriteLiteral("    <i class=\"fas fa-lock\"></i>\r\n    <label class=\" animate__animated animate__fadeInUp\">Contraseña</label>\r\n    <br />\r\n");
#nullable restore
#line 51 "C:\Users\Josss_k4ptalp\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
Write(Html.TextBoxFor(m => m.ContraseñaEmp));

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\Josss_k4ptalp\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
Write(Html.ValidationMessageFor(m => m.ContraseñaEmp));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n");
            WriteLiteral("    <i class=\"far fa-newspaper\"></i>\r\n    <label class=\" animate__animated animate__fadeInUp\">Vacante</label>\r\n    <br />\r\n");
#nullable restore
#line 59 "C:\Users\Josss_k4ptalp\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
Write(Html.TextBoxFor(m => m.Vacante));

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\Josss_k4ptalp\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
Write(Html.ValidationMessageFor(m => m.Vacante));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n");
            WriteLiteral("    <i class=\"fas fa-th-list\"></i>\r\n    <label class=\" animate__animated animate__fadeInUp\">Categoria</label>\r\n    <br />\r\n");
#nullable restore
#line 67 "C:\Users\Josss_k4ptalp\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
Write(Html.TextBoxFor(m => m.CategoriaID));

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\Josss_k4ptalp\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
Write(Html.ValidationMessageFor(m => m.CategoriaID));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n    <input type=\"submit\" class=\"btn btn-outline-danger animate__animated animate__jello \">\r\n    <br>\r\n");
#nullable restore
#line 73 "C:\Users\Josss_k4ptalp\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2 class=\"wow animate__animated animate__pulse\" data-wow-duration=\"2s\" data-wow-delay=\"2s\">Guardar</h2>\r\n<script src=\"https://cdn.boomcdn.com/libs/wow-js/1.3.0/wow.js\"></script>\r\n<script type=\"text/javascript\">\r\n    new WOW().init();\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JOBTIND21.Dominio.Empresa> Html { get; private set; }
    }
}
#pragma warning restore 1591

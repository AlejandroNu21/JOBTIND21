#pragma checksum "C:\Users\Vkaiido\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b0ff96fcb1fa014a3b9e5962e1f78befa779dc4"
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
#line 1 "C:\Users\Vkaiido\Documents\GitHub\JOBTIND21\JOBTIND21\Views\_ViewImports.cshtml"
using JOBTIND21;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vkaiido\Documents\GitHub\JOBTIND21\JOBTIND21\Views\_ViewImports.cshtml"
using JOBTIND21.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b0ff96fcb1fa014a3b9e5962e1f78befa779dc4", @"/Views/Home/GuardEmpresa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d0ec2803711a05f97201b5028a1f592ff90dc1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GuardEmpresa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JOBTIND21.Dominio.Empresa>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Vkaiido\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
  
    ViewData["Title"] = "GuardEmpresa";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>GuardEmpresa</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Vkaiido\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
 using (Html.BeginForm("GuardEmpresa", "Home", FormMethod.Post))
{



#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2 class=\" animate__animated animate__bounce\">Bienvenido, Ingrese los datos de la empresa para registrarla</h2>\r\n    <br>\r\n    <i class=\"fas fa-book\"></i>\r\n    <label>Nombre de empresa</label>\r\n    <br />\r\n");
#nullable restore
#line 18 "C:\Users\Vkaiido\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
Write(Html.TextBoxFor(m => m.Nombre_Empresa));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Vkaiido\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
Write(Html.ValidationMessageFor(m => m.Nombre_Empresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n    <i class=\"far fa-star\"></i>\r\n    <br />\r\n    <label>Telefono</label>\r\n    <br />\r\n");
#nullable restore
#line 26 "C:\Users\Vkaiido\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
Write(Html.TextBoxFor(m => m.TelefonoEmp));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Vkaiido\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
Write(Html.ValidationMessageFor(m => m.TelefonoEmp));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n    <i class=\"fas fa-book\"></i>\r\n    <label>Email</label>\r\n    <br />\r\n");
#nullable restore
#line 33 "C:\Users\Vkaiido\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
Write(Html.TextBoxFor(m => m.EmailEmp));

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Vkaiido\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
Write(Html.ValidationMessageFor(m => m.EmailEmp));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n");
            WriteLiteral("    <i class=\"fas fa-book\"></i>\r\n    <label>Contraseña</label>\r\n    <br />\r\n");
#nullable restore
#line 41 "C:\Users\Vkaiido\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
Write(Html.TextBoxFor(m => m.ContraseñaEmp));

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Vkaiido\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
Write(Html.ValidationMessageFor(m => m.ContraseñaEmp));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n");
            WriteLiteral("    <i class=\"fas fa-book\"></i>\r\n    <label>Vacante</label>\r\n    <br />\r\n");
#nullable restore
#line 49 "C:\Users\Vkaiido\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
Write(Html.TextBoxFor(m => m.Vacante));

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\Vkaiido\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
Write(Html.ValidationMessageFor(m => m.Vacante));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n");
            WriteLiteral("    <i class=\"fas fa-book\"></i>\r\n    <label>Categoria</label>\r\n    <br />\r\n");
#nullable restore
#line 57 "C:\Users\Vkaiido\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
Write(Html.TextBoxFor(m => m.CategoriaID));

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\Vkaiido\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
Write(Html.ValidationMessageFor(m => m.CategoriaID));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n    <input type=\"submit\">\r\n    <br>\r\n");
#nullable restore
#line 63 "C:\Users\Vkaiido\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\GuardEmpresa.cshtml"
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

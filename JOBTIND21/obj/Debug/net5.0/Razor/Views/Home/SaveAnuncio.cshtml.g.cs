#pragma checksum "C:\Users\Vkaiido\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\SaveAnuncio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e98ed9aa42207e406d4eae001744cfcc93bdfc55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SaveAnuncio), @"mvc.1.0.view", @"/Views/Home/SaveAnuncio.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e98ed9aa42207e406d4eae001744cfcc93bdfc55", @"/Views/Home/SaveAnuncio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d0ec2803711a05f97201b5028a1f592ff90dc1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SaveAnuncio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JOBTIND21.Dominio.Anuncio>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Vkaiido\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\SaveAnuncio.cshtml"
  
    ViewData["Title"] = "SaveAnuncio";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet""
      href=""https://kit.fontawesome.com/ffd11ebe0f.js"" crossorigin=""anonymous"" />

<link rel=""stylesheet""
      href=""https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css"" />

<link rel=""stylesheet""
      href=""https://cdnjs.cloudflare.com/ajax/libs/wow/1.1.2/wow.js>"" />

<script src=""https://kit.fontawesome.com/ffd11ebe0f.js"" crossorigin=""anonymous""></script>



");
#nullable restore
#line 20 "C:\Users\Vkaiido\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\SaveAnuncio.cshtml"
 using (Html.BeginForm("SaveAnuncio", "Home", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""text-center"">
        <h1 style=""color: cornflowerblue"" class="" animate__animated animate__jello"">Registro de Datos</h1>
        <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css"" />


        <style>
            h1 {
                font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
                font-size: 35px;
                color: firebrick
            }
        </style>
    </div>
    <div class=""form-group col-md-8"">
        <label style=""color: salmon"">Anuncio</label>
        <br />
        <i class=""fa fa-bullhorn""></i>
        ");
#nullable restore
#line 39 "C:\Users\Vkaiido\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\SaveAnuncio.cshtml"
   Write(Html.TextBoxFor(m => m.Anuncios));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 40 "C:\Users\Vkaiido\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\SaveAnuncio.cshtml"
   Write(Html.ValidationMessageFor(m => m.Anuncios));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n\r\n        <label style=\"color: salmon\">Usuario</label>\r\n        <br />\r\n        <i class=\"fa fa-user\"></i>\r\n        ");
#nullable restore
#line 46 "C:\Users\Vkaiido\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\SaveAnuncio.cshtml"
   Write(Html.TextBoxFor(m => m.UsuarioID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 47 "C:\Users\Vkaiido\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\SaveAnuncio.cshtml"
   Write(Html.ValidationMessageFor(m => m.UsuarioID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        <br />\r\n        <label style=\"color: salmon\">Codigo Id de Empresa</label>\r\n        <br />\r\n        <i class=\"fa fa-id-badge\"></i>\r\n        ");
#nullable restore
#line 53 "C:\Users\Vkaiido\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\SaveAnuncio.cshtml"
   Write(Html.TextBoxFor(m => m.EmpresaID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 54 "C:\Users\Vkaiido\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\SaveAnuncio.cshtml"
   Write(Html.ValidationMessageFor(m => m.EmpresaID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        <br />\r\n        <br />\r\n        <i class=\"far fa-save fa-2x\"></i>\r\n        <input type=\"submit\" class=\"btn btn-outline-success animate_animated animate_backInDown\">\r\n        <br>\r\n    </div>\r\n");
#nullable restore
#line 62 "C:\Users\Vkaiido\Documents\GitHub\JOBTIND21\JOBTIND21\Views\Home\SaveAnuncio.cshtml"
 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JOBTIND21.Dominio.Anuncio> Html { get; private set; }
    }
}
#pragma warning restore 1591

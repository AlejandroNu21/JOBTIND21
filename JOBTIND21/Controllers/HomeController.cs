using JOBTIND21.Dominio;
using JOBTIND21.Models;
using JOBTIND21.Servicio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JOBTIND21.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IUsuario iusuario;
        private IEmpresa iempresa;
        private IAnuncio ianuncio;

        public HomeController(ILogger<HomeController> logger, IUsuario iusuario, IEmpresa iempresa, IAnuncio ianuncio)
        {
            this.iusuario = iusuario;
            this.iempresa = iempresa;
            this.ianuncio = ianuncio;
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Usuario usuario = new Usuario();
            //usuario.Nombres = "Carlos";
            //usuario.Apellidos = "Nuñez";
            //usuario.Edad = 21;
            //usuario.DUI = "06136652-4";
            //usuario.Telefono = "7726-5432";
            //usuario.Email = "kaidovasquez@gmail.com";
            //usuario.Contraseña = "Anitalahuerfanita";
            //iusuario.Insertar(usuario);
            return View();


        }

        public IActionResult Guardar()
        {
            return View();
        }

        public IActionResult Guardado(Usuario c)
        {
            if (ModelState.IsValid)
            {
                iusuario.Insertar(c);
                return View();
            }
            else
            {
                return View("Guardado", c);
            }
           
        }

        public IActionResult Guard()
        {
            return View();
        }

        public IActionResult GuardEmpresa(Empresa E)
        {
            if (ModelState.IsValid)
            {
                iempresa.Guardar(E);
                return View();
            }
            else
            {
                return View("GuardEmpresa", E);
            }
        }

        public IActionResult Save()
        {
            return View();
        }

        public IActionResult SaveAnuncio(Anuncio a)
        {
            if (ModelState.IsValid)
            {
                ianuncio.Save(a);
                return View();
            }
            else
            {
                return View("SaveAnuncio", a);
            }
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

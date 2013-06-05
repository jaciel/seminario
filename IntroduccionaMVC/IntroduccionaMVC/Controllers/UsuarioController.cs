using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntroduccionaMVC.Models;
namespace IntroduccionaMVC.Controllers
{
    public class UsuarioController : Controller
    {
        //
        // GET: /Usuario/


        public ViewResult Index(string id)
        {
            ViewBag.nombre = "servidor" + id;
            return View();
        }
        public ViewResult registro()
        {
            return View();
        }
        [HttpPost]

        public RedirectResult registro (UsuarioModelView usuario)
        {
            usuario.nombre= "Servidor" + usuario.nombre;
            usuario.apellido = "Servidor" + usuario.apellido;
            usuario.email = "Servidor" + usuario.email;
            return RedirectToAction("mostrar");
            return View();
        }
        public ViewResult mostrar(UsuarioModelView usuario)
        {
         return View(usuario);
        }



    }
}

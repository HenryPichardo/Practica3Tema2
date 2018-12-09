using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_Propuesto_Diplomado_Web_MVC_UASD.Models;


namespace Proyecto_Propuesto_Diplomado_Web_MVC_UASD.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var personas = new List<Persona>
            {
                new Persona { Nombre = "Gleidys", Apellido = "Torres", Cedula = "000-0000000-0", Telefono = "000-000-0000" },
                new Persona { Nombre = "Brayan", Apellido = "Torres", Cedula = "000-0000000-0", Telefono = "000-000-0000" },
                new Persona { Nombre = "Hosseis", Apellido = "Pichardo", Cedula = "000-0000000-0", Telefono = "000-000-0000" },
                new Persona { Nombre = "Henry", Apellido = "Pichardo", Cedula = "000-0000000-0", Telefono = "000-000-0000" },

            };
            return View(personas);
        }
    }
}
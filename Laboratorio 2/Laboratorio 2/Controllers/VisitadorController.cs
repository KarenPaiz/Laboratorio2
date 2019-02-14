using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio_2.Models;

namespace Laboratorio_2.Controllers
{
    public class VisitadorController : Controller
    {
        // GET: Visitador
        List<Visitador> Visitadores = new List<Visitador>();
        static Visitador v1;
        [HttpPost]

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MostrarEmpleados()
        {
            Visitador[] Visi;
            Visi = Visitadores.ToArray();
            return View(Visi);
        }
        public ActionResult EmpleadosOficina()
        {

            return View(Visitadores);
        }
        public ActionResult EmpleadosTrabajando()
        {
            return View(Visitadores);
        }
        public ActionResult NuevoEmpleado()
        {
            return View();
        }
        public ActionResult Ingresa(string Nombre, int Codigo, int HoraLlegada)
        {
             v1 = new Visitador { Nombre = Nombre, Codigo = Codigo, HoraLlegada = HoraLlegada };
            Visitadores.Add(v1);
            return View();
        }
        public ActionResult BUSQUEDA ()
        {
            return View();
        }

    }
}
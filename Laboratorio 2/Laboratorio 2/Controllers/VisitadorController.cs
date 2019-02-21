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
        public static LinkedList<Visitador> Visitadores = new LinkedList<Visitador>();
        public static Stack<Visitador> PilaVisitadores = new Stack<Visitador>();
        public static Queue<Visitador> ColaVisitadores = new Queue<Visitador>();
        static Visitador v1;
        

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
        public ActionResult EmpleadosJornadaFinalizada()
        {
            Visitador[] Visi = new Visitador[20];
            int cont = 0;
            foreach (Visitador item in Visitadores)
            {
                if (item.Oficina== "Jornada terminada")
                {
                    Visi[cont] = item;
                }
            }
            return View(Visi);
        }
        public ActionResult EmpleadosTrabajando()
        {
            Visitador[] Visi;
            Visi = ColaVisitadores.ToArray();
            return View(Visi);
        }
        public ActionResult NuevoEmpleado()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ingresa(string Nombre, int Codigo, int HoraLlegada)
        {
            v1 = new Visitador { Nombre = Nombre, Codigo = Codigo, HoraLlegada = HoraLlegada };
            v1.Calcular();
            Visitadores.AddLast(v1);
            PilaVisitadores.Push(v1);
            return View();
        }
        public ActionResult BUSQUEDA ()
        {
            return View();
        }
        public ActionResult EnviarEmpleado()
        {
            Visitador v2 = new Visitador();
            try
            {
                v2 = PilaVisitadores.First<Visitador>();
            }
            catch { }
            return View(v2);
        }
        public ActionResult MetodoEnviarEmpleado()
        {
            Visitador v2 = new Visitador();
            try
            {
                v2 = PilaVisitadores.First<Visitador>();
                ColaVisitadores.Enqueue(v2);
                PilaVisitadores.Pop();
                foreach (Visitador item in Visitadores)
                {
                    if (v2.Nombre==item.Nombre)
                    {
                        item.Oficina = "Trabajando";
                        item.diponible = false;
                    }
                }
            }
            catch { }
            return View();
        }
        public ActionResult RegresarEmpleado()
        {
            Visitador v2 = new Visitador();
            try
            {
                v2 = ColaVisitadores.First<Visitador>();
            }
            catch { }
            return View(v2);
        }
        public ActionResult MetodoRegresarEmpleado()
        {
            Visitador v2 = new Visitador();
            try
            {
                v2 = ColaVisitadores.Dequeue();
                foreach (Visitador item in Visitadores)
                {
                    if (v2.Nombre == item.Nombre)
                    {
                        item.Oficina = "Jornada terminada";
                    }
                }
            }
            catch { }
            return View(v2);
        }
    }
}
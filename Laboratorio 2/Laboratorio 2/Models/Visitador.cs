using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio_2.Models
{
    
    public class Visitador
    {
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public int HoraLlegada { get; set; }
        public int NumCitas;
        public int HoraRegreso;
        public bool diponible = true;
        public int CantHoras;
        public float Sueldo;
        public Visitador ()
        {
            Random num = new Random();
            NumCitas = num.Next(0,4);
        }

        
    }
   
}

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
        public double HoraRegreso;
        public bool diponible = true;
        public double CantHoras;
        public double Sueldo;
        public string Oficina = "En oficina";
        public void Calcular ()
        {
            Random num = new Random();
            NumCitas = num.Next(0,4);
            CantHoras = 3 + (NumCitas * 1.5);
            HoraRegreso = HoraLlegada + CantHoras;
            Sueldo = CantHoras * 38;
            
        }

        
    }
   
}

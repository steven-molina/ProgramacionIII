using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pregrado : Estudiante
    {

        public string ProgramaPregrado { get; set; }
        public int Semestre { get; set; }
        public double PromedioCorte1 { get; set; }
        public double PromedioCorte2 { get; set; }
        public double PromedioCorte3 { get; set; }

        public Pregrado()
        {
        }

        public Pregrado(string tipo, int noDocuemnto, string nombre, string apellido, string programaPregrado, int semestre, double promedioCorte1, double promedioCorte2, double promedioCorte3) : base(tipo,noDocuemnto, nombre, apellido)
        {
            ProgramaPregrado = programaPregrado;
            PromedioCorte1 = promedioCorte1;
            PromedioCorte2 = promedioCorte2;
            PromedioCorte3 = promedioCorte3;
        }

        public override string ToString()
        {
            return $"{base.ToString()};{ProgramaPregrado};{Semestre};{PromedioCorte1};{PromedioCorte2};{PromedioCorte3}";

        }
    }
}

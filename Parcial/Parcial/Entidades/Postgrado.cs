using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Postgrado : Estudiante
    {
        
        public string ProgramaPostgrado { get; set; }
        public int Semestre { get; set; }
        public double PromedioSemestre { get; set; }

        public Postgrado()
        {
        }

        public Postgrado(string tipo, int noDocuemnto, string nombre, string apellido, string programaPostgrado, int semestre, double promedioSemestre) : base(tipo,noDocuemnto, nombre, apellido)
        {
            ProgramaPostgrado = programaPostgrado;
            PromedioSemestre = promedioSemestre;
        }

        public override string ToString()
        {
            return $"{base.ToString()};{ProgramaPostgrado};{Semestre};{PromedioSemestre}";
        }


    }
}

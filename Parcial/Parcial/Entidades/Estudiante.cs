using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiante
    {
        public string Tipo { get; set; }
        public int NoDocuemnto { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        

        public Estudiante()
        {
        }

        public Estudiante(string tipo, int noDocuemnto, string nombre, string apellido)
        {
            Tipo = tipo;
            NoDocuemnto = noDocuemnto;
            Nombre = nombre;
            Apellido = apellido;
        }

        public override string ToString()
        {
            return $"{Tipo};{NoDocuemnto};{Nombre};{Apellido}";
        }
    }
}

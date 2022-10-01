using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class ServiciosImp : Servicios
    {

        Archivo txt = new Archivo();
        

        public void EstudiantesDescatacados(string tipo, string programa)
        {
            txt.cargaDatos(1);
            txt.cargaDatos(2);
            var listaPregrado = txt.listaPregrado();
            var listaPostgrado = txt.listaPostgrado();
            double total = 0, promedio = 0,mayor=0;
            int indiceMayor = 0;
            int num = 0;
            if (tipo.Equals("PRE"))
            {
                for (int i = 0; i < listaPregrado.Count; i++)
                {
                    if (listaPregrado[i].ProgramaPregrado.Equals(programa))
                    {
                        total += 3 / (listaPregrado[i].PromedioCorte1 + listaPregrado[i].PromedioCorte2 + listaPregrado[i].PromedioCorte3);
                        if (total>mayor)
                        {
                            mayor = total;
                            indiceMayor = i;
                        }
                    }
                }
                Console.WriteLine($"Datos del estudiante destacado en el programa {programa}" +
                    $"\n - Tipo: {listaPregrado[indiceMayor].Tipo}" +
                    $"\n - NoDocumento: {listaPregrado[indiceMayor].NoDocuemnto}" +
                    $"\n - Nombre: {listaPregrado[indiceMayor].Nombre}" +
                    $"\n - Apellido: {listaPregrado[indiceMayor].Apellido}" +
                    $"\n - Programa: {listaPregrado[indiceMayor].ProgramaPregrado}" +
                    $"\n - Semestre: {listaPregrado[indiceMayor].Semestre}");
            }

            if (tipo.Equals("POST"))
            {
                for (int i = 0; i < listaPostgrado.Count; i++)
                {
                    if (listaPostgrado[i].ProgramaPostgrado.Equals(programa))
                    {
                        total = listaPostgrado[i].PromedioSemestre;
                        if (total > mayor)
                        {
                            mayor = total;
                            indiceMayor = i;
                        }
                    }
                }
                Console.WriteLine($"Datos del estudiante destacado en el programa {programa}" +
                    $"\n - Tipo: {listaPostgrado[indiceMayor].Tipo}" +
                    $"\n - NoDocumento: {listaPostgrado[indiceMayor].NoDocuemnto}" +
                    $"\n - Nombre: {listaPostgrado[indiceMayor].Nombre}" +
                    $"\n - Apellido: {listaPostgrado[indiceMayor].Apellido}" +
                    $"\n - Programa: {listaPostgrado[indiceMayor].ProgramaPostgrado}" +
                    $"\n - Semestre: {listaPostgrado[indiceMayor].Semestre}");
            }

        }
    
        public void EstudiantesPostgrado()
        {
            txt.leer(2);
        }

        public void EstudiantesPregado()
        {
            txt.leer(1);
        }

        public void PromedioGeneral(string tipo, string programa)
        {
            txt.cargaDatos(1);
            txt.cargaDatos(2);
            var listaPregrado = txt.listaPregrado();
            var listaPostgrado = txt.listaPostgrado();
            
            double total=0,promedio = 0;
            int num = 0;
            if (tipo.Equals("PRE"))
            {
                for(int i = 0; i < listaPregrado.Count; i++)
                {
                    if (listaPregrado[i].ProgramaPregrado.Equals(programa))
                    {
                        total += (listaPregrado[i].PromedioCorte1+ listaPregrado[i].PromedioCorte2+ listaPregrado[i].PromedioCorte3)/3;
                        num++;
                    }
                }
                promedio = total/num;
                Console.WriteLine($"El promedio general del programa {programa} es {promedio}");
            }
            
            if (tipo.Equals("POST"))
            {
                total = 0;
                for (int i = 0; i < listaPostgrado.Count; i++)
                {
                    if (listaPostgrado[i].ProgramaPostgrado.Equals(programa))
                    {
                        total += listaPostgrado[i].PromedioSemestre;
                        num++;
                    }
                }
                promedio = total/num;
                Console.WriteLine($"El promedio general del programa {programa} es {promedio}");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using Entidades;

namespace Datos
{
    public class Archivo
    {

        List<Pregrado> datos = new List<Pregrado>();
        List<Postgrado> datos2 = new List<Postgrado>();
        String ruta = "Registro-Academico.dat";

        public void guardar(String datos)
        {
            StreamWriter sr = new StreamWriter(ruta,true);    
            sr.WriteLine(datos);
            sr.Close();
        }

        public void leer(int opcion)
        {
            String line;

            try
            {
                if (opcion == 1)
                {
                    Console.WriteLine("\t\t\t\tESTUDIANTES DE PREGRADO");
                    Console.WriteLine("N°Documento\tNombresyApellidos\t\tPrograma Pregado\tSemestre\tNota 1\tNota 2\tNota 3");
                }
                if (opcion == 2)
                {
                    Console.WriteLine("\t\t\t\tESTUDIANTES DE POSTGRADO");
                    Console.WriteLine("N°Documento\tNombresyApellidos\t\tPrograma Postgrado\tSemestre\tPromedio");
                }
                StreamReader sr = new StreamReader(ruta, true);
                line = sr.ReadLine();
                while (line != null)
                {
                    String[] info = line.Split(';');
                    if(opcion==1)
                    {
                        if (info[0].Equals("PRE"))
                        {
                            
                            Console.WriteLine($"{info[1]}\t{info[2]} {info[3]}\t\t{info[4]}\t{info[5]}\t\t{info[6]}\t{info[7]}\t{info[8]}");
                            Pregrado pregrado = new Pregrado(info[0], int.Parse(info[1]), info[2], info[3], info[4], int.Parse(info[5]), int.Parse(info[6]), int.Parse(info[7]), int.Parse(info[8]));
                            datos.Add(pregrado);
                        }
                    }
                    if(opcion ==2)
                    {
                        if (info[0].Equals("POST"))
                        {
                            Console.WriteLine($"{info[1]}\t{info[2]} {info[3]}\t{info[4]}\t\t{info[5]}\t\t{info[6]}");
                            Postgrado postgrado = new Postgrado(info[0], int.Parse(info[1]), info[2], info[3], info[4], int.Parse(info[5]), int.Parse(info[6]));
                            datos2.Add(postgrado);
                        }
                    }

                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public void cargaDatos(int opcion)
        {
            String line;

            try
            {
                
                StreamReader sr = new StreamReader(ruta, true);
                line = sr.ReadLine();
                while (line != null)
                {
                    String[] info = line.Split(';');
                    if (opcion == 1)
                    {
                        if (info[0].Equals("PRE"))
                        {
                            Pregrado pregrado = new Pregrado(info[0], int.Parse(info[1]), info[2], info[3], info[4], int.Parse(info[5]), int.Parse(info[6]), int.Parse(info[7]), int.Parse(info[8]));
                            datos.Add(pregrado);
                        }
                    }
                    if (opcion == 2)
                    {
                        if (info[0].Equals("POST"))
                        {
                           Postgrado postgrado = new Postgrado(info[0], int.Parse(info[1]), info[2], info[3], info[4], int.Parse(info[5]), int.Parse(info[6]));
                            datos2.Add(postgrado);
                        }
                    }

                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public List<Pregrado> listaPregrado()
        {
            return datos;
        }

        public List<Postgrado> listaPostgrado()
        {
            return datos2;
        }

    }
}

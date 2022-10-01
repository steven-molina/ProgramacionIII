using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Logica;

namespace Presentacion
{
    public class main
    {
        static void Main(string[] args)
        {
            Postgrado postrado = new Postgrado(); 
            Pregrado pregrado = new Pregrado();
            ServiciosImp servicios = new ServiciosImp();

            string continuar = "", tipo = "", programa = "";
            int opcion = 0,opcionTipo = 0, opcionPrograma = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("================== MENU ===============");
                Console.WriteLine("1. ESTUDIANTES DE PREGRADO." +
                    "\n2. ESTUDIANTES DE POSTGRADO." +
                    "\n3. PROMEDIO POR PROGRAMA." +
                    "\n4. ESTUDIANTES DESCATADOS." +
                    "\n5. SALIR.");
                do
                {
                    Console.Write("- Ingrese una opcion(1-4): ");
                    opcion = int.Parse(Console.ReadLine());
                    if(opcion < 0 || opcion > 5)
                    {
                        Console.WriteLine("Ingrese una opcion valida");
                    }
                }while(opcion < 0 || opcion > 5);

                switch (opcion)
                {
                    case 1:
                        servicios.EstudiantesPregado();
                        break;
                    case 2:
                        servicios.EstudiantesPostgrado();
                        break;
                    case 3:
                        Console.WriteLine("TIPOS DE ESTUDIANTES" +
                            "\n1. Pregrado." +
                            "\n2. Postgrado.");
                        do
                        {
                            Console.Write("- Seleccione el tipo de estudiante(1-2): ");
                            opcionTipo = int.Parse(Console.ReadLine());
                            if (opcionTipo < 0 || opcionTipo > 2)
                            {
                                Console.WriteLine("Ingrese una opcion valida");
                            }
                        } while (opcionTipo < 0 || opcionTipo > 2);

                        switch (opcionTipo)
                        {
                            case 1:
                                tipo = "PRE";
                                break;
                            case 2:
                                tipo = "POST";
                                break;
                        }
                        
                        if(opcionTipo == 1)
                        {
                            Console.WriteLine("PROGRAMAS PREGRADO" +
                            "\n1. SISTEMAS." +
                            "\n2. DERECHO." +
                            "\n3. ENFERMERIA." +
                            "\n4. LICENCIATURA." +
                            "\n5. MUSICA.");
                            
                            do
                            {
                                Console.Write("- Seleccione el tipo de estudiante(1-5): ");
                                opcionPrograma = int.Parse(Console.ReadLine());
                                if (opcionPrograma < 0 || opcionPrograma > 5)
                                {
                                    Console.WriteLine("Ingrese una opcion valida");
                                }
                            } while (opcionPrograma < 0 || opcionPrograma > 5);

                            switch (opcionPrograma)
                            {
                                case 1:
                                    programa = "SISTEMAS";
                                    break;
                                case 2:
                                    programa = "DERECHO";
                                    break;
                                case 3:
                                    programa = "ENFERMERIA";
                                    break;
                                case 4:
                                    programa = "LICENCIATURA";
                                    break;
                                case 5:
                                    programa = "MUSICA";
                                    break;
                            }
                        }
                        if (opcionTipo == 2)
                        {
                            Console.WriteLine("PROGRAMAS POSTGRADO" +
                            "\n1. DESARROLLO SOFTWARE." +
                            "\n2. DERECHO ADMINISTRATIVO." +
                            "\n3. AUDITORIA EN SALUD.");

                            do
                            {
                                Console.Write("- Seleccione el tipo de estudiante(1-3): ");
                                opcionPrograma = int.Parse(Console.ReadLine());
                                if (opcionPrograma < 0 || opcionPrograma > 3)
                                {
                                    Console.WriteLine("Ingrese una opcion valida");
                                }
                            } while (opcionPrograma < 0 || opcionPrograma > 3);

                            switch (opcionPrograma)
                            {
                                case 1:
                                    programa = "DESARROLLO SOFTWARE";
                                    break;
                                case 2:
                                    programa = "DERECHO ADMINISTRATIVO";
                                    break;
                                case 3:
                                    programa = "AUDITORIA EN SALUD";
                                    break;
                            }
                        }

                        servicios.PromedioGeneral(tipo,programa);
                        break;
                    case 4:
                        Console.WriteLine("TIPOS DE ESTUDIANTES" +
                            "\n1. Pregrado." +
                            "\n2. Postgrado.");
                        do
                        {
                            Console.Write("- Seleccione el tipo de estudiante(1-2): ");
                            opcionTipo = int.Parse(Console.ReadLine());
                            if (opcionTipo < 0 || opcionTipo > 2)
                            {
                                Console.WriteLine("Ingrese una opcion valida");
                            }
                        } while (opcionTipo < 0 || opcionTipo > 2);

                        switch (opcionTipo)
                        {
                            case 1:
                                tipo = "PRE";
                                break;
                            case 2:
                                tipo = "POST";
                                break;
                        }

                        if (opcionTipo == 1)
                        {
                            Console.WriteLine("PROGRAMAS PREGRADO" +
                            "\n1. SISTEMAS." +
                            "\n2. DERECHO." +
                            "\n3. ENFERMERIA." +
                            "\n4. LICENCIATURA." +
                            "\n5. MUSICA.");

                            do
                            {
                                Console.Write("- Seleccione el tipo de estudiante(1-5): ");
                                opcionPrograma = int.Parse(Console.ReadLine());
                                if (opcionPrograma < 0 || opcionPrograma > 5)
                                {
                                    Console.WriteLine("Ingrese una opcion valida");
                                }
                            } while (opcionPrograma < 0 || opcionPrograma > 5);

                            switch (opcionPrograma)
                            {
                                case 1:
                                    programa = "SISTEMAS";
                                    break;
                                case 2:
                                    programa = "DERECHO";
                                    break;
                                case 3:
                                    programa = "ENFERMERIA";
                                    break;
                                case 4:
                                    programa = "LICENCIATURA";
                                    break;
                                case 5:
                                    programa = "MUSICA";
                                    break;
                            }
                        }
                        if (opcionTipo == 2)
                        {
                            Console.WriteLine("PROGRAMAS POSTGRADO" +
                            "\n1. DESARROLLO SOFTWARE." +
                            "\n2. DERECHO ADMINISTRATIVO." +
                            "\n3. AUDITORIA EN SALUD.");

                            do
                            {
                                Console.Write("- Seleccione el tipo de estudiante(1-3): ");
                                opcionPrograma = int.Parse(Console.ReadLine());
                                if (opcionPrograma < 0 || opcionPrograma > 3)
                                {
                                    Console.WriteLine("Ingrese una opcion valida");
                                }
                            } while (opcionPrograma < 0 || opcionPrograma > 3);

                            switch (opcionPrograma)
                            {
                                case 1:
                                    programa = "DESARROLLO SOFTWARE";
                                    break;
                                case 2:
                                    programa = "DERECHO ADMINISTRATIVO";
                                    break;
                                case 3:
                                    programa = "AUDITORIA EN SALUD";
                                    break;
                            }
                        }
                        servicios.EstudiantesDescatacados(tipo,programa);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }

                Console.Write("¿Desea continuar(s/n)?: ");
                continuar = Console.ReadLine();
            } while (continuar.Equals("s"));

        }
    }
}

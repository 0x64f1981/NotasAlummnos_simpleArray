using System;


namespace NotasAlummnos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ArregloNombres = new string[5];
            double[] ArregloNotas = new double[5];
            int i;
            string Estado;
            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine("Introduzca el nombre de la persona {0}", i+1);
                ArregloNombres[i] = Console.ReadLine();
                do
                {
                    Console.WriteLine("Introduzca la nota de {0}", ArregloNombres[i]);
                    ArregloNotas[i] = double.Parse(Console.ReadLine());
                    if (ArregloNotas[i] < 0)
                    {
                        Console.WriteLine("Nota incorrecta ingrésela de nuevo");
                    }
                }
                while (ArregloNotas[i] < 0 || ArregloNotas[i] > 10);
                Console.Clear();
            }
            Console.WriteLine("---LISTADO DE ALUMNOS CON SUS NOTAS Y ESTADOS-----\n");
            Console.WriteLine("{0,15} {1,5} {2,4} {3,5} {4,9}", "ALUMNO","-----", "NOTA", "-----", "ESTADO");
            for (i = 0;i<=4;i++)
            {
                if(ArregloNotas[i] >= 6.0)
                {
                    Estado = "Aprobado";
                }
                else
                {
                    Estado = "Reprobado";
                }
                Console.WriteLine("{0,15} {1,5} {2,4} {3,5} {4,9}", ArregloNombres[i], "-----", ArregloNotas[i], "-----", Estado);
            }
            Console.WriteLine("\n-----FIN LISTADO DE ALUMNOS CON SUS NOTAS-----\n");
            Console.WriteLine("Presione cualquier letra para continuar...");
            Console.ReadKey();
        }
    }
}

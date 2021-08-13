using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTeorica
{
    class PracticaEjercicio
    {
        static void Main(string[] args)
        {

            //Declarar y llenar array
            string[] Estudiantes = new string[5];
            string[] genero= new string [5];
            int[] edad = new int[5];

            int femenino = 0;
            int masculino = 0;
            //Solicitar nombre
            //Solocitar genero
            //Solicitar edad
                for (int i = 0; i < Estudiantes.Length; i++)
            {
                Console.WriteLine("Escriba el nombre del estudiante ");
                Console.Write("Nombre {0}: ", i);
                Estudiantes[i] = Console.ReadLine();
                Console.WriteLine("Seleccione el genero F/M ");
                Console.Write("Generó: ");
                genero[i] = Console.ReadLine();
                Console.WriteLine("Ingrese la edad del estudiante");
                Console.Write("Edad: ");
                edad[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Estudiantes[i], genero[i], edad[i]);
            }

            Console.WriteLine("Datos de los estudiantes: ");
            for (int i = 0; i < Estudiantes.Length; i++) 
            {
                Console.WriteLine("Nombre: {0}  l  Genero: {1} l Edad: {2}", Estudiantes[i], genero[i], edad[i]);

                if (genero[i]== "F")
                {

                    femenino += 1;

                }

                if (genero[i]=="M")
                {
                    masculino += 1;
                }
                Console.ReadKey();
            }
        }
    }
}

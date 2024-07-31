using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad__4
{
    internal class Program
    {
        /*Crea un programa que reciba la calificación numérica de un estudiante y muestre 
         * la letra equivalente de la calificación (A, B, C, D, F) utilizando la sentencia switch.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la calificación numérica (0-100): ");
            int calificacion = int.Parse(Console.ReadLine());

            char nota;

            // Determinar la letra de la calificación usando switch
            switch ((int)(calificacion / 10))
            {
                case 10:
                case 9:
                    nota = 'A';
                    break;

                case 8:
                    nota = 'B';
                    break;

                case 7:
                    nota = 'C';
                    break;

                case 6:
                    nota = 'D';
                    break;

                case 5:
                case 4:
                case 3:
                case 2:
                case 1:
                case 0:
                    nota = 'F';
                    break;

                default:
                    Console.WriteLine("\nCalificación no válida. Debe estar entre 0 y 100.");
                    return;
            }

            Console.WriteLine($"\nLa letra equivalente para la calificación {calificacion} es: {nota}");

            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
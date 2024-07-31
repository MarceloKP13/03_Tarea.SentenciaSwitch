using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Tarea.Sentencia.Switch
{
    internal class Program {

        /*Crea un programa que presente un menú de opciones al usuario utilizando la sentencia switch.
         * El menú debe permitir al usuario elegir entre diferentes opciones, como realizar una operación matemática, 
         * mostrar un mensaje o salir del programa.*/

        static void Main(string[] args)
        {
            Console.WriteLine("\t\t|| Menú de Opciones ||\n");
            Console.WriteLine("1. Realizar una operación matemática (Multiplicación)");
            Console.WriteLine("2. Mostrar un mensaje");
            Console.WriteLine("3. Salir del programa");
            Console.Write("Elige una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Introduce el primer número: ");
                    float numero1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Introduce el segundo número: ");
                    float numero2 = float.Parse(Console.ReadLine());

                    float resultado = numero1 * numero2;
                    Console.WriteLine($"\nEl resultado de la suma es: {resultado}");
                    break;

                case "2":
                    Console.WriteLine("\n¡Hola! Ten un buen día.");
                    break;

                case "3":
                    Console.WriteLine("\nSaliendo del programa...");
                    break;

                default:
                    Console.WriteLine("\nOpción no válida. Inténtalo de nuevo.");
                    break;
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

    }
}

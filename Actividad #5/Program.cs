using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad__5
{
    internal class Program
    {
        /*Escribe un programa que solicite al usuario el nombre de una fruta y muestre un mensaje indicando 
         * si la fruta es cítrica o no utilizando la sentencia switch y una lista de frutas cítricas.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el nombre de una fruta: ");
            string fruta = Console.ReadLine().ToLower(); // Convertir a minúsculas para hacer la comparación más sencilla

            // Determinar si la fruta es cítrica usando if-else
            if (fruta == "naranja" || fruta == "limon" || fruta == "mandarina" || fruta == "lima")
            {
                Console.WriteLine($"\nLa {fruta} | SI | es una fruta cítrica.");
            }
            else
            {
                Console.WriteLine($"\nLa {fruta} | NO | es una fruta cítrica.");
            }

            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

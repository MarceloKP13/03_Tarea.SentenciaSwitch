using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad__2
{
    internal class Program
    {
        /*Desarrolla un programa que solicite al usuario la longitud de los tres lados de un 
         * triángulo y luego clasifique el triángulo según su tipo (equilátero, isósceles, escaleno) 
         * utilizando la sentencia switch.*/
        static void Main(string[] args)
        {
            Console.Write("Introduce la longitud del primer lado: ");
            float lado1 = float.Parse(Console.ReadLine());
            Console.Write("Introduce la longitud del segundo lado: ");
            float lado2 = float.Parse(Console.ReadLine());
            Console.Write("Introduce la longitud del tercer lado: ");
            float lado3 = float.Parse(Console.ReadLine());


            string tipo;

            switch (true)
            {
                case bool _ when lado1 <= 0 || lado2 <= 0 || lado3 <= 0:
                    tipo = "Las longitudes de los lados deben ser positivas.";
                    break;

                case bool _ when (lado1 + lado2 <= lado3) || (lado1 + lado3 <= lado2) || (lado2 + lado3 <= lado1):
                    tipo = "Los lados proporcionados no forman un triángulo válido.";
                    break;

                case bool _ when lado1 == lado2 && lado2 == lado3:
                    tipo = "Equilátero";
                    break;

                case bool _ when lado1 == lado2 || lado1 == lado3 || lado2 == lado3:
                    tipo = "Isósceles";
                    break;

                default:
                    tipo = "Escaleno";
                    break;
            }

            Console.WriteLine($"\nEl triángulo es: {tipo}");

            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

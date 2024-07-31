using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad__8
{
    internal class Program
    {
        /*8.	Desarrolla un programa que calcule el precio final de un producto considerando un descuento por volumen. 
         * El programa debe solicitar al usuario la cantidad de unidades del producto y aplicar un descuento según la 
         * cantidad establecida. Utiliza la sentencia switch para determinar el descuento aplicable.*/
        static void Main(string[] args)
        {
            double precioUnitario = 57.99; 

            Console.WriteLine("Introduce la cantidad de unidades del producto: ");
            string cantidadInput = Console.ReadLine();
            int cantidad;

            // Validar la cantidad ingresada
            if (int.TryParse(cantidadInput, out cantidad) && cantidad > 0)
            {
                double descuento = 0;

                // Determinar el descuento basado en la cantidad
                switch (cantidad)
                {
                    case int n when (n >= 1 && n <= 10):
                        descuento = 0; // Sin descuento para 1-10 unidades
                        break;

                    case int n when (n >= 11 && n <= 50):
                        descuento = 0.10; // 10% de descuento para 11-50 unidades
                        break;

                    case int n when (n >= 51 && n <= 100):
                        descuento = 0.15; // 15% de descuento para 51-100 unidades
                        break;

                    case int n when (n > 100):
                        descuento = 0.20; // 20% de descuento para más de 100 unidades
                        break;

                    default:
                        Console.WriteLine("\nCantidad no válida.");
                        return;
                }

                // Calcular el precio final
                double precioFinal = precioUnitario * cantidad * (1 - descuento);

                // Mostrar el precio final
                Console.WriteLine($"\nCantidad de unidades: {cantidad}");
                Console.WriteLine($"\nDescuento aplicado: {descuento * 100}%");
                Console.WriteLine($"\nPrecio final: {precioFinal:C}");
            }
            else
            {
                Console.WriteLine("\nEntrada no válida. Debes ingresar un número entero positivo.");
            }

            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

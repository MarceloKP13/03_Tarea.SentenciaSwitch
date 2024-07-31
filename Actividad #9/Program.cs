using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad__9
{
    internal class Program
    {
        /*Crea un programa que simule una máquina expendedora. El programa debe mostrar 
         * un arreglo de productos con sus precios y permitir al usuario seleccionar un producto 
         * e ingresar el dinero correspondiente. Utiliza la sentencia switch para procesar la 
         * selección del producto, verificar el pago y entregar el producto simulado.*/
        static void Main(string[] args)
        {
            string[] productos = { "Refresco", "Chocolates", "Galletas", "Café" };
            double[] precios = { 1.50, 2.00, 1.00, 2.50 };

            // Mostrar los productos y precios
            Console.WriteLine("Productos disponibles:");
            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {productos[i]} - ${precios[i]:0.00}");
            }

            Console.Write("\nSelecciona el número del producto (1-4): ");
            string seleccionInput = Console.ReadLine();
            int seleccion;

            // Validar la selección
            if (int.TryParse(seleccionInput, out seleccion) && seleccion >= 1 && seleccion <= productos.Length)
            {
                int indiceProducto = seleccion - 1;
                double precioProducto = precios[indiceProducto];

                Console.Write($"Introduce el dinero correspondiente para {productos[indiceProducto]} (precio: ${precioProducto:0.00}): ");
                string dineroInput = Console.ReadLine();
                double dinero;

                // Validar el dinero ingresado
                if (double.TryParse(dineroInput, out dinero) && dinero >= precioProducto)
                {
                    double cambio = dinero - precioProducto;

                    // Procesar la selección y el pago
                    switch (seleccion)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                            Console.WriteLine($"\nHas seleccionado {productos[indiceProducto]}.");
                            Console.WriteLine($"Pago aceptado. Precio: ${precioProducto:0.00}.");
                            if (cambio > 0)
                            {
                                Console.WriteLine($"Cambio devuelto: ${cambio:0.00}");
                            }
                            Console.WriteLine("¡Gracias por tu compra!");
                            break;

                        default:
                            Console.WriteLine("Selección no válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Dinero insuficiente o no válido. La transacción ha sido cancelada.");
                }
            }
            else
            {
                Console.WriteLine("Selección no válida. Debes elegir un número entre 1 y 4.");
            }

            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

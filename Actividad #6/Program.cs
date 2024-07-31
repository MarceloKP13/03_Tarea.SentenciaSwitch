using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad__6
{
    internal class Program
    {
        /*Desarrolla un programa que simule un cajero automático. El programa debe solicitar al 
         * usuario lacantidad de dinero que desea retirar y verificar si tiene saldo suficiente. 
         * Si tiene saldo suficiente, se debe realizar la operación y actualizar el saldo. 
         * Utiliza la sentencia switch para controlar las diferentes opciones del cajero automático.*/
        static void Main(string[] args)
        {
            double saldo = 2500.00;

            Console.WriteLine("\t\tBienvenido al cajero automático");
            Console.WriteLine("\nSelecciona una opción:");
            Console.WriteLine("\n1. Consultar saldo");
            Console.WriteLine("\n2. Retirar dinero");
            Console.WriteLine("\n3. Salir");

            // Leer opción del usuario
            Console.Write("\nTu opción es: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    // Consultar saldo
                    Console.WriteLine($"\nTu saldo actual es: {saldo:C}");
                    break;

                case "2":
                    // Retirar dinero
                    Console.Write("\nIntroduce la cantidad a retirar: ");
                    string cantidadInput = Console.ReadLine();
                    double cantidad;

                    // Validar la cantidad ingresada
                    if (double.TryParse(cantidadInput, out cantidad))
                    {
                        if (cantidad > 0)
                        {
                            if (cantidad <= saldo)
                            {
                                saldo -= cantidad;
                                Console.WriteLine($"\nHas retirado {cantidad:C}. Tu nuevo saldo es: {saldo:C}");
                            }
                            else
                            {
                                Console.WriteLine("\nSaldo insuficiente para realizar esta operación.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nLa cantidad a retirar debe ser mayor que cero.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nCantidad no válida. Debe ingresar un número.");
                    }
                    break;

                case "3":
                    // Salir
                    Console.WriteLine("\nGracias por usar el cajero automático. ¡Hasta luego!");
                    break;

                default:
                    Console.WriteLine("\nOpción no válida. Por favor, elige una opción del menú.");
                    break;
            }

            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

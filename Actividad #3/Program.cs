    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad__3
{
    internal class Program
    {
        /*Escribe un programa que solicite al usuario un número que represente un día de la semana 
         * (1 para lunes, 2 para martes, etc.) y muestre el nombre completo del día correspondiente 
         * utilizando la sentencia switch.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número del 1 al 7 para representar un día de la semana: \n");
            string entrada = Console.ReadLine();

            // Convertir la entrada a número entero
            int dia = int.Parse(entrada);

            string nombreDia;

            // Clasificar el día de la semana usando switch
            switch (dia)
            {
                case 1:
                    nombreDia = "Lunes";
                    break;

                case 2:
                    nombreDia = "Martes";
                    break;

                case 3:
                    nombreDia = "Miércoles";
                    break;

                case 4:
                    nombreDia = "Jueves";
                    break;

                case 5:
                    nombreDia = "Viernes";
                    break;

                case 6:
                    nombreDia = "Sábado";
                    break;

                case 7:
                    nombreDia = "Domingo";
                    break;

                default:
                    nombreDia = "\nNúmero inválido. Por favor, introduce un número del 1 al 7.";
                    break;
            }

            Console.WriteLine($"\nEl día correspondiente es: {nombreDia}");

            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

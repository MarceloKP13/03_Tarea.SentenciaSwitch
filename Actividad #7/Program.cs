using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad__7
{
    
    internal class Program
    {
        /*Escribe un programa que solicite al usuario su edad y determine si tiene la edad 
     * suficiente para votar utilizando la sentencia switch. El programa debe mostrar un mensaje 
     * indicando si el usuario puede votar o no.*/
        static void Main(string[] args)
        {
            Console.Write("Por favor, ingresa tu edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nUsted tiene {edad} años.");

            // Determinar si la edad es suficiente para votar
            if (edad < 0 || edad > 122)
            {
                Console.WriteLine("\nIngrese una edad válida (entre 0 y 122 años).");
            }
            else
            {
                switch (edad)
                {
                    case int n when (n >= 16 && n <= 17):
                        Console.WriteLine("\nTiene la opción de VOTAR O NO hacerlo");
                        break;

                    case int n when (n >= 18 && n <= 64):
                        Console.WriteLine("\nEstá OBLIGADO a ejercer el voto");
                        break;

                    case int n when (n >= 65):
                        Console.WriteLine("\nTiene la opción de VOTAR O NO hacerlo");
                        break;

                    default:
                        Console.WriteLine("\nEs demasiado joven para votar");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}

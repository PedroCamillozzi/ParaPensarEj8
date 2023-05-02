using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaPensarEj8
{
    class Program
    {
        static void Main(string[] args)
        {
            int intentos = 0;
            string clave, claveCorrecta= "pepe123";
            while (intentos < 4)
            {
                Console.WriteLine("Ingrese la clave");
                clave = Console.ReadLine();
                if (clave == claveCorrecta)
                {
                    Console.WriteLine("Bienvenido");
                    Console.ReadKey();
                    break;
                    
                }
                else
                {
                    Console.WriteLine("Clave Fallida");
                    intentos++;
                }
            }
        }
    }
}

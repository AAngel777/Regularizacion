using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regularizacion
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.Write("Ingrese el nombre del producto: ");
                string producto = Console.ReadLine();

                Console.Write("Ingrese la cantidad que desea comprar: ");
                long cantidad = long.Parse(Console.ReadLine());

                Console.Write("Ingrese el precio del producto: ");
                float precio = float.Parse(Console.ReadLine());

                clase1 o1 = new clase1(producto, cantidad, precio); // creacion del objeto
                o1.escribe();
                o1.datos();    // ejecucion de metodos

                Console.WriteLine("Pulse enter para salir...");
                Console.ReadKey();
            }
            catch(FormatException e)
            {
                Console.WriteLine("Error: " + e.Message);
                Console.WriteLine("Ruta: " + e.StackTrace);  
                Console.WriteLine("Pulse enter para continuar...");
                Console.ReadKey();

            }


        }
    }
}

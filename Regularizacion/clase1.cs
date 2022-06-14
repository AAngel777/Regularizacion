using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Regularizacion
{
    class clase1
    {
        public string producto;      // atributos
        public long cantidad;
        public float precio;
        public clase1(string producto, long cantidad, float precio) // constructor que recibe parametros y los asigna con
        {
            this.producto = producto;
            this.cantidad = cantidad; // clausula this
            this.precio = precio;
        }
        
        public void escribe()
        {
            try
            {
                StreamWriter sw = new StreamWriter("Producto.txt", true); // creacion del objeto StreamWriter
                sw.WriteLine(producto);
                sw.WriteLine(cantidad);
                sw.WriteLine(precio);   // escritura en el archivo
                sw.Close(); // se cierra archivo
            }
            catch(IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
 
        }

        public void datos()
        {
            Console.WriteLine("DATOS DEL PRODUCTO"); 
            Console.WriteLine("Producto: " + producto);
            Console.WriteLine("Cantidad: " + cantidad);
            Console.WriteLine("Precio: {0:c} " , precio);
        }
    }
}

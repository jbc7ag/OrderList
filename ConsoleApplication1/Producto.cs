using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Producto
    {
        public string Nombre{ get; set; }
        public double Precio { get; set; }
        public string Descripcion { get; set; }

        public Producto(string aNombre, double aPrecio, string aDescripcio)
        {
            Nombre = aNombre;
            Precio = aPrecio;
            Descripcion = aDescripcio;
        }


         public static int comparaPrecios(Producto p1, Producto p2){
            
             //1 si es mayor 0 si es igual -1 si es menor

             if (p1.Precio > p2.Precio)
                 return 1;
             else if (p1.Precio < p2.Precio)
                 return -1;
             else if (p1.Precio == p2.Precio)
                 return 0;
             else
                 return -1; 

         }


    }
}

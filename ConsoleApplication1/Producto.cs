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
    }
}

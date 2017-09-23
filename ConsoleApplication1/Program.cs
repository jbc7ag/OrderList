using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Almacen al = new Almacen();
        }

        static Almacen CreaAlmace()
        {
            Almacen almacen = new Almacen();
            almacen.Add(new Producto("Vestido azul", 599.99, "Vestido fashion de poliester"));
            almacen.Add(new Producto("Camisa cotti", 1099.00, "Camisa de vestir"));

            return almacen;
        }
    }
}

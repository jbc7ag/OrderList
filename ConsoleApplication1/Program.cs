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
            Almacen almacen = CreaAlmace();

            ImprimeLista(almacen);

            Console.WriteLine("----Ordenada por nombre producto----");

            ImprimeListaOrdenadaNombre(almacen);

            Console.Read();
        }

        static Almacen CreaAlmace()
        {
            Almacen almacen = new Almacen();
            almacen.Add(new Producto("Vestido azul", 599.99, "Vestido fashion de poliester"));
            almacen.Add(new Producto("Camisa cotti", 1099.00, "Camisa de vestir"));
            almacen.Add(new Producto("Zapato vans", 799.99, "Zapatos hermosos"));
            almacen.Add(new Producto("Playera chida", 159.50, "Playera cool"));
            almacen.Add(new Producto("Sombrero", 355.99, "Sobrero fashion"));

            return almacen;
        }

        static void ImprimeLista(Almacen almacen)
        {
            foreach (var producto in almacen)
            {
                Console.WriteLine(producto.Nombre + " , " + producto.Precio);
            }
        }

        static void ImprimeListaOrdenadaNombre(Almacen almacen)
        {
            almacen.Sort(Producto.ComparaPorNombre);

            ImprimeLista(almacen);
        }

    }
}

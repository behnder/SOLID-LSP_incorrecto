using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LSP_incorrecto
{
    class Program
    {
        static void Main(string[] args)
        {
            ComidaSaludable comida = new Pizza();
            comida.PonerIngredientes(new string[] { "jamon", "cebolla", "cantimpalo" });
            comida.Cocinar();
            Console.ReadKey();
        }
    }
}

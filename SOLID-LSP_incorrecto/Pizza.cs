using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LSP_incorrecto
{
    class Pizza : ComidaSaludable
    {
        public override void PonerIngredientes(string[] ingredientes)
        {
            List<string> actualizarIngredientes = ingredientes.ToList();
            actualizarIngredientes.Add("Masa para pizza");
            actualizarIngredientes.Add("Mucho queso");
            actualizarIngredientes.Add("mucha salsa");
            foreach (var ingrediente in actualizarIngredientes)
            {
                Console.WriteLine(ingrediente + " ");
            }
        }
        public override void Cocinar()
        {
            Console.WriteLine("Cocinando una pizza bien cargada");
        }
    }
}

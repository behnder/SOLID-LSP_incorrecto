using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LSP_incorrecto
{
    class ComidaSaludable
    {
        public virtual void PonerIngredientes(String[] ingredientes) { }
        public virtual void Cocinar() { }
    }
}

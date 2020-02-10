using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    public class Automovil : Transporte
    {
        public Automovil(int cantPasaj) : base (cantPasaj, "Auto")
        {

        }

        public override string Avanzar()
        {
            return "Estoy avanzando como un auto";
        }

    }
}

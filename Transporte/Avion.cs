using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    public class Avion : Transporte
    {
        public Avion(int cantPasaj) : base(cantPasaj, "Avion") { 
        
        }
         
        public override string Avanzar()
        {
            return "Estoy avanzando como un avion";
        }

        public override string Detenerse()
        {
            return base.Detenerse() + " Muy despacio";
        }
    }
}

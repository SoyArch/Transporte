using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<Transporte> transportes = new List<Transporte>()
            {      
                new Automovil(2),
                new Automovil(3),
                new Automovil(6),
                new Automovil(1),
                new Automovil(5),
                new Avion(200),
                new Avion(300),
                new Avion(600),
                new Avion(1000),
                new Avion(500),
            };

            foreach (var item in transportes)
            {
                Console.Write("Soy un {0} con {1} pasajeros.", item.Tipo, item.CantPasajeros);

                Console.WriteLine("Prendo motor y {0}. Luego {1} y apago motor", item.Avanzar(), item.Detenerse());

                item.Saludar();

                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}

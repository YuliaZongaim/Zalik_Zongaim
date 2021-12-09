using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutable
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner andriy = new Owner("Andiy", "Petrneko", "097654321");
            Owner mykola = new Owner("Mykola", "Semeniuk", "0964124553");

            Car skoda = new Car(120, "Red", andriy);
            Car mercedes = new Car(230, "Black", mykola);

            List<Car> journal = new List<Car>();
            journal.Add(skoda);
            journal.Add(mercedes);

            Console.WriteLine("All car in journal");
            foreach (Car car in journal)
            {

                Console.WriteLine(car + "\n");

            }


            Console.ReadKey();
        }
    }
}

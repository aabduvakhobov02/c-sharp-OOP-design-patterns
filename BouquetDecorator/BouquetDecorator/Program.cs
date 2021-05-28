using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouquetDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IBouquetComponent a = new Bouquet();
            IBouquetComponent b = new RoseFlower(a);
            IBouquetComponent c = new TulipFlower(b);
            IBouquetComponent d = new OrchidFlower(c);
            IBouquetComponent e = new PeonyFlower(d);
            e.AddFlower();
            //Console.ReadKey();

            Console.WriteLine("Naive:");
            CreateNewBouquet();
            Console.ReadLine();

        }

        static void CreateNewBouquet()
        {
            string orchid = "Orchid";
            string peony = "Peony";
            string tulip = "Tulip";
            string rose = "Rose";

            Console.WriteLine("The bouquet:");
            StandardBouquet standardBouquet = new StandardBouquet(orchid, rose, peony, tulip);
            foreach (var property in standardBouquet.GetType().GetProperties())
            {
                Console.WriteLine($"{property.GetValue(standardBouquet, null)} has been added to the bouquet");
            }
        }
    }
}

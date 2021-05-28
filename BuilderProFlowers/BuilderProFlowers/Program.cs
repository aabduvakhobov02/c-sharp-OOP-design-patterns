using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderProFlowers
{
    class Program
    {
        static void Main(string[] args)
        {
            var bouquetCreator = new BouquetCreator(new RoseBouquet());
            bouquetCreator.CreateBouquet();
            var Bouquet = bouquetCreator.GetBouquet();
            Bouquet.ShowInfo();

            Console.WriteLine(" ");

            bouquetCreator = new BouquetCreator(new TulipBouquetBuilder());
            bouquetCreator.CreateBouquet();
            Bouquet = bouquetCreator.GetBouquet();
            Bouquet.ShowInfo();

            Console.WriteLine(" ");

            bouquetCreator = new BouquetCreator(new OrchidBouquetBuilder());
            bouquetCreator.CreateBouquet();
            Bouquet = bouquetCreator.GetBouquet();
            Bouquet.ShowInfo();


            Console.WriteLine();
            //Naive/Standard
            Console.WriteLine("Naive:");
            StandardBouquetBuilder standardBouquetBuilder = new StandardBouquetBuilder(
                "Rose Bouquet", "Rose", "Blue shiny paper", "Duct tape", "Myrtle");
            Console.WriteLine("Bouquet name: " + standardBouquetBuilder.BouquetName);
            Console.WriteLine("Main Flower: " + standardBouquetBuilder.MainFlower);
            Console.WriteLine("Material: " + standardBouquetBuilder.Material);
            Console.WriteLine("Tape: " + standardBouquetBuilder.Tape);
            Console.WriteLine("Filler Flower: " + standardBouquetBuilder.FillerFlower);
            Console.ReadLine();

        }
    }
}

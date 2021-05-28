using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderProFlowers
{
    public class Bouquet
    {
        public string BouquetName { get; set; }
        public string MainFlower { get; set; }
        public string Material { get; set; }
        public string Tape { get; set; }
        public string FillerFlower { get; set; }
        public List<string> AdditionalDetails { get; set; }

        public Bouquet()
        {
            AdditionalDetails = new List<string>();
        }

        public void ShowInfo()
        {

            Console.WriteLine("BouquetName: {0}", BouquetName);
            Console.WriteLine("MainFlower: {0}", MainFlower);
            Console.WriteLine("Material: {0}", Material);
            Console.WriteLine("Tape: {0}", Tape);
            Console.WriteLine("FillerFlower: {0}", FillerFlower);
            Console.WriteLine("AdditionalDetails: ");

            foreach (var details in AdditionalDetails)
            {
                Console.WriteLine(details);

            }





        }
    }
}

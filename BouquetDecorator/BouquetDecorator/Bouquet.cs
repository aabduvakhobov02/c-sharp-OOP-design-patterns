using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouquetDecorator
{
    public class Bouquet : IBouquetComponent
    {
        public void AddFlower()
        {
            Console.WriteLine("The Bouquet:");
        }
    }


    //NAIVE
    public class StandardBouquet
    {
        
        public string FirstFlower { get; set; }
        public string SecondFlower { get; set; }
        public string ThirdFlower { get; set; }
        public string FourthFlower { get; set; }

        //constructor for mix of 4 flowers
        public StandardBouquet(string firstF, string secondF, string thirdF, string fourthF)
            {
            FirstFlower = firstF;
            SecondFlower = secondF;
            ThirdFlower = thirdF;
            FourthFlower = fourthF;
            }
        //constructor for mix of 3 flowers
        public StandardBouquet(string firstF, string secondF, string thirdF)
        {
            FirstFlower = firstF;
            SecondFlower = secondF;
            ThirdFlower = thirdF;
        }

        //constructor for mix of 2 flowers
        public StandardBouquet(string firstF, string secondF)
        {
            FirstFlower = firstF;
            SecondFlower = secondF;
        }

        //constructor for 1 flower
        public StandardBouquet(string firstF)
        {
            FirstFlower = firstF;
        }

    }


    
}

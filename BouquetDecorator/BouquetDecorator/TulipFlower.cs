using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouquetDecorator
{
    public class TulipFlower : BouquetDecorator, IBouquetComponent
    {
        public TulipFlower(IBouquetComponent i)
            : base(i)
        {

        }
        void IBouquetComponent.AddFlower()
        {
            item.AddFlower();
            Console.WriteLine("Tulip flower added to the bouquet");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouquetDecorator
{
    public class PeonyFlower : BouquetDecorator, IBouquetComponent
    {
        public PeonyFlower(IBouquetComponent i)
            : base(i)
        {

        }
        void IBouquetComponent.AddFlower()
        {
            item.AddFlower();
            Console.WriteLine("Peony flower added to the bouquet");
        }

    }
}

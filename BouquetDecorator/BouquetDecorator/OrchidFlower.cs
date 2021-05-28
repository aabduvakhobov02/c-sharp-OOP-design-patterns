using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouquetDecorator
{
    public class OrchidFlower : BouquetDecorator, IBouquetComponent
    {
        public OrchidFlower(IBouquetComponent i)
            : base(i)
        {

        }
        void IBouquetComponent.AddFlower()
        {
            item.AddFlower();
            Console.WriteLine("Orchid flower added to the bouquet");
        }

    }
}

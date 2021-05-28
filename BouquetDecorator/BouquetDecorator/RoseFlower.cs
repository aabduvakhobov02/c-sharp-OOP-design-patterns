using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouquetDecorator
{
    public class RoseFlower : BouquetDecorator, IBouquetComponent
    {
        public RoseFlower(IBouquetComponent i)
            : base(i)
        {

        }
        void IBouquetComponent.AddFlower()
        {
            item.AddFlower();
            Console.WriteLine("Rose flower added to the bouquet");
        }

    }
}

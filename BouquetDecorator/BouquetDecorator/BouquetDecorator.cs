using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouquetDecorator
{
    public abstract class BouquetDecorator : IBouquetComponent
    {
        protected IBouquetComponent item;

        public BouquetDecorator(IBouquetComponent i)
        {
            item = i; 
        }

        public void AddFlower()
        {

        }
    }
}

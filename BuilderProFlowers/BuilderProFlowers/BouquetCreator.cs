using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderProFlowers
{
    public class BouquetCreator
    {
        private readonly IBouquetBuilder objectBuilder;
        public BouquetCreator(IBouquetBuilder builder)
        {
            objectBuilder = builder;
        }

        public void CreateBouquet()
        {
            objectBuilder.SetBouquetName();
            objectBuilder.SetMainFlower();
            objectBuilder.SetMaterial();
            objectBuilder.SetTape();
            objectBuilder.SetFillerFlower();
            objectBuilder.SetAdditionalDetails();
        }

        public Bouquet GetBouquet()
        {
            return objectBuilder.GetBouquet();
        }
    }
}

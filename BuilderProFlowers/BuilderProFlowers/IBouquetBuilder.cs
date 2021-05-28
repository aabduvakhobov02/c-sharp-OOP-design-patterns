using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderProFlowers
{
    public interface IBouquetBuilder
    {
        void SetBouquetName();
        void SetMainFlower();
        void SetMaterial();
        void SetTape();
        void SetFillerFlower();
        void SetAdditionalDetails();

        Bouquet GetBouquet();
    }
}

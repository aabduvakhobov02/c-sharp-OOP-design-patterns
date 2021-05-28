using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderProFlowers
{
    public class OrchidBouquetBuilder : IBouquetBuilder
    {
        Bouquet objBouquet = new Bouquet();
        public Bouquet GetBouquet()
        {
            return objBouquet;
        }

        public void SetAdditionalDetails()
        {
            objBouquet.AdditionalDetails.Add("-");

        }

        public void SetBouquetName()
        {
            objBouquet.BouquetName = "Beatiful Orchid Bouquet";
        }
        public void SetFillerFlower()
        {
            objBouquet.FillerFlower = "Spirea";
        }

        public void SetMainFlower()
        {
            objBouquet.MainFlower = "Orchid";
        }

        public void SetMaterial()
        {
            objBouquet.Material = "Bouquet Leafs";
        }

        public void SetTape()
        {
            objBouquet.Tape = "White tape";
        }
    }
}

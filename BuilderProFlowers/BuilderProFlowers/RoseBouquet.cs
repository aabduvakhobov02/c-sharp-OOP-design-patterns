using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderProFlowers
{
    public class RoseBouquet : IBouquetBuilder
    {
        Bouquet objBouquet = new Bouquet();
        public Bouquet GetBouquet()
        {
            return objBouquet;
        }

        public void SetAdditionalDetails()
        {
            objBouquet.AdditionalDetails.Add("Note");
            objBouquet.AdditionalDetails.Add("Heart keychain");

        }
        public void SetBouquetName()
        {
            objBouquet.BouquetName = "Wonderful Rose Bouquet";
        }

        public void SetFillerFlower()
        {
            objBouquet.FillerFlower = "Myrtle";
        }

        public void SetMainFlower()
        {
            objBouquet.MainFlower = "Rose";
        }

        public void SetMaterial()
        {
            objBouquet.Material = "Newspaper";
        }

        public void SetTape()
        {
            objBouquet.Tape = "Red tape";
        }
    }
}

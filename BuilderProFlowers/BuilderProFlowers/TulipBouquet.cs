using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderProFlowers
{
    public class TulipBouquetBuilder : IBouquetBuilder
    {
        Bouquet objBouquet = new Bouquet();
        public Bouquet GetBouquet()
        {
            return objBouquet;
        }

        public void SetAdditionalDetails()
        {
            objBouquet.AdditionalDetails.Add("Note");
            objBouquet.AdditionalDetails.Add("Little TeddyBear");

        }

        public void SetBouquetName()
        {
            objBouquet.BouquetName = "Spring Tulip Bouquet";
        }
        public void SetFillerFlower()
        {
            objBouquet.FillerFlower = "Lilly of the Valley";
        }

        public void SetMainFlower()
        {
            objBouquet.MainFlower = "Tulip";
        }

        public void SetMaterial()
        {
            objBouquet.Material = "Gift Paper";
        }

        public void SetTape()
        {
            objBouquet.Tape = "White Tape with flower pictures";
        }
    }
}

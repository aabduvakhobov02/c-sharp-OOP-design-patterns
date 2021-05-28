using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderProFlowers
{
    class StandardBouquetBuilder
    {
        public string BouquetName { get; set; }
        public string MainFlower { get; set; }
        public string Material { get; set; }
        public string Tape { get; set; }
        public string FillerFlower { get; set; }

        public StandardBouquetBuilder (string name, string flower, string material, string tape, string filler)
        {
            this.BouquetName = name;
            this.MainFlower = flower;
            this.Material = material;
            this.Tape = tape;
            this.FillerFlower = filler;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2_2_2_
{
    class Marmelade : Candy
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Sugar { get; set; }
        public Marmelade()
        {
            Name = "Marmelade-candy";
            Weight = 6.3;
            Sugar = 0.75;
        }
    }
}

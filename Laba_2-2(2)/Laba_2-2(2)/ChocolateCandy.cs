using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2_2_2_
{
    class ChocolateCandy : Candy
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Sugar { get; set; }
        public ChocolateCandy()
        {
            Name = "Candy with a chocolate";
            Weight = 5.2;
            Sugar = 0.55;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2_2_2_
{
    class GlassCandy : Candy
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Sugar { get; set; }
        public GlassCandy()
        {
            Name = "Glass-candy";
            Weight = 4.7;
            Sugar = 0.85;
        }
    }
}

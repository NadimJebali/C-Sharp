using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp
{
    internal class Vehicule
    {
        public String Year {  get; set; }
        public String Registration { get; set; }
        public String Color { get; set; }
        public String Brand { get; set; }
        public String Type { get; set; }
        public override string ToString()
        {
            return $"{Registration} {Brand}";
        }
    }
}

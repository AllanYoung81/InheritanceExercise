using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            NumberOfLegs = 4;
            LandOrSea = "Land BY the sea";
            HasTail = true;
            Age = 60;
        }

        public bool IsColdBlooded { get; set; }
        public string Color { get; set; }
        public bool IsVenomous { get; set; }
        public string Habitat { get; set; }

        


           
        }

}

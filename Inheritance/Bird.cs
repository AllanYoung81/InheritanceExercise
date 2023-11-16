using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird() 
        { 
            NumberOfLegs = 2;
            LandOrSea = "Land";
            HasTail = true;
            Age = 6;

        }

        public bool CanFly {  get; set; }
        public string Colors { get; set; }  
        public string BeakType { get; set; }
        public string TailType { get; set; }

        

    }
}

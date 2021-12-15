using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    { 
        public bool CanFly { get; set; }
        public bool CanSwim { get; set; }
        public string BirdNoise { get; set; }
        public string BirdSize { get; set; }
        
    }
}

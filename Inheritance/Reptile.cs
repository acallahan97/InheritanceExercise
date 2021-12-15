using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public bool EatsFlies { get; set; }
        public bool HasAShell { get; set; }
        public string ReptileNoise { get; set; }
        public bool HasLegs { get; set; }
    }
}

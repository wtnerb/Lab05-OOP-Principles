using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_priciples
{
    abstract class Plant : Living
    {
        public override string Sustenance { get; set; } = "Sunlight";
        public override string Lifespan { get; set; } = "indefinite";
    }
}

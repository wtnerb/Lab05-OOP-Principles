using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_priciples
{
    public abstract class Plant : Living
    {
        public override string Sustenance()
        {
            return "Sunlight";
        }
        public override string Lifespan { get; set; } = "indefinite";
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_priciples
{
    class Cerberus : Mammal
    {
        public override byte Heads { get; set; } = 3;
        public override string Size { get; set; } = "Large";
        public override string Sustenance { get; set; } = "Raw flesh";
        public override string Source { get; set; } = "Theogeny (circa 700 BCE) by Hesiod";
        public override string Locomotion()
        {
            return "Run";
        }
    }
}

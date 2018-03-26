using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_priciples
{
    class Zombie : Undead
    {
        public override string Source { get; set; } = "Haitian voodoo/folklore";
        public override string Base { get; set; } = "Typically human";
        public override string Sustenance { get; set; } = "BRAINS!";
        public override string[] SlainBy { get; set; } = { "Beheading", "excessive physical trauma" };
    }
}

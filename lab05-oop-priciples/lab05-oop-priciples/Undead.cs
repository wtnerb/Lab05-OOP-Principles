using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_priciples
{
    abstract class Undead : Imaginary
    {
        abstract public string[] SlainBy { get; set; }
        public override string Sustenance { get; set; } = null;
        public override string Size { get; set; } = "varies by base";
        abstract public string Base { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_priciples
{
    public abstract class Imaginary
    {
        public bool Exists = false;
        abstract public string Sustenance();
        abstract public string Size { get; set; }
        abstract public string Source();
    }
}

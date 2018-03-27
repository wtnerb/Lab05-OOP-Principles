using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_priciples
{
    abstract class Animal: Imaginary
    {
        public virtual byte Legs { get; set; } = 4;
        public abstract string Locomotion();
        public virtual byte Heads { get; set; } = 1;
    }
}

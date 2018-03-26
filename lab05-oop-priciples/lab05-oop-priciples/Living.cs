using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_priciples
{
    abstract class Living : Imaginary
    {
        public abstract string Lifespan { get; set; }
    }
}

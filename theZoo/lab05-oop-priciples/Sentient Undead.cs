using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_priciples
{
    public abstract class Sentient_Undead : Undead
    {
        abstract public string Name { get; set; }
        abstract public string[] Weaknesses { get; set; }
    }
}

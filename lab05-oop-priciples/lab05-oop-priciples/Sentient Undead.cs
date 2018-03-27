using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_priciples
{
    abstract class Sentient_Undead : Undead
    {
        abstract public string Name { get; set; }
        abstract public string[] Weaknesses { get; set; }
        override public string Base { get; set; } = "Human";
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_priciples
{
    public class Lich : Sentient_Undead
    {
        public override string Source()
        {
            return "Sword and The Sorcerer (1969) by Gardner Fox";
        }
        public override string[] Weaknesses { get; set; } = { "Phylactery" };
        public Lich (string name)
        {
            Name = name;
        }
        public override string[] SlainBy { get; set; } = { "Phylactery destruction" };

        public override string Name { get; set; }
    }
}

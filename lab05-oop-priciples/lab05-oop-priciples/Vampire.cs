﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_priciples
{
    public class Vampire : Sentient_Undead
    {
        public override string Sustenance()
        {
            return "Blood";
        }
        public override string Source()
        {
            return "Dracula (1897) by Bram Stoker";
        }
        public override string[] Weaknesses { get; set; } = { "garlic", "sunlight", "holy symbols" };
        public override string Name { get; set; }
        public Vampire (string name)
        {
            Name = name;
        }
        public override string[] SlainBy { get; set; } = { "wooden stake", "fire", "sunlight" };
    }
}

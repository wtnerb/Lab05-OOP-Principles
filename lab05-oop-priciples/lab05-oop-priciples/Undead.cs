﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_priciples
{
    public abstract class Undead : Imaginary
    {
        abstract public string[] SlainBy { get; set; }
        public override string Sustenance()
        {
            return "null";
        }
        public override string Size { get; set; } = "varies by base";
        virtual public string Base { get; set; } = "human";
        public string Basis()
        {
            return $"this was once a living {Base}";
        }
    }
}

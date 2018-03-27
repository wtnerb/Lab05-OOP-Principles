using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_priciples
{
    class Hydra : Lizard
    {
        public override byte Heads { get; set; } = 9;
        public override string Source { get; set; } = "Theogony (circa 700 BCE) by Hesiod";
        public override string Sustenance { get; set; } = "Whatever it wants, really";
        public override string Size { get; set; } = "Giant";
        public override string Locomotion()
        {
            string str = "Swim/run";
            Console.WriteLine(str);
            return str;
        }
        public void CutOffHead(string use)
        {
            if (use.ToLower() == "fire" || use.ToLower() == "Hydra poison")
            {
                Heads--;
            }
            else
            {
                Console.Write("Two grow back!");
                Heads++;
            }
        }
    }
}

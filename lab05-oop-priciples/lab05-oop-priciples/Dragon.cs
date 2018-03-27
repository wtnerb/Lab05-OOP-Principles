using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_priciples
{
    class Dragon : Lizard
    {

        public override string Source { get; set; } = "Saint George and the Dragon (6th century?) by Someone";
        public override string Sustenance { get; set; } = "Whatever it wants, really";
        public override string Size { get; set; } = "Giant";
        public override string Locomotion()
        {
            string str = "Fly";
            Console.WriteLine(str);
            return str;
        }
        public void BreathFire()
        {
            Console.WriteLine("Crispify that!");
        }
    }
}

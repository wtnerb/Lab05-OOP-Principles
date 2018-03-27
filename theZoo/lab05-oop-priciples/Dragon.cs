using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_priciples
{
    public class Dragon : Lizard
    {
        public override string Sustenance()
        {
            return "Whatever it wants, really";
        }

        public override string Source()
        {
            return "Saint George and the Dragon(6th century ?) by Someone";
        }
        public override string Size { get; set; } = "Giant";
        public override string Locomotion()
        {
            string str = "Fly";
            Console.WriteLine(str);
            return str;
        }
        public string BreathFire()
        {
            string s = "Crispify that!";
            Console.WriteLine(s);
            return s;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_priciples
{
    public class Ent : Plant
    {
        public override string Size { get; set; } = "Large";
        public override string Source()
        {
            return "Lord of the Rings: The Two Towers (1954) by J.R.R. Tolkien";
        }
    }
}

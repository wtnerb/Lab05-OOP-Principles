using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_priciples
{
    class DevilsSnare : Plant
    {
        public override string Size { get; set; } = "large shrubbery";
        public override string Source { get; set; } = "Harry Potter and the Philosopher's Stone (1997) by J. K. Rowling";
        public override string Sustenance { get; set; } = "Animal flesh";
    }
}

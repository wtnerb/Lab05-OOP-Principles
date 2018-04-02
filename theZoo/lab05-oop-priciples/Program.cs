using System;

namespace lab05_oop_priciples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Foolish Mortal! We welcome your kind here, now please step farther in and away from the exit.\n");
            Dragon smaug = new Dragon();
            Cerberus fluffy = new Cerberus();
            DevilsSnare ensare = new DevilsSnare();
            Hydra myExsMom = new Hydra();
            Lich Merenptah = new Lich("Quatach-Ichl");
            Vampire theCount = new Vampire("Dracula");
            Zombie mathProfessor = new Zombie();
            Ent treebeard = new Ent();

            Console.WriteLine($"Smaug the dragon is a conceptual descendent of the dragon found in \n{smaug.Source()}");
            Console.WriteLine($"The most obscure reference in this program is the lich named {Merenptah.Name}");
            Console.WriteLine($"The hydra was {myExsMom.Size}");
            Console.WriteLine($"Beware the original hellhound, Cerberus, for it has many teeth in its\n {fluffy.Heads} maws.");
            Console.WriteLine($"Real vampires doen't sparkle. They are weak to {theCount.Weaknesses[1]}, it might \neven kill them.");
            Console.WriteLine($"Ents are awesome and wise, for they are old. Their lifespan is {treebeard.Lifespan}.");
            Console.WriteLine($"Did you know the origin of the modern zombie is in {mathProfessor.Source()}?");
        }
    }
}

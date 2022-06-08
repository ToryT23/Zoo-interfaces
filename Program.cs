using System;
using System.Collections.Generic;

namespace ZoologicalZaniness
{
    class Program
    {
        static void Main(string[] args)
        {
           Pigeon p = new Pigeon();
           p.name = "Josh";
           p.Fly();
            Seagull s = new Seagull();
            s.name = "lemons";
            s.Fly();

            Cat c = new Cat();
            c.name = "Meow Champ";
            c.Run();
            PaintedDog d = new PaintedDog();
            d.name = "ground warrior";
            d.Run();

        List<IFlying> birds = new List<IFlying>() { p, s };
            foreach ( IFlying b in birds){
                Console.WriteLine("..............................");
                Console.WriteLine("..............................");
                Console.WriteLine($"{b.name} is a flyer");
            }


        List <IWalking> grounders = new List<IWalking>() {c, d};
        foreach (IWalking g in grounders){
            Console.WriteLine("..............................");
            Console.WriteLine("..............................");
            Console.WriteLine($"{g.name} is a grounder");
        }



        }
    }
}

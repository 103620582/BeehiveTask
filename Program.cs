using System;
using System.Collections.Generic;

namespace BeehiveTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 2 beehives

            Beehive Beetles = new Beehive(4);
            Beetles.NewBee(new Bee("John", 3.2F));
            Beetles.NewBee(new Bee("Paul", 2.7F));
            Beetles.NewBee(new Bee("George", 1.1F));
            Beetles.NewBee(new Bee("Ringo", 2.0F));

            Beehive Nirvana = new Beehive(3);
            Nirvana.NewBee(new Bee("Kurt", 2.3F));
            Nirvana.NewBee(new Bee("Dave", 7.4F));
            Nirvana.NewBee(new Bee("Krist", 1.5F));

            // Run CollectHoney method

            System.Console.WriteLine($"The Beetles collected {Beetles.CollectHoney(6)} honeys in 6 days.");
            System.Console.WriteLine($"Nirvana collected {Nirvana.CollectHoney(4)} honeys in 4 days.");

            // Number of bees in each beehive

            System.Console.WriteLine($"{Beetles.Bees.Count} bees in The Beetles");
            System.Console.WriteLine($"{Nirvana.Bees.Count} bees in Nirvana");
        
        }

    

    }
}

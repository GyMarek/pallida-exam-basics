using System;

namespace Favourite_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            if (args.Length == 0)
            {
                animal.PrintUsage();
            }

            if (args.Length == 1)
            {
                animal.AddAnimal(args[0]);
            }
        }
    }
}

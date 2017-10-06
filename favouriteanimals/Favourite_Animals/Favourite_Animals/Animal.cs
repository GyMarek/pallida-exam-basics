using System;
using System.IO;

namespace Favourite_Animals
{
    class Animal
    {
        string path = @"./favourites.txt";

        public void PrintUsage()
        {
            Console.WriteLine("```C# FavouriteAnimals [animal] [animal]```");
        }

        public void AddAnimal(string newAnimal)
        {
            string[] content;
            content = File.ReadAllLines(path);

            foreach (string line in content)
            {
                if (newAnimal == line)
                {
                    Console.WriteLine("Sorry, but there is another " + newAnimal + " in the file.");
                    break;
                }
                else
                {
                    try
                    {
                        using (var writer = File.AppendText(path))
                        {
                            writer.WriteLine(newAnimal);
                            Console.WriteLine("Now " + newAnimal + " in the list");
                            break;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Unable to write file: favourites.txt");
                    }
                }
            }
        }
    }
}

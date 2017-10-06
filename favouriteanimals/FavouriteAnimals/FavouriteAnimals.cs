using System;
using System.Collections.Generic;
using System.IO;

namespace FavouriteAnimals
{
    public class FavouriteAnimals
    {
        public static void Main(string[] args)
        {
            // The program's aim is to collect your favourite animals and store them in a text file.
            // There is a given text file called '''favourites.txt''', it will contain the animals
            // If ran from the command line without arguments
            // It should print out the usage:
            // ```C# FavouriteAnimals [animal] [animal]```
            // You can add as many command line arguments as many favourite you have.
            // One animal should be stored only at once
            // Each animal should be written in separate lines
            // The program should only save animals, no need to print them

            string path = "../../../favourites.txt";

            if (args.Length == 0)
            {
                Console.WriteLine("FavouriteAnimals usage:\nC# FavouriteAnimals [animal] [animal]");
                Console.WriteLine();
                try
                {
                    string[] animals = File.ReadAllLines(path);
                    if (animals.Length == 0)
                    {
                        Console.WriteLine("There are no animals in the file currently.");
                    }
                    else
                    {
                        Console.WriteLine("Actual favourite animal(s) in the file:");
                        foreach (string animal in animals)
                        {
                            Console.WriteLine(animal);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message); ;
                }
            }
            else
            {
                HashSet<string> animals = new HashSet<string>(args);
                using (StreamWriter writer = new StreamWriter(path))
                {
                    try
                    {
                        foreach (string animal in animals)
                        {
                            writer.WriteLine(animal);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}
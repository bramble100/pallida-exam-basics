using System;
using System.Collections.Generic;

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

            if (args.Length == 0)
            {
                Console.WriteLine("FavouriteAnimals usage:\nC# FavouriteAnimals [animal] [animal]");
            }
            else
            {
                HashSet<string> animals = new HashSet<string>(args);
            }

        }
    }
}
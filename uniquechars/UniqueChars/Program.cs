using System;
using System.Collections.Generic;

namespace UniqueChars
{
    public class UniqueChars
    {
        public static void Main(string[] args)
        {
            // Create a method called `UniqueCharacters` that takes a string as parameter
            // and returns a list with the unique letters of the given string
            // Create basic unit tests for it with at least 3 different test cases
            // Print the characters from that list in the following format:
            // "n", "g", "r", "m"

            List<string> result = UniqueCharacters("hello");
            result.ForEach(s => Console.WriteLine(Convert.ToString(s)));
            
            Console.ReadKey();
        }

        public static List<string> UniqueCharacters(string inputString)
        {
            List<string> result = new List<string>();
            if (String.IsNullOrEmpty(inputString))
            {
                return result;
            }
            foreach (char character in inputString)
            {
                result.Add(Convert.ToString(character));
            }
            return result;
        }
    }
}
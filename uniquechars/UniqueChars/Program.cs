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

            List<string> result = UniqueCharacters("doggy");
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
            HashSet<char> forbiddenChars = new HashSet<char>();
            foreach (char character in inputString.Replace(" ",""))
            {
                if (!forbiddenChars.Contains(character))
                {
                    if (result.Contains(Convert.ToString(character)))
                    {
                        result.Remove(Convert.ToString(character));
                        forbiddenChars.Add(character);
                    }
                    else
                    {
                        result.Add(Convert.ToString(character));
                    }
                }
            }
            return result;
        }
    }
}
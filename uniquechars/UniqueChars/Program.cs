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

            List<char> result = UniqueCharacters("doggy");
            result.ForEach(s => Console.WriteLine(Convert.ToString(s)));

            Console.ReadKey();
        }

        public static List<char> UniqueCharacters2(string inputString)
        {
            List<char> result = new List<char>();
            if (String.IsNullOrEmpty(inputString))
            {
                return result;
            }
            HashSet<char> forbiddenChars = new HashSet<char>();
            foreach (char character in inputString.Replace(" ", "").ToLower())
            {
                if (forbiddenChars.Contains(character))
                    continue;

                if (result.Contains(character))
                {
                    result.Remove(character);
                    forbiddenChars.Add(character);
                }
                else if (Char.IsLetter(character))
                {
                    result.Add(character);
                }
            }
            return result;
        }

        public static List<char> UniqueCharacters(string inputString)
        {
            var list = new List<char>(String.IsNullOrEmpty(inputString) ? new char[0] : inputString.Replace(" ", "").ToLower().ToCharArray());
            return list.FindAll(c => (list.FindAll(d => d == c).Count == 1 && Char.IsLetter(c)));
        }
    }
}
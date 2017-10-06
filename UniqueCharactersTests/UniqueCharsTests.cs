using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniqueChars;
using NUnit.Framework;

namespace UniqueCharactersTests
{
    [TestFixture]
    public class UniqueCharsTests
    {
        [Test]
        public void EmptyInputString()
        {
            string input = "";
            List<string> expectedResult = new List<string>();
            List<string> receivedResult = UniqueChars.UniqueChars.UniqueCharacters(input);
            Assert.AreEqual(receivedResult, expectedResult);
        }

        [Test]
        public void InputStringOnlyUniqueChars()
        {
            string input = "dog";
            List<string> expectedResult = new List<string>() { "d", "o", "g" };
            List<string> receivedResult = UniqueChars.UniqueChars.UniqueCharacters(input);
            Assert.AreEqual(receivedResult, expectedResult);
        }
    }
}

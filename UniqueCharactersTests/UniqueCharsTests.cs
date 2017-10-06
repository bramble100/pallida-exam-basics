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

            string input = "hello";
            List<string> expectedResult = new List<string>() { "h", "e", "o" };
            List<string> receivedResult = UniqueChars.UniqueChars.UniqueCharacters(input);
            Assert.AreEqual(receivedResult, expectedResult);
        }
    }
}

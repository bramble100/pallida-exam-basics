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
        public void NullInput()
        {
            string input = null;
            List<char> expectedResult = new List<char>();
            List<char> receivedResult = UniqueChars.UniqueChars.UniqueCharacters(input);
            Assert.AreEqual(receivedResult, expectedResult);
        }

        [Test]
        public void EmptyInputString()
        {
            string input = "";
            List<char> expectedResult = new List<char>();
            List<char> receivedResult = UniqueChars.UniqueChars.UniqueCharacters(input);
            Assert.AreEqual(receivedResult, expectedResult);
        }

        [Test]
        public void InputStringOnlyUniqueChars()
        {
            string input = "dog";
            List<char> expectedResult = new List<char>() { 'd', 'o', 'g' };
            List<char> receivedResult = UniqueChars.UniqueChars.UniqueCharacters(input);
            Assert.AreEqual(expectedResult, receivedResult);
        }

        [Test]
        public void InputStringDoubleUniqueChars()
        {
            string input = "doggy";
            List<char> expectedResult = new List<char>() { 'd', 'o', 'y' };
            List<char> receivedResult = UniqueChars.UniqueChars.UniqueCharacters(input);
            Assert.AreEqual(expectedResult, receivedResult);
        }

        [Test]
        public void InputStringMoreThanDoubleUniqueChars()
        {
            string input = "dogggy";
            List<char> expectedResult = new List<char>() { 'd', 'o', 'y' };
            List<char> receivedResult = UniqueChars.UniqueChars.UniqueCharacters(input);
            Assert.AreEqual(expectedResult, receivedResult);
        }

        [Test]
        public void InputStringMoreThanDoubleUniqueCharsWithSpace()
        {
            string input = "happy peace";
            List<char> expectedResult = new List<char>() { 'h', 'y', 'c' };
            List<char> receivedResult = UniqueChars.UniqueChars.UniqueCharacters(input);
            Assert.AreEqual(expectedResult, receivedResult);
        }

        [Test]
        public void InputStringMoreThanDoubleUniqueCharsWithSpaceMixedCase()
        {
            string input = "HAppy peace";
            List<char> expectedResult = new List<char>() { 'h', 'y', 'c' };
            List<char> receivedResult = UniqueChars.UniqueChars.UniqueCharacters(input);
            Assert.AreEqual(expectedResult, receivedResult);
        }

        [Test]
        public void InputStringMoreThanDoubleUniqueCharsWithSpaceMixedCaseSpecialChars()
        {
            string input = "#%(&Little";
            List<char> expectedResult = new List<char>() { 'i', 'e' };
            List<char> receivedResult = UniqueChars.UniqueChars.UniqueCharacters(input);
            Assert.AreEqual(expectedResult, receivedResult);
        }
    }
}

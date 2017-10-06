using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UniqueChars;


namespace TestUniqueChars
{
    [TestFixture]
    public class Test
    {
        UniChars uChars = new UniChars();

        [Test]
        public void TestFunction()
        {
            string input = "anagram";
            char[] output = { 'n', 'g', 'r', 'm'};

            Assert.AreEqual(output, uChars.UniqueCharacters(input));
        }
    }
}

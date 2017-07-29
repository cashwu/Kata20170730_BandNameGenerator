using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170730_BandNameGenerator
{
    [TestClass]
    public class BandNameGeneratorTests
    {
        [TestMethod]
        public void knife_should_return_The_Knife()
        {
            AssertBandNameShouldBe("knife", "The Knife");
        }

        [TestMethod]
        public void tart_should_return_Tartart()
        {
            AssertBandNameShouldBe("tart", "Tartart");
        }

        private static void AssertBandNameShouldBe(string bandName, string expected)
        {
            var kata = new Kata();
            var acutal = kata.BandNameGenerator(bandName);
            Assert.AreEqual(expected, acutal);
        }
    }

    public class Kata
    {
        public string BandNameGenerator(string str)
        {
            var charArray = str.ToCharArray();
            if (charArray.First() == charArray.Last())
            {
                return string.Concat(charArray.Concat(charArray.Skip(1))
                    .Select((c, i) => i == 0 ? Char.ToUpper(c) : c));
            }

            return "The Knife";
        }
    }
}

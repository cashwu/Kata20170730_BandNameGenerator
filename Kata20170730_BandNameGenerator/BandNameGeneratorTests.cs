using System;
using System.Collections;
using System.Collections.Generic;
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

        [TestMethod]
        public void bed_should_return_The_Bed()
        {
            AssertBandNameShouldBe("bed", "The Bed");
        }

        [TestMethod]
        public void sandles_should_return_Sandlesandles()
        {
            AssertBandNameShouldBe("sandles", "Sandlesandles");
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
            return string.Concat(charArray.First() == charArray.Last() 
                ? FirstCharToUpper(charArray.Concat(charArray.Skip(1))) 
                : "The ".ToCharArray().Concat(FirstCharToUpper(charArray)));
        }

        private static IEnumerable<char> FirstCharToUpper(IEnumerable<char> str)
        {
            return str.Select((c, i) => i == 0 ? Char.ToUpper(c) : c);
        }
    }
}

using System.Collections;
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
            return str.First() == str.Last() 
                ? $"{UpperFisrtChar(str)}{str.Substring(1)}" 
                : $"The {UpperFisrtChar(str)}";
        }

        private static string UpperFisrtChar(string str)
        {
            return $"{str.Substring(0, 1).ToUpper()}{str.Substring(1)}";
        }
    }
}

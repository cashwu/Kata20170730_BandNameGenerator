using System;
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
            return "The Knife";
        }
    }
}

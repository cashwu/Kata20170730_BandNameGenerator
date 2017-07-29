﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170730_BandNameGenerator
{
    [TestClass]
    public class BandNameGeneratorTests
    {
        [TestMethod]
        public void knife_should_return_The_knife()
        {
            var kata = new Kata();
            var acutal = kata.BandNameGenerator("knife");
            Assert.AreEqual("The knife", acutal);
        }
    }

    public class Kata
    {
        public string BandNameGenerator(string str)
        {
            return "The " + str;
        }
    }
}

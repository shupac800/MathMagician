using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician;

namespace MathMagicianTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testIntegers()
        {
            Assert.AreEqual(Output.printIntegers(5), "0 1 2 3 4 ");
        }

        [TestMethod]
        public void testFibonacci()
        {
            Assert.AreEqual(Output.printFibonacci(6), "1 1 2 3 5 8 ");
        }

        [TestMethod]
        public void testPrimes()
        {
            Assert.AreEqual(Output.printPrimes(6), "2 3 5 7 11 13 ");
        }
    }
}

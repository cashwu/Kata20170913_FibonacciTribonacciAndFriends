using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170913_FibonacciTribonacciAndFriends
{
    [TestClass]
    public class XbonacciTest
    {
        [TestMethod]
        public void input_0_1_and_3_should_return_0_1_1()
        {
            XbonacciShouldBe(new double[] { 0, 1, 1 }, new double[] { 0, 1 }, 3);
        }

        [TestMethod]
        public void input_1_1_and_3_should_return_1_1_2()
        {
            XbonacciShouldBe(new double[] { 1, 1, 2 }, new double[] { 1, 1 }, 3);
        }

        private static void XbonacciShouldBe(double[] expected, double[] signature, int n)
        {
            var xbonacci = new Xbonacci();
            var actual = xbonacci.xbonacci(signature, n);
            CollectionAssert.AreEqual(expected, actual);
        }
    }

    public class Xbonacci
    {
        public double[] xbonacci(double[] signature, int n)
        {
            return new[] { signature[0], signature[1], signature[0] + signature[1] };
        }
    }
}

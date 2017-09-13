using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

        [TestMethod]
        public void input_1_1_and_4_should_return_1_1_2_3()
        {
            XbonacciShouldBe(new double[] { 1, 1, 2, 3 }, new double[] { 1, 1 }, 4);
        }

        [TestMethod]
        public void input_0_1_and_10()
        {
            XbonacciShouldBe(new double[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 }, new double[] { 0, 1 }, 10);
        }

        [TestMethod]
        public void input_1_1_and_10()
        {
            XbonacciShouldBe(new double[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 }, new double[] { 1, 1 }, 10);
        }

        [TestMethod]
        public void input_0_1_1_1_and_6_should_return_0_1_1_1_3_6()
        {
            XbonacciShouldBe(new double[] { 0, 1, 1, 1, 3, 6 }, new double[] { 0, 1, 1, 1 }, 6);
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
            var result = signature.ToList();
            for (var i = 0; i < n; i++)
            {
                if (i + 1 <= result.Count)
                {
                    continue;
                }

                var val = result[i - 1] + result[i - 2]; 

                if (signature.Length > 2)
                {
                    val += result[i - 3] + result[i - 4];
                }

                result.Add(val);
            }

            return result.ToArray();
        }
    }
}

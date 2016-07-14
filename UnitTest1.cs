using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void test1()
        {
            List<int> actual = PrimeFactor.generate(1);
            List<int> expected = new List<int>();
            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod]
        public void test2()
        {
            List<int> actual = PrimeFactor.generate(2);
            List<int> expected = new List<int>() {2};
            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        
    }

    public class PrimeFactor
    {
        public static List<int> generate(int n)
        {
           var primes = new List<int>();
            if (n > 1)
                primes.Add(n);
            return primes;
        }
    }


}

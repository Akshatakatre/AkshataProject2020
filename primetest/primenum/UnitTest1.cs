using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using primetest;

namespace primenum
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_check()
        {
            Program p = new Program();
            string res =p.check(7);
            string accept = "the number is prime ";
            string excepted = res;
            Assert.AreEqual(excepted, accept);

        }
    }
}

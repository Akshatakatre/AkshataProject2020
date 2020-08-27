using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using aknine;
namespace ninea
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = Program.prime(7);
            string s = "the number is prime ";
            Assert.AreEqual(s,a);
        }
    }
}

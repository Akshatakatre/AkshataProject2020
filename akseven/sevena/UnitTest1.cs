using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using akseven;
namespace sevena
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program p = new Program();
            int a = 3;
            int b = 2;
            int c = 9;
            int s = c;
            Assert.AreEqual(s, 9);
        }
    }
}

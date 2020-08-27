using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using akfour;
namespace four
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program p = new Program();
            string s = "hello this is c# class";
            int i = 4;
            string str = s;
            Assert.AreEqual(str, i);
        }
    }
}

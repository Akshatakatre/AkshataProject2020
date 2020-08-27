using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using akeight;
namespace eighta
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           // Program p = new Program();
           int a = Program.fab(5);
            int n = 5;
            //int[] x = { 0,1,1,2,3};
            //int[] s = x ;
            
            Assert.AreEqual(n, a);
        }
    }
}

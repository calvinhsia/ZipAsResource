using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZipAsResource;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var x = Program.GetResource();
            Assert.AreEqual(276, x.Length);
        }
    }
}

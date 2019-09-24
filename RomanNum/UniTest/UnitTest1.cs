using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNum;
using System;

namespace UniTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Over3999()
        {
            var tmp = int.MaxValue.ToRoman();
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeNumber()
        {
            var tmp = -42;
            var asd = tmp.ToRoman();
        }
        [TestMethod]
        public void TestWithNumber1()
        {
            var tmp = 1.ToRoman();
            Assert.AreEqual(tmp, "I");
        }
        [TestMethod]
        public void TestWithANormalNumbe()
        {
            var tmp = 1578.ToRoman();
            Assert.AreEqual(tmp, "MDLXXVIII");
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNum;
using System;
using System.Globalization;

namespace UniTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Negative()
        {
            try
            {
                var temp = int.MinValue.ToRoman();
                Assert.Fail();
            }
            catch (Exception t)
            {
                Assert.AreEqual(t.GetType(), typeof(ArgumentOutOfRangeException));
            }
        }
        [TestMethod]
        public void Over3999()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => 4999.ToRoman());
        }
        [TestMethod]
        [DataRow(3999, "MMMCMXCIX")]
        [DataRow(1,"I")]
        [DataRow(4,"IV")]
        [DataRow(9,"IX")]
        [DataRow(40,"XL")]
        [DataRow(90, "XC")]
        [DataRow(400, "CD")]
        [DataRow(900, "CM")]
        public void TestWithANormalNumbe(int number,string roman)
        {
            Assert.AreEqual(number.ToRoman(), roman);
        }
    }
}

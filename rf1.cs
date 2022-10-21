using Microsoft.VisualStudio.TestTools.UnitTesting;
using REFACTOR1;

namespace UnitTest
{
    [TestClass]
    public class rf1
    {
        public RF1 rf;
        [TestMethod]
        public void TM1()
        {
            string expected = "SAD";
            string msg = "I Am SAD";
            rf = new RF1(msg);
            string value = rf.analysemood();
            Assert.AreEqual(expected, value);
        }
        [TestMethod]
        public void TM11()
        {
            string expected = "HAPPY";
            string msg = "I Am HAPPY";
            rf = new RF1(msg);
            string value = rf.analysemood();
            Assert.AreEqual(expected, value);
        }
    }
}
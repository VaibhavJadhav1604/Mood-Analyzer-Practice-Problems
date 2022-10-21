using Microsoft.VisualStudio.TestTools.UnitTesting;
using MAPP2;

namespace UnitTest
{
    [TestClass]
    public class UnitTest2
    {
        public MAP2 map2;
        [TestMethod]
        [DataRow(null)]
        public void TestMethod2(string msg)
        {
            map2 = new MAP2();
            string expected = "HAPPY";
            string value = map2.analysemood(msg);
            Assert.AreEqual(expected, value);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = TestingApp.Program.Something(99);
            Assert.AreEqual("No hierve", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string result = TestingApp.Program.Something(100);
            Assert.AreEqual("Hierve", result);
        }

    }
}
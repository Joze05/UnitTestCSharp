using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = TestingApp2.Program.checkMajorityAge(18);
            Assert.AreEqual("Mayor de edad", result);    
        }

        [TestMethod]
        public void TestMethod2()
        {
            string result = TestingApp2.Program.checkMajorityAge(15);
            Assert.AreEqual("Menor de edad", result);
        }
    }
}
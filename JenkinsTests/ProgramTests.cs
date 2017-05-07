using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloJenkins.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void printingTest()
        {
            Assert.AreEqual("Hello World from Jenkins. Added Tests now", Program.printing());
        }
    }
}
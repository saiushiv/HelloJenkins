using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloJenkins.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void printingTest()
        {
            Assert.AreEqual("Hello World from Jenkins. Added Tests now and hi from machine : " + Environment.MachineName, Program.printing());
        }
    }
}
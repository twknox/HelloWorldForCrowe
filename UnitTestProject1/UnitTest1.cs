using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOutput
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNewWriter()
        {
            var w = new Output.Writer("console");
            Assert.IsNotNull(w);
        }
        [TestMethod]
        public void TestConsoleWrite()
        {
            var w = new Output.Writer("console");
            var result = w.Write("Test");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestConsoleNext()
        {
            var w = new Output.Writer("console");
            var result = w.Next();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestConsoleFormattedWrite()
        {
            var w = new Output.Writer("%s", "console");
            var result = w.Next();
            Assert.IsTrue(result);
        }


        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void TestNewBadWriter()
        {
            var w = new Output.Writer("xxx");
            Assert.IsNotNull(w);
        }

    }
}

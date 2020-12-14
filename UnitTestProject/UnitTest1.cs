using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
          
            var answer = Chatbot.Reply("", 0);
            Assert.AreEqual("hej", answer);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var answer = Chatbot.Reply(" Linus", 0);
            Assert.AreEqual("hej Linus", answer);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var answer = Chatbot.Reply("Linus", 15);
            Assert.AreEqual("Linus är 15 år gammal", answer);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var answer = Chatbot.Reply("Hjälp mig!", 0);
            Assert.AreEqual("Vad behöver du hjälp med?", answer);
        }
    }
}

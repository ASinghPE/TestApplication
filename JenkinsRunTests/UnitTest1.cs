using NUnit.Framework;
using System;
using System.IO;

namespace JenkinsRunTests
{
    public class Tests
    {
        private const string Expected = "Hello World!";
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                JenkinsRun.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
            Assert.Pass();
        }
    }
}
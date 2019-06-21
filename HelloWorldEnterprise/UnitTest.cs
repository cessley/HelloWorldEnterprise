using HelloWorldEnterprise.Repositories;
using NUnit.Framework;
using System;
using System.IO;

namespace HelloWorldEnterprise
{
    [TestFixture]
    public class HelloWorldUnitTests
    {
        [Test]
        public void TestRead()
        {
            var expected = "Hello World";
            var actual = new HelloWorld().Read();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestWrite()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                var expected = "Hello World\n";
                var hw = new HelloWorld();

                hw.Write();

                Assert.AreEqual(expected, sw.ToString());
            }
        }
    }
}

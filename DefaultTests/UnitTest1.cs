using System;
using NUnit.Framework;
using ExampleLib;

namespace DefaultTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Test1()
        {
			new Class1 ();
            Console.WriteLine("Test body running..");
        }

		[Test]
        public void Test2()
        {
            Assert.AreEqual(2,26);
        }
    }
}

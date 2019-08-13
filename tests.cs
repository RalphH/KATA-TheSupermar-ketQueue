using System;
using NUnit.Framework;

namespace TheSupermarketQueue
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void ExampleTest1()
        {
            long expected = 0;

            long actual = Program.QueueTime(new int[] { }, 1);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ExampleTest2()
        {
            long expected = 10;

            long actual = Program.QueueTime(new int[] { 1, 2, 3, 4 }, 1);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ExampleTest3()
        {
            long expected = 9;

            long actual = Program.QueueTime(new int[] { 2, 2, 3, 3, 4, 4 }, 2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ExampleTest4()
        {
            long expected = 5;

            long actual = Program.QueueTime(new int[] { 1, 2, 3, 4, 5 }, 100);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ExampleTest5()
        {
            long expected = 12;

            long actual = Program.QueueTime(new int[] { 5, 3, 4 }, 1);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ExampleTest6()
        {
            long expected = 10;

            long actual = Program.QueueTime(new int[] { 10, 2, 3, 3 }, 2);

            Assert.AreEqual(expected, actual);
        }
    }
}
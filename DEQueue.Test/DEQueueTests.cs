using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DEQueue.Test
{
    [TestClass()]
    public class DEQueueTests
    {
        [TestMethod()]
        public void pushBackTest()
        {
            // arrange
            DEQueue<string> queue = new DEQueue<string>();
            string expected = "Alisa";

            // act
            queue.pushFront("Mark");
            queue.pushFront("Azat");
            queue.pushBack("Alisa");

            // assert
            Assert.AreEqual(expected, queue.back);
        }

        [TestMethod()]
        public void pushFrontTest()
        {
            // arrange
            DEQueue<string> queue = new DEQueue<string>();
            string expected = "Alisa";

            // act
            queue.pushBack("Mark");
            queue.pushBack("Azat");
            queue.pushFront("Alisa");

            // assert
            Assert.AreEqual(expected, queue.front);
        }

        [TestMethod()]
        public void popFrontTest()
        {
            // arrange
            DEQueue<string> queue = new DEQueue<string>();
            string expected = "Alisa";

            // act
            queue.pushBack("Mark");
            queue.pushFront("Alisa");
            queue.pushFront("Kate");
            queue.popFront();

            // assert
            Assert.AreEqual(expected, queue.front);
        }

        [TestMethod()]
        public void popBackTest()
        {
            // arrange
            DEQueue<string> queue = new DEQueue<string>();
            string expected = "Mark";

            // act
            queue.pushBack("Mark");
            queue.pushBack("Alisa");
            queue.pushFront("Kate");
            queue.popBack();

            // assert
            Assert.AreEqual(expected, queue.back);
        }

        [TestMethod()]
        public void ClearTes()
        {
            // arrange
            DEQueue<string> queue = new DEQueue<string>();
            string expected = "Mark";

            // act
            queue.pushBack("Alisa");
            queue.pushBack("Azat");
            queue.Clear();

            queue.pushBack("Mark");

            // assert
            Assert.AreEqual(expected, queue.back);
        }

    }
}

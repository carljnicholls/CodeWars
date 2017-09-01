using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HighAndLowNumberFromString.Test
{
    [TestFixture]
    public class HighAndLowKata
    {
        [Test]
        public void HighAndLow_Test1()
        {
            Assert.AreEqual("42 -9", HighAndLowNumberFromString.HighAndLowKata.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        }
        [Test]
        public void HighAndLow_Test2()
        {
            Assert.AreEqual("5 1", HighAndLowNumberFromString.HighAndLowKata.HighAndLow("1 2 3 4 5"));
        }
        [Test]
        public void HighAndLow_Test3()
        {
            Assert.AreEqual("5 -3", HighAndLowNumberFromString.HighAndLowKata.HighAndLow("1 2 -3 4 5"));
        }
        [Test]
        public void HighAndLow_Test4()
        {
            Assert.AreEqual("9 -5", HighAndLowNumberFromString.HighAndLowKata.HighAndLow("1 9 3 4 -5"));
        }
        [Test]
        public void HighAndLow_SomeTest()
        {
            Assert.AreEqual("542 -214", HighAndLowNumberFromString.HighAndLowKata.HighAndLow("4 5 29 54 4 0 -214 542 -64 1 -3 6 -6"));
        }

        [Test]
        public void HighAndLow_PlusMinusTest()
        {
            Assert.AreEqual("1 -1", HighAndLowNumberFromString.HighAndLowKata.HighAndLow("1 -1"));
        }

        [Test]
        public void HighAndLow_PlusPlusTest()
        {
            Assert.AreEqual("1 1", HighAndLowNumberFromString.HighAndLowKata.HighAndLow("1 1"));
        }

        [Test]
        public void HighAndLow_MinusMinusTest()
        {
            Assert.AreEqual("-1 -1", HighAndLowNumberFromString.HighAndLowKata.HighAndLow("-1 -1"));
        }

        [Test]
        public void HighAndLow_PlusMinusZeroTest()
        {
            Assert.AreEqual("1 -1", HighAndLowNumberFromString.HighAndLowKata.HighAndLow("1 -1 0"));
        }

        [Test]
        public void HighAndLow_PlusPlusZeroTest()
        {
            Assert.AreEqual("1 0", HighAndLowNumberFromString.HighAndLowKata.HighAndLow("1 1 0"));
        }

        [Test]
        public void HighAndLow_MinusMinusZeroTest()
        {
            Assert.AreEqual("0 -1", HighAndLowNumberFromString.HighAndLowKata.HighAndLow("-1 -1 0"));
        }

        [Test]
        public void HighAndLow_SingleTest()
        {
            Assert.AreEqual("42 42", HighAndLowNumberFromString.HighAndLowKata.HighAndLow("42"));
        }

        [Test]
        public void HighAndLow_RandomTest()
        {
            Random r = new Random();
            List<int> numbers = new List<int>();
            for (int i = r.Next(1, 42); i > 0; i--)
                numbers.Add(r.Next(Int32.MinValue, Int32.MaxValue));

            Assert.AreEqual(numbers.Max().ToString() + " " + numbers.Min().ToString(), HighAndLowNumberFromString.HighAndLowKata.HighAndLow(String.Join(" ", numbers.Select(n => n.ToString()).ToArray())));
        }
    }
}

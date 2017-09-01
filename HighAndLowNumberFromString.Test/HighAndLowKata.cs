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
        public void Test1()
        {
            Assert.AreEqual("42 -9", HighAndLowNumberFromString.HighAndLowKata.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual("5 1", HighAndLowNumberFromString.HighAndLowKata.HighAndLow("1 2 3 4 5"));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual("5 -3", HighAndLowNumberFromString.HighAndLowKata.HighAndLow("1 2 -3 4 5"));
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual("9 -5", HighAndLowNumberFromString.HighAndLowKata.HighAndLow("1 9 3 4 -5"));
        }
        [Test]
        public void SomeTest()
        {
            Assert.AreEqual("542 -214", HighAndLowNumberFromString.HighAndLowKata.HighAndLow("4 5 29 54 4 0 -214 542 -64 1 -3 6 -6"));
        }

        [Test]
        public void PlusMinusTest()
        {
            Assert.AreEqual("1 -1", HighAndLowNumberFromString.HighAndLowKata.HighAndLow("1 -1"));
        }

        [Test]
        public void PlusPlusTest()
        {
            Assert.AreEqual("1 1", HighAndLowNumberFromString.HighAndLowKata.HighAndLow("1 1"));
        }

        [Test]
        public void MinusMinusTest()
        {
            Assert.AreEqual("-1 -1", HighAndLowNumberFromString.HighAndLowKata.HighAndLow("-1 -1"));
        }

        [Test]
        public void PlusMinusZeroTest()
        {
            Assert.AreEqual("1 -1", HighAndLowNumberFromString.HighAndLowKata.HighAndLow("1 -1 0"));
        }

        [Test]
        public void PlusPlusZeroTest()
        {
            Assert.AreEqual("1 0", HighAndLowNumberFromString.HighAndLowKata.HighAndLow("1 1 0"));
        }

        [Test]
        public void MinusMinusZeroTest()
        {
            Assert.AreEqual("0 -1", HighAndLowNumberFromString.HighAndLowKata.HighAndLow("-1 -1 0"));
        }

        [Test]
        public void SingleTest()
        {
            Assert.AreEqual("42 42", HighAndLowNumberFromString.HighAndLowKata.HighAndLow("42"));
        }

        [Test]
        public void RandomTest()
        {
            Random r = new Random();
            List<int> numbers = new List<int>();
            for (int i = r.Next(1, 42); i > 0; i--)
                numbers.Add(r.Next(Int32.MinValue, Int32.MaxValue));

            Assert.AreEqual(numbers.Max().ToString() + " " + numbers.Min().ToString(), HighAndLowNumberFromString.HighAndLowKata.HighAndLow(String.Join(" ", numbers.Select(n => n.ToString()).ToArray())));
        }
    }
}

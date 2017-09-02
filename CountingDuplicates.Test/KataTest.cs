using System;
using NUnit.Framework;

namespace CountingDuplicates.Test
{
    [TestFixture]
    public class KataTest
    {
        [Test]
        public void CountingDuplicates_KataTests1()
        {
            Assert.AreEqual(0, Kata.DuplicateCount(""));
        }
        [Test]
        public void CountingDuplicates_KataTests2()
        {
            Assert.AreEqual(0, Kata.DuplicateCount("abcde"));
        }
        [Test]
        public void CountingDuplicates_KataTests3()
        {
            Assert.AreEqual(2, Kata.DuplicateCount("aabbcde"));
        }
        [Test]
        public void CountingDuplicates_KataTests4()
        {
            Assert.AreEqual(2, Kata.DuplicateCount("aabBcde"), "should ignore case");
        }
        [Test]
        public void CountingDuplicates_KataTests5()
        {
            Assert.AreEqual(1, Kata.DuplicateCount("Indivisibility"));
        }
        [Test]
        public void CountingDuplicates_KataTests6()
        {
            Assert.AreEqual(2, Kata.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
        }
    }
}

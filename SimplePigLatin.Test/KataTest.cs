using NUnit.Framework;
using System;
using System.Linq;

namespace SimplePigLatin.Test
{
    [TestFixture]
    public class KataTest
    {
        public static string Solution(string str)
        {
            return String.Join(" ", str.Split(' ').Select(w => w.Substring(1) + w[0] + "ay"));
        }

        [Test]
        public void KataTest1()
        {
            Assert.AreEqual("igPay atinlay siay oolcay", Kata.PigIt("Pig latin is cool"));
        }

        [Test]
        public void KataTest2()
        {
            Assert.AreEqual("hisTay siay ymay tringsay", Kata.PigIt("This is my string"));
        }

        [Test]
        public void RandomTests()
        {
            var random = new Random();
            string randomStr;
            for (int i = 0; i < 10; i++)
            {
                randomStr =
                    String.Join("", Enumerable.Range(0, 20).Select((o, x) => (char)random.Next('a', 'z') + ((x + 1) % 3 == 0 ? " " : "")));

                Assert.AreEqual(Solution(randomStr), Kata.PigIt(randomStr));
            }
        }
    }
}

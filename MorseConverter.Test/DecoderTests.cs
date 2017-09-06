using System;
using NUnit.Framework;
using MorseConverter;

namespace MorseConverter.Tests
{
    [TestFixture]
    public class MorseCodeDecoderTests
    {
        private Converter converter = new Converter();

        [Test]
        public void MorseCodeDecoderBasicTest_1()
        {
            try
            {
                string input = ".-";
                string expected = "A";

                string actual = converter.Decode(input);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            }
        }

        [Test]
        public void MorseCodeDecoderBasicTest_2()
        {
            try
            {
                string input = ".";
                string expected = "E";

                string actual = converter.Decode(input);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            }
        }

        [Test]
        public void MorseCodeDecoderBasicTest_3()
        {
            try
            {
                string input = "..";
                string expected = "I";

                string actual = converter.Decode(input);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            }
        }

        [Test]
        public void MorseCodeDecoderBasicTest_4()
        {
            try
            {
                string input = ". .";
                string expected = "EE";

                string actual = converter.Decode(input);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            }
        }

        [Test]
        public void MorseCodeDecoderBasicTest_5()
        {
            try
            {
                string input = ".   .";
                string expected = "E E";

                string actual = converter.Decode(input);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            }
        }

        [Test]
        public void MorseCodeDecoderBasicTest_6()
        {
            try
            {
                string input = "...---...";
                string expected = "SOS";

                string actual = converter.Decode(input);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            }
        }

        [Test]
        public void MorseCodeDecoderBasicTest_7()
        {
            try
            {
                string input = "... --- ...";
                string expected = "SOS";

                string actual = converter.Decode(input);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            }
        }

        [Test]
        public void MorseCodeDecoderBasicTest_8()
        {
            try
            {
                string input = "...   ---   ...";
                string expected = "S O S";

                string actual = converter.Decode(input);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            }
        }

        [Test]
        public void MorseCodeDecoderComplexTest_1()
        {
            try
            {
                string input = " . ";
                string expected = "E";

                string actual = converter.Decode(input);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            }
        }

        [Test]
        public void MorseCodeDecoderComplexTest_2()
        {
            try
            {
                string input = "   .   . ";
                string expected = "E E";

                string actual = converter.Decode(input);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            }
        }
    }
}
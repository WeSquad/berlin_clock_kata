using Microsoft.VisualStudio.TestTools.UnitTesting;
using BerlinClockKata;

namespace Tests
{
    [TestClass]
    public class ConverterTest
    {
        [TestMethod]
        public void TestSingleMinuteRowWithZeroMinute()
        {
            var converter = new Converter();

            var singleMinuteRow = converter.ConvertSingleMinuteRow("00:00:00");

            Assert.AreEqual(singleMinuteRow, "OOOO");
        }

        [TestMethod]
        public void TestSingleMinuteRowWithOneMinute()
        {
            var converter = new Converter();

            var singleMinuteRow = converter.ConvertSingleMinuteRow("00:01:00");

            Assert.AreEqual(singleMinuteRow, "YOOO");
        }

        [TestMethod]
        public void TestSingleMinuteRowWithTwoMinute()
        {
            var converter = new Converter();

            var singleMinuteRow = converter.ConvertSingleMinuteRow("00:02:00");

            Assert.AreEqual(singleMinuteRow, "YYOO");
        }

        [TestMethod]
        public void TestSingleMinuteRowWithFiveMinute()
        {
            var converter = new Converter();

            var singleMinuteRow = converter.ConvertSingleMinuteRow("00:05:00");

            Assert.AreEqual(singleMinuteRow, "OOOO");
        }

        [TestMethod]
        public void TestSingleMinuteRowWithSixMinute()
        {
            var converter = new Converter();

            var singleMinuteRow = converter.ConvertSingleMinuteRow("00:06:00");

            Assert.AreEqual(singleMinuteRow, "YOOO");
        }
    }
}

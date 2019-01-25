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

            var singleMinuteRow = converter.ConvertSingleMinuteRow("00:00:01");

            Assert.AreEqual(singleMinuteRow, "YOOO");
        }
    }
}

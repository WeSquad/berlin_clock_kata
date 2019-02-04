using Berlin_clock_kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ConverterTest
    {
        [TestMethod]
        public void SingleMinuteRow000000Test()
        {
            var converter = new Converter();

            var actual = converter.ConvertSingleMinutesRow("00:00:00");

            Assert.AreEqual("OOOO", actual);
        }

        [TestMethod]
        public void SingleMinuteRow000100Test()
        {
            var converter = new Converter();

            var actual = converter.ConvertSingleMinutesRow("00:01:00");

            Assert.AreEqual("YOOO", actual);
        }
    }
}

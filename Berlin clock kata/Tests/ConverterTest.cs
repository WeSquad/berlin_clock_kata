using Berlin_clock_kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ConverterTest
    {
        private Converter Converter { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            Converter = new Converter();
        }

        [TestMethod]
        public void FiveMinuteRow000000Test()
        {
            var actual = Converter.ConvertFiveMinutesRow("00:00:00");

            Assert.AreEqual("OOOOOOOOOOO", actual);
        }

        [TestMethod]
        public void SingleMinuteRow000000Test()
        {
            var actual = Converter.ConvertSingleMinutesRow("00:00:00");

            Assert.AreEqual("OOOO", actual);
        }

        [TestMethod]
        public void SingleMinuteRow000100Test()
        {
            var actual = Converter.ConvertSingleMinutesRow("00:01:00");

            Assert.AreEqual("YOOO", actual);
        }

        [TestMethod]
        public void SingleMinuteRow000200Test()
        {
            var actual = Converter.ConvertSingleMinutesRow("00:02:00");

            Assert.AreEqual("YYOO", actual);
        }
    }
}

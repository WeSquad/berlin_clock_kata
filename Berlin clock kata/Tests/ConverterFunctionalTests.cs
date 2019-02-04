using Berlin_clock_kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ConverterFunctionalTests
    {
        private Converter Converter { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            Converter = new Converter();
        }

        [TestMethod]
        public void SingleMinuteRow000000Test()
        {
            var actual = Converter.ConvertSingleMinutesRow("00:00:00");

            Assert.AreEqual("OOOO", actual);
        }

        [TestMethod]
        public void SingleMinuteRow235959Test()
        {
            var actual = Converter.ConvertSingleMinutesRow("23:59:59");

            Assert.AreEqual("YYYY", actual);
        }

        [TestMethod]
        public void SingleMinuteRow123200Test()
        {
            var actual = Converter.ConvertSingleMinutesRow("12:32:00");

            Assert.AreEqual("YYOO", actual);
        }

        [TestMethod]
        public void SingleMinuteRow123400Test()
        {
            var actual = Converter.ConvertSingleMinutesRow("12:34:00");

            Assert.AreEqual("YYYY", actual);
        }

        [TestMethod]
        public void SingleMinuteRow123500Test()
        {
            var actual = Converter.ConvertSingleMinutesRow("12:35:00");

            Assert.AreEqual("OOOO", actual);
        }
    }
}

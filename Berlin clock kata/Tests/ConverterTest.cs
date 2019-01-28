using Microsoft.VisualStudio.TestTools.UnitTesting;
using BerlinClockKata;

namespace Tests
{
    [TestClass]
    public class ConverterTest
    {
        Converter converter;

        [TestInitialize]
        public void SetUp()
        {
            converter = new Converter();
        }

        #region singleMinuteRowTest
        [TestMethod]
        public void TestSingleMinuteRowWithZeroMinute()
        {
            AssertBerlinSingleMinutes("00:00:00", "OOOO");
        }

        [TestMethod]
        public void TestSingleMinuteRowWithOneMinute()
        {
            AssertBerlinSingleMinutes("00:01:00", "YOOO");
        }

        [TestMethod]
        public void TestSingleMinuteRowWithTwoMinute()
        {
            AssertBerlinSingleMinutes("00:02:00", "YYOO");
        }

        [TestMethod]
        public void TestSingleMinuteRowWithFiveMinute()
        {
            AssertBerlinSingleMinutes("00:05:00", "OOOO");
        }

        [TestMethod]
        public void TestSingleMinuteRowWithSixMinute()
        {
            AssertBerlinSingleMinutes("00:06:00", "YOOO");
        }

        private void AssertBerlinSingleMinutes(string digitalTime, string expectedBerlinSingleMinutes)
        {
            var singleMinuteRow = converter.ConvertSingleMinuteRow(digitalTime);

            Assert.AreEqual(expectedBerlinSingleMinutes, singleMinuteRow);
        }
        #endregion

        #region FiveMinutesRowTest
        [TestMethod]
        public void TestFiveMinutesRowTestWithZeroMinutes()
        {
            AssertBerlinFiveMinutes("00:00:00", "OOOOOOOOOOO");
        }

        [TestMethod]
        public void TestFiveMinutesRowTestWithFiveMinutes()
        {
            AssertBerlinFiveMinutes("00:05:00", "YOOOOOOOOOO");
        }

        [TestMethod]
        public void TestFiveMinutesRowTestWithTenMinutes()
        {
            AssertBerlinFiveMinutes("00:10:00", "YYOOOOOOOOO");
        }

        [TestMethod]
        public void TestFiveMinutesRowTestWithEleveMinutes()
        {
            AssertBerlinFiveMinutes("00:11:00", "YYOOOOOOOOO");
        }

        [TestMethod]
        public void TestFiveMinutesRowTestWithFifteenMinutes()
        {
            AssertBerlinFiveMinutes("00:15:00", "YYROOOOOOOO");
        }

        [TestMethod]
        public void TestFiveMinutesRowTestWithFifyNineMinutes()
        {
            AssertBerlinFiveMinutes("00:59:00", "YYRYYRYYRYY");
        }

        private void AssertBerlinFiveMinutes(string digitalTime, string expectedBerlinFiveMinutes)
        {
            var fiveMinutesRow = converter.ConvertFiveMinutesRow(digitalTime);

            Assert.AreEqual(expectedBerlinFiveMinutes, fiveMinutesRow);
        }
        #endregion

        #region SingleHourTest
        [TestMethod]
        public void TestSingleHoureRowTestWithZeroHours()
        {
            AssertBerlinSingleHour("00:00:00", "OOOO");
        }

        [TestMethod]
        public void TestSingleHoureRowTestWithOneHour()
        {
            AssertBerlinSingleHour("01:00:00", "ROOO");
        }

        [TestMethod]
        public void TestSingleHoureRowTestWithTwoHours()
        {
            AssertBerlinSingleHour("02:00:00", "RROO");
        }

        private void AssertBerlinSingleHour(string digitalTime, string expectedBerlinSingleHour)
        {
            var singleHoureRow = converter.ConvertSingleHoureRow(digitalTime);

            Assert.AreEqual(expectedBerlinSingleHour, singleHoureRow);
        }
        #endregion

        #region FiveHouretestRegionTest
        [TestMethod]
        public void TestFiveHoureRowTestWithZeroHoure()
        {
            var fiveHoureRow = converter.ConvertFiveHoureRow("00:00:00");

            Assert.AreEqual("OOOO", fiveHoureRow);
        }

        [TestMethod]
        public void TestFiveHoureRowTestWithFiveHoure()
        {
            var fiveHoureRow = converter.ConvertFiveHoureRow("05:00:00");

            Assert.AreEqual("ROOO", fiveHoureRow);
        }

        [TestMethod]
        public void TestFiveHoureRowTestWithTenHoure()
        {
            var fiveHoureRow = converter.ConvertFiveHoureRow("10:00:00");

            Assert.AreEqual("RROO", fiveHoureRow);
        }
        #endregion

        #region SecondLampTest
        [TestMethod]
        public void TestSecondLanmpTestWithZeroHoure()
        {
            var secondLamp = converter.ConvertSecondLamp("00:00:00");

            Assert.AreEqual("Y", secondLamp);
        }

        [TestMethod]
        public void TestSecondLanmpTestWithOneSecond()
        {
            var secondLamp = converter.ConvertSecondLamp("00:00:01");

            Assert.AreEqual("O", secondLamp);
        }

        [TestMethod]
        public void TestSecondLanmpTestWithTwoSecond()
        {
            var secondLamp = converter.ConvertSecondLamp("00:00:02");

            Assert.AreEqual("Y", secondLamp);
        }

        [TestMethod]
        public void TestSecondLanmpTestWithTwoThree()
        {
            var secondLamp = converter.ConvertSecondLamp("00:00:03");

            Assert.AreEqual("O", secondLamp);
        }
        #endregion

        #region ConvertTimeTest
        [TestMethod]
        public void TestConverterWithZeroHoure()
        {
            var time = converter.ConvertTime("00:00:00");

            Assert.AreEqual("YOOOOOOOOOOOOOOOOOOOOOOO", time);
        }

        [TestMethod]
        public void TestConverterWith23Houre()
        {
            var time = converter.ConvertTime("23:59:59");

            Assert.AreEqual("ORRRRRRROYYRYYRYYRYYYYYY", time);
        }

        [TestMethod]
        public void TestConverterWithRandomHoure()
        {
            var time = converter.ConvertTime("16:50:06");

            Assert.AreEqual("YRRROROOOYYRYYRYYRYOOOOO", time);
        }
        #endregion
    }
}

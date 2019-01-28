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

        #region FiveHoureTest
        [TestMethod]
        public void TestFiveHoureRowTestWithZeroHours()
        {
            AssertBerlinFiveHours("00:00:00", "OOOO");
        }

        [TestMethod]
        public void TestFiveHoureRowTestWithFiveHours()
        {
            AssertBerlinFiveHours("05:00:00", "ROOO");
        }

        [TestMethod]
        public void TestFiveHoureRowTestWithTenHours()
        {
            AssertBerlinFiveHours("10:00:00", "RROO");
        }

        private void AssertBerlinFiveHours(string digitalTime, string expectedBerlinFiveHours)
        {
            var fiveHoureRow = converter.ConvertFiveHoureRow(digitalTime);

            Assert.AreEqual(expectedBerlinFiveHours, fiveHoureRow);
        }
        #endregion

        #region SecondLampTest
        [TestMethod]
        public void TestSecondLanmpTestWithZeroSeconds()
        {
            AssertBerlinSeconds("00:00:00", "Y");
        }

        [TestMethod]
        public void TestSecondLanmpTestWithOneSecond()
        {
            AssertBerlinSeconds("00:00:01", "O");
        }

        [TestMethod]
        public void TestSecondLanmpTestWithTwoSeconds()
        {
            AssertBerlinSeconds("00:00:02", "Y");
        }

        [TestMethod]
        public void TestSecondLanmpTestWithTwoThreeSeconds()
        {
            AssertBerlinSeconds("00:00:03", "O");
        }

        private void AssertBerlinSeconds(string digitalTime, string expectedBerlinSeconds)
        {
            var secondLamp = converter.ConvertSecondLamp(digitalTime);

            Assert.AreEqual(expectedBerlinSeconds, secondLamp);
        }
        #endregion

        #region ConvertTimeTest
        [TestMethod]
        public void TestConverterWithZeroHours()
        {
            AssertBerlinTime("00:00:00", "YOOOOOOOOOOOOOOOOOOOOOOO");
        }

        [TestMethod]
        public void TestConverterWith23Hours()
        {
            AssertBerlinTime("23:59:59", "ORRRRRRROYYRYYRYYRYYYYYY");
        }

        [TestMethod]
        public void TestConverterWithRandomHours()
        {
            AssertBerlinTime("16:50:06", "YRRROROOOYYRYYRYYRYOOOOO");
        }

        private void AssertBerlinTime(string digitalTime, string expectedBerlinTime)
        {
            var time = converter.ConvertTime(digitalTime);

            Assert.AreEqual(expectedBerlinTime, time);
        }
        #endregion
    }
}

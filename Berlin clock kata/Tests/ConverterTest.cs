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
            AssertBerlinMinutes("00:00:00", "OOOO");
        }

        [TestMethod]
        public void TestSingleMinuteRowWithOneMinute()
        {
            AssertBerlinMinutes("00:01:00", "YOOO");
        }

        [TestMethod]
        public void TestSingleMinuteRowWithTwoMinute()
        {
            AssertBerlinMinutes("00:02:00", "YYOO");
        }

        [TestMethod]
        public void TestSingleMinuteRowWithFiveMinute()
        {
            AssertBerlinMinutes("00:05:00", "OOOO");
        }

        [TestMethod]
        public void TestSingleMinuteRowWithSixMinute()
        {
            AssertBerlinMinutes("00:06:00", "YOOO");
        }

        private void AssertBerlinMinutes(string digitalTime, string expectedBerlinMinutes)
        {
            var singleMinuteRow = converter.ConvertSingleMinuteRow(digitalTime);

            Assert.AreEqual(expectedBerlinMinutes, singleMinuteRow);
        }
        #endregion

        #region FiveMinutesRowTest
        [TestMethod]
        public void TestFiveMinutesRowTestWithZeroMinutes()
        {
            var fiveMinutesRow = converter.ConvertFiveMinutesRow("00:00:00");

            Assert.AreEqual("OOOOOOOOOOO", fiveMinutesRow);
        }

        [TestMethod]
        public void TestFiveMinutesRowTestWithFiveMinutes()
        {
            var fiveMinutesRow = converter.ConvertFiveMinutesRow("00:05:00");

            Assert.AreEqual("YOOOOOOOOOO", fiveMinutesRow);
        }


        [TestMethod]
        public void TestFiveMinutesRowTestWithTeninutes()
        {
            var fiveMinutesRow = converter.ConvertFiveMinutesRow("00:10:00");

            Assert.AreEqual("YYOOOOOOOOO", fiveMinutesRow);
        }

        [TestMethod]
        public void TestFiveMinutesRowTestWithEleveninutes()
        {
            var fiveMinutesRow = converter.ConvertFiveMinutesRow("00:11:00");

            Assert.AreEqual("YYOOOOOOOOO", fiveMinutesRow);
        }

        [TestMethod]
        public void TestFiveMinutesRowTestWithFifteeninutes()
        {
            var fiveMinutesRow = converter.ConvertFiveMinutesRow("00:15:00");

            Assert.AreEqual("YYROOOOOOOO", fiveMinutesRow);
        }
        

        [TestMethod]
        public void TestFiveMinutesRowTestWithFifyNineinutes()
        {
            var fiveMinutesRow = converter.ConvertFiveMinutesRow("00:59:00");

            Assert.AreEqual("YYRYYRYYRYY", fiveMinutesRow);
        }
        #endregion

        #region SingleHouretestRegionTest
        [TestMethod]
        public void TestSingleHoureRowTestWithZeroHoure()
        {
            var singleHoureRow = converter.ConvertSingleHoureRow("00:00:00");

            Assert.AreEqual("OOOO", singleHoureRow);
        }

        [TestMethod]
        public void TestSingleHoureRowTestWithOneHoure()
        {
            var singleHoureRow = converter.ConvertSingleHoureRow("01:00:00");

            Assert.AreEqual("ROOO", singleHoureRow);
        }

        [TestMethod]
        public void TestSingleHoureRowTestWithTwoHoure()
        {
            var singleHoureRow = converter.ConvertSingleHoureRow("02:00:00");

            Assert.AreEqual("RROO", singleHoureRow);
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

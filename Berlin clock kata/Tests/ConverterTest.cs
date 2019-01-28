using Microsoft.VisualStudio.TestTools.UnitTesting;
using BerlinClockKata;

namespace Tests
{
    [TestClass]
    public class ConverterTest
    {


        #region singleMinuteRowTest
        [TestMethod]
        public void TestSingleMinuteRowWithZeroMinute()
        {
            var converter = new Converter();

            var singleMinuteRow = converter.ConvertSingleMinuteRow("00:00:00");

            Assert.AreEqual("OOOO", singleMinuteRow);
        }

        [TestMethod]
        public void TestSingleMinuteRowWithOneMinute()
        {
            var converter = new Converter();

            var singleMinuteRow = converter.ConvertSingleMinuteRow("00:01:00");

            Assert.AreEqual("YOOO", singleMinuteRow);
        }

        [TestMethod]
        public void TestSingleMinuteRowWithTwoMinute()
        {
            var converter = new Converter();

            var singleMinuteRow = converter.ConvertSingleMinuteRow("00:02:00");

            Assert.AreEqual("YYOO", singleMinuteRow);
        }

        [TestMethod]
        public void TestSingleMinuteRowWithFiveMinute()
        {
            var converter = new Converter();

            var singleMinuteRow = converter.ConvertSingleMinuteRow("00:05:00");

            Assert.AreEqual("OOOO", singleMinuteRow);
        }

        [TestMethod]
        public void TestSingleMinuteRowWithSixMinute()
        {
            var converter = new Converter();

            var singleMinuteRow = converter.ConvertSingleMinuteRow("00:06:00");

            Assert.AreEqual("YOOO", singleMinuteRow);
        }
        #endregion

        #region FiveMinutesRowTest
        [TestMethod]
        public void TestFiveMinutesRowTestWithZeroMinutes()
        {
            var converter = new Converter();

            var fiveMinutesRow = converter.ConvertFiveMinutesRow("00:00:00");

            Assert.AreEqual("OOOOOOOOOOO", fiveMinutesRow);
        }

        [TestMethod]
        public void TestFiveMinutesRowTestWithFiveMinutes()
        {
            var converter = new Converter();

            var fiveMinutesRow = converter.ConvertFiveMinutesRow("00:05:00");

            Assert.AreEqual("YOOOOOOOOOO", fiveMinutesRow);
        }


        [TestMethod]
        public void TestFiveMinutesRowTestWithTeninutes()
        {
            var converter = new Converter();

            var fiveMinutesRow = converter.ConvertFiveMinutesRow("00:10:00");

            Assert.AreEqual("YYOOOOOOOOO", fiveMinutesRow);
        }

        [TestMethod]
        public void TestFiveMinutesRowTestWithEleveninutes()
        {
            var converter = new Converter();

            var fiveMinutesRow = converter.ConvertFiveMinutesRow("00:11:00");

            Assert.AreEqual("YYOOOOOOOOO", fiveMinutesRow);
        }

        [TestMethod]
        public void TestFiveMinutesRowTestWithFifteeninutes()
        {
            var converter = new Converter();

            var fiveMinutesRow = converter.ConvertFiveMinutesRow("00:15:00");

            Assert.AreEqual("YYROOOOOOOO", fiveMinutesRow);
        }
        

        [TestMethod]
        public void TestFiveMinutesRowTestWithFifyNineinutes()
        {
            var converter = new Converter();

            var fiveMinutesRow = converter.ConvertFiveMinutesRow("00:59:00");

            Assert.AreEqual("YYRYYRYYRYY", fiveMinutesRow);
        }
        #endregion

        #region SingleHouretestRegionTest
        [TestMethod]
        public void TestSingleHoureRowTestWithZeroHoure()
        {
            var converter = new Converter();

            var singleHoureRow = converter.ConvertSingleHoureRow("00:00:00");

            Assert.AreEqual("OOOO", singleHoureRow);
        }

        [TestMethod]
        public void TestSingleHoureRowTestWithOneHoure()
        {
            var converter = new Converter();

            var singleHoureRow = converter.ConvertSingleHoureRow("01:00:00");

            Assert.AreEqual("ROOO", singleHoureRow);
        }

        [TestMethod]
        public void TestSingleHoureRowTestWithTwoHoure()
        {
            var converter = new Converter();

            var singleHoureRow = converter.ConvertSingleHoureRow("02:00:00");

            Assert.AreEqual("RROO", singleHoureRow);
        }
        #endregion

        #region FiveHouretestRegionTest
        [TestMethod]
        public void TestFiveHoureRowTestWithZeroHoure()
        {
            var converter = new Converter();

            var fiveHoureRow = converter.ConvertFiveHoureRow("00:00:00");

            Assert.AreEqual("OOOO", fiveHoureRow);
        }

        [TestMethod]
        public void TestFiveHoureRowTestWithFiveHoure()
        {
            var converter = new Converter();

            var fiveHoureRow = converter.ConvertFiveHoureRow("05:00:00");

            Assert.AreEqual("ROOO", fiveHoureRow);
        }

        [TestMethod]
        public void TestFiveHoureRowTestWithTenHoure()
        {
            var converter = new Converter();

            var fiveHoureRow = converter.ConvertFiveHoureRow("10:00:00");

            Assert.AreEqual("RROO", fiveHoureRow);
        }
        #endregion

        #region SecondLampTest
        [TestMethod]
        public void TestSecondLanmpTestWithZeroHoure()
        {
            var converter = new Converter();

            var secondLamp = converter.ConvertSecondLamp("00:00:00");

            Assert.AreEqual("Y", secondLamp);
        }

        [TestMethod]
        public void TestSecondLanmpTestWithOneSecond()
        {
            var converter = new Converter();

            var secondLamp = converter.ConvertSecondLamp("00:00:01");

            Assert.AreEqual("O", secondLamp);
        }

        [TestMethod]
        public void TestSecondLanmpTestWithTwoSecond()
        {
            var converter = new Converter();

            var secondLamp = converter.ConvertSecondLamp("00:00:02");

            Assert.AreEqual("Y", secondLamp);
        }

        [TestMethod]
        public void TestSecondLanmpTestWithTwoThree()
        {
            var converter = new Converter();

            var secondLamp = converter.ConvertSecondLamp("00:00:03");

            Assert.AreEqual("O", secondLamp);
        }
        #endregion

        #region ConvertTimeTest
        [TestMethod]
        public void TestConverterWithZeroHoure()
        {
            var converter = new Converter();

            var time = converter.ConvertTime("00:00:00");

            Assert.AreEqual("YOOOOOOOOOOOOOOOOOOOOOOO", time);
        }

        [TestMethod]
        public void TestConverterWith23Houre()
        {
            var converter = new Converter();

            var time = converter.ConvertTime("23:59:59");

            Assert.AreEqual("ORRRRRRROYYRYYRYYRYYYYYY", time);
        }

        [TestMethod]
        public void TestConverterWithRandomHoure()
        {
            var converter = new Converter();

            var time = converter.ConvertTime("16:50:06");

            Assert.AreEqual("YRRROROOOYYRYYRYYRYOOOOO", time);
        }
        #endregion
    }
}

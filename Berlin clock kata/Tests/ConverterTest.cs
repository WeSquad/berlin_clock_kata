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
        #endregion

        #region FiveMinutesRowTest
        [TestMethod]
        public void TestFiveMinutesRowTestWithZeroMinutes()
        {
            var converter = new Converter();

            var fiveMinutesRow = converter.ConvertFiveMinutesRow("00:00:00");

            Assert.AreEqual(fiveMinutesRow, "OOOOOOOOOOO");
        }

        [TestMethod]
        public void TestFiveMinutesRowTestWithFiveMinutes()
        {
            var converter = new Converter();

            var fiveMinutesRow = converter.ConvertFiveMinutesRow("00:05:00");

            Assert.AreEqual(fiveMinutesRow, "YOOOOOOOOOO");
        }


        [TestMethod]
        public void TestFiveMinutesRowTestWithTeninutes()
        {
            var converter = new Converter();

            var fiveMinutesRow = converter.ConvertFiveMinutesRow("00:10:00");

            Assert.AreEqual(fiveMinutesRow, "YYOOOOOOOOO");
        }

        [TestMethod]
        public void TestFiveMinutesRowTestWithEleveninutes()
        {
            var converter = new Converter();

            var fiveMinutesRow = converter.ConvertFiveMinutesRow("00:11:00");

            Assert.AreEqual(fiveMinutesRow, "YYOOOOOOOOO");
        }

        [TestMethod]
        public void TestFiveMinutesRowTestWithFifteeninutes()
        {
            var converter = new Converter();

            var fiveMinutesRow = converter.ConvertFiveMinutesRow("00:15:00");

            Assert.AreEqual(fiveMinutesRow, "YYROOOOOOOO");
        }
        

        [TestMethod]
        public void TestFiveMinutesRowTestWithFifyNineinutes()
        {
            var converter = new Converter();

            var fiveMinutesRow = converter.ConvertFiveMinutesRow("00:59:00");

            Assert.AreEqual(fiveMinutesRow, "YYRYYRYYRYY");
        }
        #endregion

        #region SingleHouretestRegion
        [TestMethod]
        public void TestSingleHoureRowTestWithZeroHoure()
        {
            var converter = new Converter();

            var singleHoureRow = converter.ConvertSingleHoureRow("00:00:00");

            Assert.AreEqual(singleHoureRow, "OOOO");
        }

        [TestMethod]
        public void TestSingleHoureRowTestWithOneHoure()
        {
            var converter = new Converter();

            var singleHoureRow = converter.ConvertSingleHoureRow("01:00:00");

            Assert.AreEqual(singleHoureRow, "ROOO");
        }

        [TestMethod]
        public void TestSingleHoureRowTestWithTwoHoure()
        {
            var converter = new Converter();

            var singleHoureRow = converter.ConvertSingleHoureRow("02:00:00");

            Assert.AreEqual(singleHoureRow, "RROO");
        }
        #endregion

        #region FiveHouretestRegion
        [TestMethod]
        public void TestFiveHoureRowTestWithZeroHoure()
        {
            var converter = new Converter();

            var fiveHoureRow = converter.ConvertFiveHoureRow("00:00:00");

            Assert.AreEqual(fiveHoureRow, "OOOO");
        }

        [TestMethod]
        public void TestFiveHoureRowTestWithFiveHoure()
        {
            var converter = new Converter();

            var fiveHoureRow = converter.ConvertFiveHoureRow("05:00:00");

            Assert.AreEqual(fiveHoureRow, "ROOO");
        }

        [TestMethod]
        public void TestFiveHoureRowTestWithTenHoure()
        {
            var converter = new Converter();

            var fiveHoureRow = converter.ConvertFiveHoureRow("10:00:00");

            Assert.AreEqual(fiveHoureRow, "RROO");
        }
        #endregion

        #region SecondLamp
        [TestMethod]
        public void TestSecondLanmpTestWithZeroHoure()
        {
            var converter = new Converter();

            var secondLamp = converter.ConvertSecondLamp("00:00:00");

            Assert.AreEqual(secondLamp, "R");
        }
        #endregion
    }
}

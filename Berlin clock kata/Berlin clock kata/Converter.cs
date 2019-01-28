using System;
using System.Text;

namespace BerlinClockKata
{
    public class Converter
    {
        public string ConvertTime(string time)
        {
            var row = ConvertSecondLamp(time);
            row += ConvertFiveHoureRow(time);
            row += ConvertSingleHoureRow(time);
            row += ConvertFiveMinutesRow(time);
            row += ConvertSingleMinuteRow(time);
            return row;
        }

        public string ConvertSingleMinuteRow(string time)
        {
            var minutes = SelectMinutes(time);
            var lightsOn = minutes % 5;
            var lightsOff = 4 - lightsOn;

            return "Y".Repeat(lightsOn) + "O".Repeat(lightsOff);
        }

        public string ConvertFiveMinutesRow(string time)
        {
            var minutes = SelectMinutes(time);
            var lightsOn = minutes / 5;
            var lightsOff = 11 - lightsOn;
            var quarters = lightsOn / 3;
            var normalLightsOn = lightsOn - (quarters * 3);

            return "YYR".Repeat(quarters) + "Y".Repeat(normalLightsOn) + "O".Repeat(lightsOff);
        }

        public string ConvertSingleHoureRow(string time)
        {
            var houre = SelectHoure(time);
            var lightsOn = houre % 5;
            var lightsOff = 4 - lightsOn;

            return "R".Repeat(lightsOn) + "O".Repeat(lightsOff);
        }

        public string ConvertFiveHoureRow(string time)
        {
            var houre = SelectHoure(time);
            var lightsOn = houre / 5;
            var lightsOff = 4 - lightsOn;

            return "R".Repeat(lightsOn) + "O".Repeat(lightsOff);
        }

        public string ConvertSecondLamp(string time)
        {
            var seconds = SelectSeconds(time);

            return seconds.IsOdd()
                    ? "O"
                    : "Y";
        }

        private int SelectMinutes(string time)
        {
            return Int32.Parse(time.Substring(3, 2));
        }

        private int SelectHoure(string time)
        {
            return Int32.Parse(time.Substring(0, 2));
        }

        private int SelectSeconds(string time)
        {
            return Int32.Parse(time.Substring(6, 2));
        }
    }

    public static class StringExtensions
    {
        public static string Repeat(this string s, int n)
            => new StringBuilder(s.Length * n).Insert(0, s, n).ToString();
    }

    public static class IntExtensions
    {
        public static bool IsOdd(this int value) => value % 2 != 0; 
    }
}

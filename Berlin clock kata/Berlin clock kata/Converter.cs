using System.Linq;

namespace Berlin_clock_kata
{
    public class Converter
    {
        public string ConvertTime(string time)
        {
            return "";
        }

        public string ConvertSingleMinutesRow(string time)
        {
            var lightsOn = SelectSingleMinuteRowMinute(time);
            var lightsOff = 4 - lightsOn;

            return "Y".Repeat(lightsOn) + "O".Repeat(lightsOff);
        }

        private int SelectSingleMinuteRowMinute(string time)
        {
            var minute = SelectMinute(time);
            var simpleMinute = SimplifyMinute(minute);
            return simpleMinute;
        }

        private int SimplifyMinute(int minute)
        {
            return minute % 5;
        }

        private int SelectMinute(string time)
        {
            var minute = time.Substring(4, 1);
            return int.Parse(minute);
        }
    }

    public static class StringExtensions
    {
        public static string Repeat(this string item, int times)
        {
            return string.Join("", Enumerable.Repeat(item, times));
        }
    }
}

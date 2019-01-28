using System;
using System.Collections.Generic;
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
            var row = "";
            for (var i = 0; i < 4; i++)
            {
                if (i < houre % 5)
                {
                    row += "R";
                    continue;
                }
                row += "O";
            }
            return row;
        }

        public string ConvertFiveHoureRow(string time)
        {
            var houre = SelectHoure(time);
            var row = "";
            for (var i = 0; i < 4; i++)
            {
                if((houre / 5) > i)
                {
                    row += "R";
                    continue;
                }
                row += "O";
            }
            return row;
        }

        public string ConvertSecondLamp(string time)
        {
            var seconds = SelectSeconds(time);
            if (IsEven(seconds))
            {
                return "O";
            }
            return "Y";
        }

        private bool IsEven(int integer)
        {
            return integer % 2 != 0;
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
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BerlinClockKata
{
    public class Converter
    {
        public string ConvertTime(string time)
        {
            return "";
        }

        public string ConvertSingleMinuteRow(string time)
        {
            var lastMinute = SelectLastMinute(time);
            var row = "";
            for (var i = 0; i < 4; i++)
            {
                if(i < Int32.Parse(lastMinute)%5)
                { 
                    row += "Y";
                }
                else
                {
                    row += "O";
                }
            }
            return row;
        }

        public string ConvertFiveMinutesRow(string time)
        {
            var minutes = SelectMinutes(time);
            var row = "";

            for (var i = 0; i < 11; i++)
            {
                if (IsAddLightToFiveMinutesRow(i, minutes))
                {
                    row += AddLightToFiveMinutesRow(i);
                    continue;
                }
                row += "O";
            }

            return row;
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
            return "OOOO";
        }

        private bool IsAddLightToFiveMinutesRow(int iterator, int minutes)
        {
            return (minutes / 5) > iterator;
        }

        private string AddLightToFiveMinutesRow(int iterator)
        {
            if (IsAQuarter(iterator))
            {
                return "R";
            }
            return "Y";
        }

        private bool IsAQuarter(int iterator)
        {
            return (iterator + 1) % 3 == 0;
        }

        private int SelectMinutes(string time)
        {
            return Int32.Parse(time.Substring(3, 2));
        }

        private int SelectHoure(string time)
        {
            return Int32.Parse(time.Substring(0, 2));
        }

        private string SelectLastMinute(string time)
        {
            return time.Substring(4, 1);
        }
    }
}

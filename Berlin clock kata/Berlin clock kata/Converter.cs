using System;
using System.Collections.Generic;
using System.Text;

namespace BerlinClockKata
{
    public class Converter
    {
        public string ConvertTime(string time)
        {
            var row = "";
            row += ConvertSecondLamp(time);
            row += ConvertFiveHoureRow(time);
            row += ConvertSingleHoureRow(time);
            row += ConvertFiveMinutesRow(time);
            row += ConvertSingleMinuteRow(time);
            return row;
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
            return "R";
        }

        private bool IsEven(int integer)
        {
            return integer % 2 != 0;
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

        private int SelectSeconds(string time)
        {
            return Int32.Parse(time.Substring(6, 2));
        }

        private string SelectLastMinute(string time)
        {
            return time.Substring(4, 1);
        }
    }
}

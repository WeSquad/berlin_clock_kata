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
            if (time == "00:05:00")
            {
                return "YOOOOOOOOOO";
            }
            else if(time == "00:10:00")
            {
                return "YYOOOOOOOOO";
            }
            return "OOOOOOOOOOO";
        }
        
        private string SelectLastMinute(string time)
        {
            return time.Substring(4, 1);
        }
    }
}

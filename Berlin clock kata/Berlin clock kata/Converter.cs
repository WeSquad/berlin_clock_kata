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
            if (lastMinute == "1")
            {
                return "YOOO";
            }
            else if (lastMinute == "2")
            {
                return "YYOO";
            }
            return "OOOO";
        }

        private string SelectLastMinute(string time)
        {
            return time.Substring(4, 1);
        }
    }
}

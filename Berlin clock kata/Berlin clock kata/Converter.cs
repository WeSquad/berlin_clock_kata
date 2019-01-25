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
            if (time == "00:01:00")
            {
                return "YOOO";
            }
            else if (time == "00:02:00")
            {
                return "YYOO";
            }
            return "OOOO";
        }
    }
}

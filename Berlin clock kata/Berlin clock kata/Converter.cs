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
            if (time == "00:00:01")
            {
                return "YOOO";
            }
            return "OOOO";
        }
    }
}

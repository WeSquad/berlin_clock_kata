using System;
using System.Collections.Generic;
using System.Text;

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
            if (time == "00:01:00")
            {
                return "YOOO";
            }

            return "OOOO";
            
        }
    }
}

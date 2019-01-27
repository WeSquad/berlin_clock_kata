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
                if ((minutes/5) > i)
                {
                    if(isAQuarter(i))
                    {
                        row += "R";
                        continue;
                    }
                    else
                    {
                        row += "Y";
                        continue;
                    }   
                }
                row += "O";
            }

            return row;
        }

        private bool isAQuarter(int iterator)
        {
            return (iterator + 1) % 3 == 0;
        }

        private int SelectMinutes(string time)
        {
            return Int32.Parse(time.Substring(3, 2));
        }
        
        private string SelectLastMinute(string time)
        {
            return time.Substring(4, 1);
        }
    }
}

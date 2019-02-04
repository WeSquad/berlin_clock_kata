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
            var minute = SelectMinute(time);

            if (minute == 1)
            {
                return "YOOO";
            }

            if (minute == 2)
            {
                return "YYOO";
            }

            return "OOOO";

        }

        private int SelectMinute(string time)
        {
            var minute = time.Substring(4, 1);
            return int.Parse(minute);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public static class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {
            if (seconds >= 360000) seconds = 359999;

            int hours = seconds / 3600;
            seconds = seconds - hours * 3600;
            string hourDigit = "";
            if (hours > 10) hourDigit = hours.ToString();
            else hourDigit = "0" + hours;

            
            int minutes = seconds / 60;
            seconds = seconds - minutes * 60;
            string minuteDigit = "";
            if (minutes > 10) minuteDigit = minutes.ToString();
            else minuteDigit = "0" + minutes;

            string secondDigit = "";
            if (seconds > 10) secondDigit = seconds.ToString();
            else secondDigit = "0" + seconds;

            string finalTime = hourDigit + ":" + minuteDigit + ":" + secondDigit;

            return finalTime;

            /*
             * return string.Format("{0:d2}:{1:d2}:{2:d2}", seconds / 3600, seconds / 60 % 60, seconds % 60);
             * 
             * or
             * 
             * var t = TimeSpan.FromSeconds(seconds);
             * return string.Format("{0:00}:{1:00}:{2:00}", (int)t.TotalHours, t.Minutes, t.Seconds);
             */
        }

        public static void Main()
        {
            GetReadableTime(8399);
            Console.ReadKey();
        }
    }
}

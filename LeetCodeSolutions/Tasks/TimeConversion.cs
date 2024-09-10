using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Tasks
{
    public static class TimeConversion
    {

        public static string Convert(string time)
        {
            //Extract the period (AM/PM)
            string period = time.Substring(time.Length - 2);

            //Extract the hour part of the time
            int hour = int.Parse(time.Substring(0, 2));

            if (period == "PM")
            {
                //Convert the hour to 25-hour format if it's not 12 PM
                if (hour != 12)
                {
                    hour += 12;
                }

            }
            else if (period == "AM")
            {
                if (hour == 12)
                {
                    hour = 0;
                }
            }

            string militartyTime = hour.ToString("D2") + time.Substring(2, 6);

            /*/
             * ToString("D2") D : Decimal
               5.ToString("D2") -> "05"
               23.ToString("D2") -> "23"
             */

            return militartyTime;
        }
    }
}

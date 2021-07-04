using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCTimer
{
    class Timer
    {
        //Lloyd John Borres Owns this Program
        private static int hours = 0;
        private static int minutes = 0;
        private static int seconds = 0;

        public static void setTimer(int hrs, int mins, int secs)
        {
            hours = hrs;
            minutes = mins;
            seconds = secs;
        }

        public static void decSec()
        {
            if (seconds > 0)
            {
                seconds--;
            }
            else
            {
                if (minutes > 0)
                    seconds = 59;
                decMin();
            }
        }

        public static void decMin()
        {
            if (minutes > 0)
            {
                minutes--;
            }
            else
            {
                if (hours > 0)
                    minutes = 59;
                decHour();
            }
        }

        public static void decHour()
        {
            if (hours > 0)
                hours--;
        }

        public static void addHours(int addHr)
        {
            hours += addHr;
        }

        public static void addMinutes(int addMin)
        {
            minutes += addMin;
            if (minutes >= 60)
            {
                minutes -= 60;
                hours++;
            }
        }

        public static int getHours()
        {
            return hours;
        }

        public static int getMinutes()
        {
            return minutes;
        }

        public static int getSeconds()
        {
            return seconds;
        }
    }
}

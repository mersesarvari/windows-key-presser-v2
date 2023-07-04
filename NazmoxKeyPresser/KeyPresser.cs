using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms.Design;
using Timer = System.Timers.Timer;

namespace NazmoxKeyPresser
{
    public static class KeyPresser
    {
        public static int MinTime = 300;
        public static int MaxTime = 500;
        public static int TickInterval = 100;

        public static int TickCounter { get; set; }

        public static void SetMinTime(int time) {
            MinTime = time;
        }

        public static void SetMaxTime(int time)
        {
            MinTime = time;
        }
        public static void SetTimer()
        {
            Random r = new Random();
            TickInterval= r.Next(MinTime, MaxTime);
        }
    }
}

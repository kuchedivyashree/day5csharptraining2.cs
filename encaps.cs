using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Time
    {
        public void DisplayCurrentTime( )
        {
            System.Console.WriteLine("Time\t: {0}/{1}/{2} {3}:{4}:{5}", month, date, year, hour,minute, second);

        }
        public Time(System.DateTime dt)
        {
            year = dt.Year;
            month = dt.Month;
            date = dt.Day;
            hour = dt.Hour;
            minute = dt.Minute;
            second = dt.Second;
        }
        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                hour = value;
            }
        }
        private int year;
        private int month;
        private int date;
        private int hour;
        private int minute;
        private int second;
    }
    public class Tester
    {
        static void Main()
        {
            System.DateTime currentTime = System.DateTime.Now;
            Time t = new Time(currentTime);
            t.DisplayCurrentTime();
            int theHour = t.Hour;
            System.Console.WriteLine("\nRetrived the hour:{0}\n", theHour);
            theHour++;
            t.Hour = theHour;
            System.Console.WriteLine("updated the hour:{0}\n", theHour);
            Console.ReadLine();
        }
    }
}

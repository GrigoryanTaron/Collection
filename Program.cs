using System;
using System.Collections.Generic;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DaysOfWeek day = new DaysOfWeek();
            //string s = day[1];
            Console.WriteLine(s);
            Console.ReadLine();
            foreach(var item in day)
            {

            }
        }
        public class DaysOfWeek
        {
            //private string[] _days = new string[7];
            List<string> _days = new List<string>();
            
            public DaysOfWeek()
            {
                //_days[0] = "Moday";
                //_days[1] = "Tuesday";
                //_days[2] = "Wednesday";
                //_days[3] = "Thursday";
                //_days[4] = "Friday";
                //_days[5] = "Saturday";
                //_days[6] = "Sunday";
                foreach (var item in _days)
                {
                    _days.Add("Moday");
                    _days.Add("Tuesday");
                    _days.Add("Wednesday");
                    _days.Add("Thursday");
                    _days.Add("Friday");
                    _days.Add("Saturday");


                }
            }

            //public string this[int index]
            //{
            //    get

            //    {
            //        if (index == 0)
            //            return "Moday";
            //        if (index == 1)
            //            return "Tuesday";
            //        if (index == 2)
            //            return "Wednesday";
            //        if (index == 3)
            //            return "Thursday";
            //        if (index == 4)
            //            return "Friday";
            //        if (index == 5)
            //            return "Saturday";
            //        if (index == 6)
            //            return "Sunday";

            //        else
            //            return "hello";
            //    }
           // }


        }
    }

}


using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek day = new DayOfWeek();

            foreach (var item in day)
            {
                Console.WriteLine($"{item}");
            }
        }
        public class DayOfWeek
        {
            List<string> _days = new List<string>();
            public DayOfWeek()
            {
                _days.Add("Moday");
                _days.Add("Tuesday");
                _days.Add("Wednesday");
                _days.Add("Thursday");
                _days.Add("Friday");
                _days.Add("Saturday");
                _days.Add("Sunday");
            }
            public DayOfWeekEnum GetEnumerator()
            {
                return new DayOfWeekEnum(_days);
            }
        }
        public class DayOfWeekEnum : IEnumerator
        {
            public List<string> _days;
            int position = -1;
            public DayOfWeekEnum(List<string> list)
            {
                _days = list;
            }
            public bool MoveNext()
            {
                position++;
                return (position < _days.Count);
            }
            public void Reset()
            {
                position = -1;
            }
         public   object Current
            {
                get
                {
                    return _days[position];
                }
            }
          
        }
    }
}


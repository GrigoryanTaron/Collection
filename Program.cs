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
        public class DayOfWeek : IEnumerable
        {
            //private string[] _days = new string[7];
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
            int position = -1;

            public object Current => _days;
            public IEnumerator GetEnumerator()
            {
                foreach (string item in _days)
                {
                     return GetEnumerator();
                }
               
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }


            public bool MoveNext()
            {
                position++;
                return position < _days.Count;
            }

            public void Reset()
            {
                position = -1;
            }


        }
        //
        // Summary:
        //     Exposes the enumerator, which supports a simple iteration over a collection of
        //     a specified type.
        //
        // Type parameters:
        //   T:
        //     The type of objects to enumerate.
        public interface IEnumerable : IEnumerator
        {
            //
            // Summary:
            //     Returns an enumerator that iterates through the collection.
            //
            // Returns:
            //     An enumerator that can be used to iterate through the collection.
            IEnumerator GetEnumerator();
        }
        public interface IEnumerator
        {
            //
            // Summary:
            //     Gets the element in the collection at the current position of the enumerator.
            //
            // Returns:
            //     The element in the collection at the current position of the enumerator.
            object Current { get; }

            //
            // Summary:
            //     Advances the enumerator to the next element of the collection.
            //
            // Returns:
            //     true if the enumerator was successfully advanced to the next element; false if
            //     the enumerator has passed the end of the collection.
            //
            // Exceptions:
            //   T:System.InvalidOperationException:
            //     The collection was modified after the enumerator was created.
            bool MoveNext();
            //
            // Summary:
            //     Sets the enumerator to its initial position, which is before the first element
            //     in the collection.
            //
            // Exceptions:
            //   T:System.InvalidOperationException:
            //     The collection was modified after the enumerator was created.
            void Reset();
        }
    }


}


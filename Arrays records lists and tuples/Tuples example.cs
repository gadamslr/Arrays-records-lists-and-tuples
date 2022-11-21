using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_records_lists_and_tuples
{
    internal class Tuples_example
    {
        public static void myTuple()
        {
            (string, int) animal_tuple = ("Dog", 4);

            Console.WriteLine("The {0} is {1} years of age.", animal_tuple.Item1, animal_tuple.Item2);

        }
    }
}

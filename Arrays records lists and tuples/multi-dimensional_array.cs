using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_records_lists_and_tuples
{
    internal class multi_dimensional_array
    {
        public static void my2D_array()
        {
            string[,] countries = new string[3, 2];

            countries[0, 0] = "Angola";
            countries[0, 1] = "1246700";
            countries[1, 0] = "Austria";
            countries[1, 1] = "83871";
            countries[2, 0] = "Belgium";
            countries[2, 1] = "30528";

            Console.WriteLine(countries[1,1]);

            Array_example.output_array(countries);

        }
    }
}
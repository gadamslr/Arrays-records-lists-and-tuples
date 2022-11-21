using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_records_lists_and_tuples
{
    internal class Array_example
    {

        public static void output_array(Array arrayParameter)
        {
            Console.WriteLine("\n---- Array values ----");

            foreach (var item in arrayParameter)
            {
                Console.WriteLine(item);
            }
        }

        public static void myArray()
        {
            //Store multiple variables of the same type in an array data structure

            //type[] arrayName;

            string[] nameArray = {"Jay","Rachel","Jane","Jac" };
            //string[] nameArray = new string[4]{"Jay","Rachel","Jane","Jac" };

            Console.WriteLine(nameArray[2]);

            output_array(nameArray);

            string[] countries = {"Angola", "Austria","Belgium" };

            output_array(countries);
            
            countries.Append("UK"); // Cannot APPEND to an array

            countries[2] = "Canada";
            output_array(countries);

        }
    }
}

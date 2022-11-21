using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_records_lists_and_tuples
{
    internal class Record_example
    {
        public struct TCar
        {
            // A structure type (or struct type) is a value type that can encapsulate data and related functionality. 
            public string Reg_Plate;
            public string Make;
            public string Model;
            public double Price;
            public double Engine_size;
            public bool Petol;
        }

        public static void myRecord()
        {
            TCar car1;
            car1.Reg_Plate = "VK134KE";
            car1.Make = "Fiat";
            car1.Model = "Punto";
            car1.Price = 14000;
            car1.Engine_size = 1.2;
            car1.Petol = true;

            foreach (var item in car1.GetType().GetFields())
            {
                Console.WriteLine("{0}: {1}", item.Name, item.GetValue(car1));
            }
        }
    }
}

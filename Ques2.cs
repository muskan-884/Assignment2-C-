using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Ques2
    {
        public static void Q2()
        {
            Console.Write("Enter temperature in Celsius: ");
            decimal celsius = Convert.ToDecimal(Console.ReadLine());

            decimal fahrenheit = (celsius * 9 / 5) + 32;

            if (celsius < 0)
            {
                Console.WriteLine("Warning: Freezing temperature!");
            }

            Console.WriteLine(celsius + "°C is equal to " + fahrenheit + "°F");
        }
    }
}

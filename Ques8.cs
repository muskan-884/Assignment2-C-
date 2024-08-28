using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Ques8
    {
        public static void Q8()
        {
            double[] expenses = new double[12];
            double totalExpenses = 0;
            int highestMonth = 0, lowestMonth = 0;

            for (int i = 0; i < 12; i++)
            {
                Console.Write($"Enter expenses for month {i + 1}: ");
                expenses[i] = Convert.ToDouble(Console.ReadLine());
                totalExpenses += expenses[i];

                if (expenses[i] > expenses[highestMonth])
                {
                    highestMonth = i;
                }
                if (expenses[i] < expenses[lowestMonth])
                {
                    lowestMonth = i;
                }
            }

            Console.WriteLine("Total expenses for the year: Rs. " + totalExpenses);
            Console.WriteLine($"Highest expenses were in month {highestMonth + 1} with Rs. {expenses[highestMonth]}");
            Console.WriteLine($"Lowest expenses were in month {lowestMonth + 1} with Rs. {expenses[lowestMonth]}");
        }
    }
}

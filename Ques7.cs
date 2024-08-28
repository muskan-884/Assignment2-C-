using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Ques7
    {
        public static void Q7()
        {
            bool[] attendance = new bool[5];
            int daysAttended = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Day {i + 1} attendance (y/n): ");
                string input = Console.ReadLine().ToLower();
                attendance[i] = (input == "y");
                if (attendance[i])
                {
                    daysAttended++;
                }
            }

            Console.WriteLine("Total days attended: " + daysAttended);
            if (daysAttended == 5)
            {
                Console.WriteLine("Perfect attendance!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Ques6
    {
        public static void Q6()
        {
            Console.Write("Enter distance traveled (in km): ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the time of ride (24-hour format): ");
            int time = Convert.ToInt32(Console.ReadLine());

            double fare = 20;
            if (distance > 2)
            {
                fare += (distance - 2) * 10;  
            }

            if (time >= 22 || time < 6)  
            {
                fare *= 1.25; 
            }

            Console.WriteLine("Total fare: Rs. " + fare);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Ques10
    {
        public static void Q10() {
            Console.Write("Enter hourly wage: ");
            double hourlyWage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter hours worked per week: ");
            double hoursPerWeek = Convert.ToDouble(Console.ReadLine());

            double monthlySalary = hourlyWage * hoursPerWeek * 4;
            Console.WriteLine("Monthly Salary: Rs. " + monthlySalary);

            Console.Read();
        }
    }
}

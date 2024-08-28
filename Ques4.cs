using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Ques4
    {
        public static void Q4()
        {
            double[] marks = new double[5];
            double total = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter marks for subject {i + 1}: ");
                marks[i] = Convert.ToDouble(Console.ReadLine());
                total += marks[i];
            }

            double average = total / 5;
            char grade;

            if (average >= 90)
                grade = 'A';
            else if (average >= 80)
                grade = 'B';
            else if (average >= 70)
                grade = 'C';
            else if (average >= 60)
                grade = 'D';
            else
                grade = 'F';

            Console.WriteLine($"Average Marks: {average}");
            Console.WriteLine($"Grade: {grade}");
        }
    }
}

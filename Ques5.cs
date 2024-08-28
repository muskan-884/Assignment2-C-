using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Ques5
    {
        public static void Q5()
        {
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            bool isValid = password.Length >= 8 &&
                           Regex.IsMatch(password, "[A-Z]") &&
                           Regex.IsMatch(password, "[a-z]") &&
                           Regex.IsMatch(password, "[0-9]");

            if (isValid)
            {
                Console.WriteLine("Password is valid.");
            }
            else
            {
                Console.WriteLine("Password must be at least 8 characters long, contain at least one uppercase letter, one lowercase letter, and one number.");
            }
        }
    }
}

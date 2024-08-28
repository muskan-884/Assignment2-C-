using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Ques3
    {
        public static void Q3()
        {
            double balance = 5000.00;
            int choice;

            do
            {
                Console.WriteLine("\nATM Menu:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Your balance is Rs. " + balance);
                        break;
                    case 2:
                        Console.Write("Enter amount to deposit: ");
                        double deposit = Convert.ToDouble(Console.ReadLine());
                        balance += deposit;
                        Console.WriteLine("Your new balance is Rs. " + balance);
                        break;
                    case 3:
                        Console.Write("Enter amount to withdraw: ");
                        double withdraw = Convert.ToDouble(Console.ReadLine());
                        if (withdraw <= balance)
                        {
                            balance -= withdraw;
                            Console.WriteLine("Your new balance is Rs. " + balance);
                        }
                        else
                        {
                            Console.WriteLine("Insufficient funds.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using the ATM.");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            } while (choice != 4);
        }
    }
}

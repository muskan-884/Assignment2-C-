using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Ques1
    {
        public static void Q1()
        {
            double[] prices = { 500, 800, 200, 1500, 1000 };
            double totalPrice = 0;

            foreach (double price in prices)
            {
                totalPrice += price;
            }

            double discount = 0;
            if (totalPrice > 3000)
            {
                discount = totalPrice * 0.1;
            }

            double finalPrice = totalPrice - discount;

            Console.WriteLine("Total Price: Rs. " + totalPrice);
            if (discount > 0)
            {
                Console.WriteLine("Discount: Rs. " + discount);
            }
            Console.WriteLine("Final Price: Rs. " + finalPrice);
        }
    }
}

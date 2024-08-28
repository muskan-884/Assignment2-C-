using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Ques9
    {
        public static void Q9() {
            List<(string name, double price)> cart = new List<(string, double)>();
            int choice;

            do
            {
                Console.WriteLine("\nShopping Cart Menu:");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Remove Item");
                Console.WriteLine("3. View Cart");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter item name: ");
                        string itemName = Console.ReadLine();
                        Console.Write("Enter item price: ");
                        double itemPrice = Convert.ToDouble(Console.ReadLine());
                        cart.Add((itemName, itemPrice));
                        break;
                    case 2:
                        Console.Write("Enter item name to remove: ");
                        string removeItem = Console.ReadLine();
                        cart.RemoveAll(item => item.name == removeItem);
                        break;
                    case 3:
                        double totalPrice = 0;
                        Console.WriteLine("Items in Cart:");
                        foreach (var item in cart)
                        {
                            Console.WriteLine($"{item.name}: Rs. {item.price}");
                            totalPrice += item.price;
                        }
                        Console.WriteLine("Total Price: Rs. " + totalPrice);
                        break;
                    case 4:
                        Console.WriteLine("Exiting the shopping cart system.");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            } while (choice != 4);
        }
    }
}

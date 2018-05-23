using System;
using System.Collections.Generic;

namespace CandyShop
{
    public class Candyshop
    {
        public static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            Console.WriteLine(Sweets(fagyi));
            Console.ReadLine();
            // Expected output: "Cupcake", "Croissant", "Brownie", "Ice cream"
        }
        public static string Sweets(List<object> fagyi)
            
        {
            string fill = string.Empty;
            
            foreach (var item in fagyi)
            {
                if (item is string)
                {
                    fill += item;
                }
                else if (item is int)
                {
                    fill += "Croissant, ";
                }
                else if (item is bool)
                {
                    fill += "Ice cream, ";
                }
            }
            return fill;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

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

            // Accidentally we added "2" and "false" to the list.
            // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
            // No, don't just remove the lines
            // Create a method called Sweets() which takes the list as a parameter.

            Console.WriteLine(Sweets(list));
            // Expected output: "Cupcake", "Croissant", "Brownie", "Ice cream"
        }
        public static string Sweets(List<object> list)
        {
            StringBuilder stringbuilder = new StringBuilder();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].GetType() == typeof(bool))
                {
                    list[i] = "\"Ice Cream\", ";
                    stringbuilder.Append(list[i]);
                }
                else if (list[i].GetType() == typeof(int))
                {
                    list[i] = "\"Croissant\", ";
                    stringbuilder.Append(list[i]);
                }
                else
                {
                    stringbuilder.Append($"\"{list[i]}\", ");
                }
            }
            stringbuilder.Remove(stringbuilder.Length - 2, 2);
            return stringbuilder.ToString();
        }
    }
}
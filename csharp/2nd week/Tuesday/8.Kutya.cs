using System;
using System.Collections.Generic;
using System.Text;

namespace AppendLetter
{
    public class AppendLetter
    {
        public static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            // Create a method called AppendA() that adds "a" to every string in the far list.
            // The parameter should be a list.

            Console.WriteLine(AppendA(far));
            Console.ReadLine();

            // Expected output: "kutya", "macska", "kacsa", "róka", "halacska"
        }

        // public static List<string> AppendA(List<string> animalList)
        // {
           // string suffix = "a";

            // StringBuilder animal = new StringBuilder();
            // animal.Append(suffix);
            // MyList = sb.ToString();
            // return animalList;


            // List<string> newAnimList = new List<string>();

            // foreach (string s in animalList)
            // {
            //     newAnimList.Add(string.Format("{0}", suffix));
            // }
            // return newAnimList;
            public static StringBuilder AppendA(List<string> far)
            {

                StringBuilder appendAFar = new StringBuilder();

                for (int i = 0; i < far.Count; i++)

                {

                    appendAFar.Append(far[i] + "a ");

                }

                return appendAFar;

            }
        }
}
using System;

namespace Doubling
{
    class Program
    {
        static void Main(string[] args)
        {
                // - Create a string variable named `al` and assign the value `Greenfox` to it
                // - Create a function called `greet` that greets it's input parameter
                //     - Greeting is printing e.g. `Greetings dear, Greenfox`
                // - Greet `al`
            string a1;
            a1 = "Greenfox";
            string a2 = "MyFriend";
   
            Console.WriteLine(greet(a2, a1));
            Console.ReadLine();
        }
        static string greet(string str2, string str1)
        {
            return "Greetings, dear, " + str1 + " " + str2;
        }
    }
}

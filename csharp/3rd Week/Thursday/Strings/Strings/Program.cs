using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine(StringChanger("xoxo"));
            Console.ReadLine();
        
            // Given a string, compute recursively (no loops) a new string where all the
            // lowercase 'x' chars have been changed to 'y' chars.   
        }
        public static string StringChanger(string Chain)
        {
            if (Chain.Length == 0)
            {
                return "";
            }
            else
            {
            return Chain.Replace("x", "y") + StringChanger(Chain.Remove(0));
            }
        }
    }
}
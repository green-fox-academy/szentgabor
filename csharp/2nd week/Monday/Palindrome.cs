﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            string manki = "Majom";

            Console.WriteLine(CreatePalindrome(manki));
            Console.ReadLine();
        }
        static string CreatePalindrome(string potentialPalindrome)
        {
            string palindrome = potentialPalindrome;

            // ezt a felső palindrome-ot el is lehet hagyni, és csak a potentialt használni, de akkor lent is át kell írni, ezt stíluskérdés

            for (int i = potentialPalindrome.Length - 1; i >= 0; i--)
            {
                palindrome += potentialPalindrome[i];
            }
            return palindrome;
        }
    }
}

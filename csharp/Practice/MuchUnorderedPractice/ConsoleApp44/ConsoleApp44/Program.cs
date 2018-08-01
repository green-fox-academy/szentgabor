using System;
using System.Collections.Generic;

namespace Matchmaking
{
    public class Matchmaking
    {
        public static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };

            // Write a method that joins the two lists by matching one girl with one boy into a new list
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...

            Console.WriteLine(MakingMatches(girls, boys));
            Console.ReadLine();
        }
        public static string MakingMatches(List<string> girlz, List<string> boyz)
        {
            int NumberofPairs = 0;
            string Pairs = "";

            if (girlz.Count > boyz.Count)

            {
                NumberofPairs = boyz.Count;
            }

            else if (girlz.Count < boyz.Count)
            {
                NumberofPairs = girlz.Count;
            }

            else if (girlz.Count == boyz.Count)
            {
                NumberofPairs = girlz.Count;
            }
            for (int i = 0; i < NumberofPairs; i++)
            {
                Pairs += girlz[i] + ", " + boyz[i] + ", ";
            }
            Pairs=Pairs.Substring(0, Pairs.Length - 2);
            return Pairs;
        
          }  
      }
}
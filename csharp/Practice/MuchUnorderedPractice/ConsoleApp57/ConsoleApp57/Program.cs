﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp57
{
    class Program
    {
        static void Main(string[] args)
        {
            BlogPost LoremIpsum = new BlogPost("John Doe","Lorem Ipsum","Lorem ipsum dolor sit amet.",new DateTime(2000,05,04));
            BlogPost WaitButWhy = new BlogPost("Tim Urban", "Wait but why", "A popular long-form, stick-figure-illustrated blog about almost everything.", new DateTime(2010,10,10));
            BlogPost Engineer = new BlogPost("William Turton", "One Engineer Is Trying to Get IBM to Reckon With Trump", "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention.When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.", new DateTime(2017,03,28));

            Console.WriteLine(LoremIpsum.AuthorName);
            Console.ReadKey();
        }
    }
}

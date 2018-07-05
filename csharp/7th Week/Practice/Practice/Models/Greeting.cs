using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Models
{
    public class Greeting
    {
        static int id = 1;

        public Greeting()
        {
        }

        public Greeting(string name)
        {
            Content = name;
            Id = id++;
        }

        public long Id { get; set; }
        public string Content { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Meme
    {
        public Meme(int id, string name, string text)
        {
            Id = id;
            Name = name;
            Text = text;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
    }
}

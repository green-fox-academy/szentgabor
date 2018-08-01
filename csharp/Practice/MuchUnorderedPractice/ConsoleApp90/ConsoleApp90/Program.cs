using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp90
{
    class Program
    {
        static void Main(string[] args)
        {
            BlogPost blogPost1 = new BlogPost("Gergő", "A Kis-Balaton vad világa", "Sejj de szépen inganak-ringanak fellegén a Balatonnak nyári napnak sűrű felhőzetei.", "2001.11.29.");
            Console.WriteLine(blogPost1.author);
        }
    }
    class BlogPost
    {
        public string author;
        string title;
        string text;
        string publicationDate;

        public BlogPost(string author, string title, string text, string publicationDate)
        {
            this.author = author;
            this.title = title;
            this.text = text;
            this.publicationDate = publicationDate;
        }
    }
}

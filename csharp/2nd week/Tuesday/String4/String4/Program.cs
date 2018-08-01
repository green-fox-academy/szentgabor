using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String4
{
    class Program
    {
        static void Main(string[] args)
        {
            string todoText = " - Brumm\n";
            string newTodoText = todoText.Insert(0, "My todo(s):\n");
            newTodoText += " - Brummogni\n" + "\t- Cammogni\n";
            newTodoText += " - Dubi-dubi\n";
            Console.WriteLine(newTodoText);
            Console.ReadLine();
        }
    }
}

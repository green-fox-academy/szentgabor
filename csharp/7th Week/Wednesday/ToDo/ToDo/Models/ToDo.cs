using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models
{
    public class ToDoItem
    {
        private static int IdCounter = 1;

        public ToDoItem(string name)
        {
            ID = IdCounter;
            IdCounter++;
            Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public bool Checked { get; set; }
        public bool Urgent { get; set; }
    }
}

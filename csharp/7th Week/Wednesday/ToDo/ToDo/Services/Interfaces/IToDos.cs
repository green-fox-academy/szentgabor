using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Models;

namespace ToDo.Services.Interfaces
{
    public interface IToDos
    {
        void Add(List<ToDoItem> toDos, string name);
        void Check(List<ToDoItem> toDos, int id);
        void Delete(List<ToDoItem> toDos, int id);
        void IsUrgent(List<ToDoItem> toDos, int id);
    }
}

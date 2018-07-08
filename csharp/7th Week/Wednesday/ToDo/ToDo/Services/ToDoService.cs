using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Controllers;
using ToDo.Models;
using ToDo.Services.Interfaces;

namespace ToDo.Services
{
    public class ToDoService : IToDos
    {
        public void Add(List<ToDoItem> toDos, string name)
        {
            // ToDoController.model.toDos.Add(new ToDoItem(name));
            toDos.Add(new ToDoItem(name));
        }

        public void Check(List<ToDoItem> toDos, int id)
        {
            // var selectedToDoItem = toDos.Where(n => n.ID == id).First();
            // selectedToDoItem.Checked = !selectedToDoItem.Checked;
            for (int i = 0; i < toDos.Count; i++)
            {
                if (toDos[i].ID == id)
                {
                    toDos[i].Checked = !toDos[i].Checked;
                }
            }
            
        }

        public void Delete(List<ToDoItem> toDos, int id)
        {
            for (int i = 0; i < toDos.Count; i++)
            {
                if (toDos[i].ID == id)
                {
                    toDos.Remove(toDos[i]);
                }
            }
        }

        public void IsUrgent(List<ToDoItem> toDos, int id)
        {
            for (int i = 0; i < toDos.Count; i++)
            {
                if (toDos[i].ID == id)
                {
                    toDos[i].Urgent = !toDos[i].Urgent;
                }
            }
        }
    }
}

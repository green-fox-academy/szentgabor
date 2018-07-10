using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Repositories
{
    public class TodoRepository : ICRUD<Todo>
    {
        private TodoDbContext toDoContext;

        public TodoRepository(TodoDbContext toDoContext)
        {
            this.toDoContext = toDoContext;
        }

        public void Create(Todo element)
        {
            toDoContext.Add(element);
            toDoContext.SaveChanges();
        }

        public void Delete(Todo element)
        {
            toDoContext.Remove(element);
            toDoContext.SaveChanges();
        }

        public List<Todo> GetAllElements()
        {
            return toDoContext.Todos.ToList();
        }

        public Todo GetRecordById(long id)
        {
            return toDoContext.Todos.ToList().FirstOrDefault(x => x.Id == id);
        }

        public void Update(Todo element)
        {
            toDoContext.Update(element);
            toDoContext.SaveChanges();
        }
    }
}

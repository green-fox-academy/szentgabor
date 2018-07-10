using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models;
using ToDoList.Repositories;

namespace ToDoList.Services
{
    public class TodoService : ITodoService
    {
        private ICRUD<Todo> todoRepository;

        public TodoService(ICRUD<Todo> todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        public void CreateTodo(Todo todo)
        {
            todoRepository.Create(todo);
        }

        public Todo GetTodoById(long id)
        {
            return todoRepository.GetRecordById(id);
        }

        public List<Todo> GetTodos()
        {
            return todoRepository.GetAllElements();
        }

        public void RemoveTodo(long id)
        {
            todoRepository.Delete(todoRepository.GetRecordById(id));
        }

        public void UpdateTodo(Todo todo)
        {
            todoRepository.Update(todo);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Services
{
    public interface ITodoService
    {
        List<Todo> ReturnFilteredTodos(bool isActive);
        List<Todo> GetTodos();
        Todo GetTodoById(long id);
        void CreateTodo(Todo todo);
        void UpdateTodo(Todo todo);
        void RemoveTodo(long id);
    }
}

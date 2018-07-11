using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using ToDoList.Repositories;
using ToDoList.Services;

namespace ToDoList.Controllers
{
    [Route ("/todo")]
    public class TodoController : Controller
        {
        private ITodoService todoService;
        private TodoDbContext todoDbContext;

        public TodoController(ITodoService todoService, TodoDbContext todoDbContext)
        {
            this.todoService = todoService;
            this.todoDbContext = todoDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route ("")]
        [Route ("list")]
        public IActionResult List()
        {
            return View(todoService.GetTodos());
        }

        [HttpGet]
        [Route("getdone")]
        public IActionResult GetDone(bool isActive)
        {
            IEnumerable<Todo> filteredTodos = (isActive == true) ?
                (todoDbContext.Todos.ToList().Where(x => x.IsDone == false)) :
                (todoDbContext.Todos.ToList());
            
            return Json(filteredTodos);
        }

        [HttpGet("add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost("add")]
        public IActionResult AddTodo(Todo todo)
        {
            todoService.CreateTodo(todo);
            return RedirectToAction("list");
        }

        [HttpPost("/{id}/delete")]
        public IActionResult DeleteTodo(long id)
        {
            todoService.RemoveTodo(id);
            return RedirectToAction("list");
        }

        [HttpGet("/{id}/edit")]
        public IActionResult Edit(long id)
        {
            return View(todoService.GetTodoById(id));
        }

        [HttpPost("/{id}/edit")]
        public IActionResult EditTodo(Todo todo)
        {
            todoService.UpdateTodo(todo);
            return RedirectToAction("list");
        }
    }
}
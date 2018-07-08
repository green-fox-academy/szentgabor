using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo.Models;
using ToDo.Services.Interfaces;
using ToDo.ViewModels;

namespace ToDo.Controllers
{
    public class ToDoController : Controller
    {
        public static ToDoViewModel model = new ToDoViewModel();

        private IToDos iToDo;

        public ToDoController(IToDos iToDo)
        {
            this.iToDo = iToDo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(model);
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(string name)
        {
            iToDo.Add(model.toDos, name);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("check")]
        public IActionResult Check(int id)
        {
            iToDo.Check(model.toDos, id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("delete")]
        public IActionResult Delete(int id)
        {
            iToDo.Delete(model.toDos, id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("urgent")]
        public IActionResult Urgent(int id)
        {
            iToDo.IsUrgent(model.toDos, id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("try")]
        public IActionResult Try(int[] proba)
        {
            for (int i = 0; i < proba.Length; i++)
            {
                proba[i] = proba[i] * 2;
            }
            return View(proba);
        }
    }
}
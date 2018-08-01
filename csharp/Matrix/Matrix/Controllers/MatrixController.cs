using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Matrix.Models;
using Matrix.Services;
using MatrixExam.Viewmodels;
using Microsoft.AspNetCore.Mvc;

namespace Matrix.Controllers
{
    public class MatrixController : Controller
    {
        private MatrixService matrixService;
        private Viewmodel viewmodel;

        public MatrixController(MatrixService matrixService)
        {
            this.matrixService = matrixService;
            viewmodel = new Viewmodel();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost("addmatrix")]
        public IActionResult AddMatrix(string matrix)
        {
            try
            {
                matrixService.MatrixChecker(matrix);
                viewmodel.Message = "Your matrix has been successfully saved.";
                viewmodel.MatrixIsValid = true;
            }
            catch (Exception e)
            {
                viewmodel.Message = e.Message;
                viewmodel.MatrixIsValid = false;
            }
            return View(viewmodel);
        }

        [HttpGet]
        [Route("matrices")]
        public IActionResult List()
        {
            return View(matrixService.GetMatrixes());
        }
    }
}
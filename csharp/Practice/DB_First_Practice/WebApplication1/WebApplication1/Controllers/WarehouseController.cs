using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route ("/warehouse")]
    public class WarehouseController : Controller
    {
        private warehouseContext warehouseContext;

        public WarehouseController(warehouseContext warehouseContext)
        {
            this.warehouseContext = warehouseContext;
        }

        [HttpGet("get")]
        public IActionResult Get()
        {
            return Json(warehouseContext.Warehouse.ToList());
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
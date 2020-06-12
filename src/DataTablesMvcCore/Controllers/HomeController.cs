using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DataTablesMvcCore.Models;
using DataTables.AspNet.Core;
using DataTablesMvcCore.Data;
using DataTablesMvcCore.DataModel;
using DataTables.AspNet.AspNetCore;

namespace DataTablesMvcCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DataLoad()
        {
            return View();
        }

        public IActionResult DataAjax()
        {
            return View();
        }

        public IActionResult DataAjaxPagination()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

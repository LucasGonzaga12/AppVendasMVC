using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using System.Web;
using System.Collections.Generic;

namespace SalesWebMVC.Controllers
{
    public class Departments : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletronicos" });
            list.Add(new Department { Id = 2, Name = "Roupas" });
            return View(list);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using System.Collections.Generic;

namespace SalesWebMVC.Controllers
{
    public class contato : Controller
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

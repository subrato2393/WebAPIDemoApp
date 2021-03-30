using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCallJquery.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAll()
        {
            return View();
        }
        public IActionResult Add()
        
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Add()
        //{
        //    return View();
        //}
    }
}

using Microsoft.AspNetCore.Mvc;
using Mvc.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Mvc.Controllers
{
    public class StudentsController : Controller 
    {
        public async Task<IActionResult> Index()
        {
            List<StudentModel> reservationList = new List<StudentModel>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44325/api/students"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservationList = JsonConvert.DeserializeObject<List<StudentModel>>(apiResponse);
                }
            }
            return View(reservationList);
        }
    }
}

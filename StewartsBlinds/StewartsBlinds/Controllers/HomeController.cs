using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StewartsBlinds.Data;
using StewartsBlinds.Models;
using Microsoft.AspNetCore.Authorization;

namespace StewartsBlinds.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private ApplicationDbContext context;

        public HomeController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index(DateTime? fromDate)
        {
            if(fromDate == null && TempData.Keys.Contains("LastFromDate"))
            {
                fromDate = (DateTime)TempData["LastFromDate"];
            }
            
            if(fromDate != null)
            {
                TempData["LastFromDate"] = fromDate;
            }

            var viewModel = new CalendarViewModel
            {
                Appointments = context.Appointments.Where(x => !x.IsDeleted).ToList(),
                SalesUsers = context.SalesUsers.ToList(),
                FromDate = fromDate
            };
            return View(viewModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

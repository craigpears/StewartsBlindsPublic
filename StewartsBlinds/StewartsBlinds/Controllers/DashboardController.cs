using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StewartsBlinds.Data;
using StewartsBlinds.Models;

namespace StewartsBlinds.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private ApplicationDbContext context;

        public DashboardController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var viewModel = new DashboardViewModel
            {
                OrdersFunnel = new OrdersFunnelViewModel
                {
                    NotOrdered = context.Appointments.Count(x => x.OrderPlaced == null),
                    Pending = context.Appointments.Include(x => x.Payments).Count(x => x.OrderPlaced == false),
                    Ordered = context.Appointments.Include(x => x.Payments).Count(x => x.OrderPlaced == true && !x.FullyPaid),
                    PaymentTaken = context.Appointments.Include(x => x.Payments).Where(x => x.OrderPlaced == true && x.Payments.Any()).ToList().Count(x => !x.FullyPaid),
                    FullyPaid = context.Appointments.Include(x => x.Payments).Where(x => x.OrderPlaced == true).ToList().Count(x => x.FullyPaid),
                },
                ProductTypeBarChart = new ProductTypeBarChartViewModel
                {
                    Counts = context.QuoteLines.GroupBy(x => x.ProductType).Select(x => new ProductTypeBarChartViewModelCount
                    {
                        ProductType = x.Key,
                        Count = x.Count()
                    }).ToList()
                }
            };
            return View(viewModel);
        }
    }
}
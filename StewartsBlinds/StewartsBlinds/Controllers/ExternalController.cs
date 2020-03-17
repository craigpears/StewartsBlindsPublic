using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StewartsBlinds.Data;
using Microsoft.EntityFrameworkCore;
using StewartsBlinds.Models;

namespace StewartsBlinds.Controllers
{
    public class ExternalController : Controller
    {
        private ApplicationDbContext context;

        public ExternalController(ApplicationDbContext context)
        {
            this.context = context;
        }
        
        public IActionResult ViewOrderPdf(int id)
        {
            var order = context
                .Appointments
                .Include(x => x.Payments)
                .Include(x => x.QuoteLines)
                .Include(x => x.SalesUser)
                .Single(x => x.Id == id);

            return View(order);
        }

        public IActionResult ViewPaymentSheetPdf(DateTime fromDate)
        {
            var viewModel = new PaymentSheetsViewModel
            {
                Payments = context
                    .Payments
                    .Include(x => x.Appointment)
                    .Where(x => x.CreatedDate >= fromDate && x.CreatedDate <= fromDate.AddDays(7))
                    .ToList(),
                FromDate = fromDate
            };

            return View(viewModel);
        }
    }
}
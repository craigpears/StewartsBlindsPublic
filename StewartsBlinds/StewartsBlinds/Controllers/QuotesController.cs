using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using StewartsBlinds.Data;
using StewartsBlinds.Models;
using StewartsBlinds.Data.Entities;

namespace StewartsBlinds.Controllers
{
    [Authorize]
    public class QuotesController : Controller
    {
        private ApplicationDbContext context;

        public QuotesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult AddLine(int AppointmentId)
        {
            var viewModel = new AddQuoteLineViewModel
            {
                AppointmentId = AppointmentId
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddLine(QuoteLine quoteLine)
        {
            context.QuoteLines.Add(quoteLine);
            context.SaveChanges();

            return RedirectToAction("EditLine", new { id = quoteLine.Id });
        }

        public IActionResult EditLine(int id, bool editAll)
        {
            var quoteLine = context.QuoteLines.Single(x => x.Id == id);

            var viewModel = new EditQuoteLineViewModel
            { 
                EditAll = editAll,
                QuoteLine = quoteLine,
                ConfigurationOptions = context.ConfigurationOptions.Where(x => x.ProductType == quoteLine.ProductType).ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult EditLine(QuoteLine quoteLine)
        {
            context.Entry(quoteLine).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("View", "Appointments", new { AppointmentId = quoteLine.AppointmentId });
        }

        public IActionResult DeleteLine(int id)
        {
            var quoteLine = context.QuoteLines.Single(x => x.Id == id);
            context.Entry(quoteLine).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            context.SaveChanges();
            return RedirectToAction("View", "Appointments", new { AppointmentId = quoteLine.AppointmentId });
        }

        public IActionResult Finalise(int id)
        {
            var appointment = context.Appointments.Single(x => x.Id == id);
            var viewModel = new FinaliseQuoteViewModel
            {
                Appointment = appointment
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Finalise(Appointment updates)
        {
            var appointment = context.Appointments.Single(x => x.Id == updates.Id);
            appointment.FinalisedDate = DateTime.Now;
            appointment.PriceQuoted = updates.PriceQuoted;
            appointment.SpecialInstructions = updates.SpecialInstructions;
            appointment.OrderPlaced = updates.OrderPlaced;
            appointment.OrderSigned = updates.OrderSigned;
            appointment.TermsAndConditionsLeft = updates.TermsAndConditionsLeft;
            context.SaveChanges();

            TempData["Success"] = $"Order finalised.  <a href='/Payments/Add?AppointmentId={appointment.Id}&isDeposit=true'>Add Deposit</a>";

            return RedirectToAction("View", "Appointments", new { AppointmentId = updates.Id });
        }
    }
}
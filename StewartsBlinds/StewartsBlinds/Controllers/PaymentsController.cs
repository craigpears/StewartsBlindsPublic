using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using StewartsBlinds.Data;
using StewartsBlinds.Models;
using Microsoft.EntityFrameworkCore;
using StewartsBlinds.Data.Entities;
using SelectPdf;
using System.Net.Http;
using Api2PdfLibrary;

namespace StewartsBlinds.Controllers
{
    [Authorize]
    public class PaymentsController : Controller
    {
        private ApplicationDbContext context;

        public PaymentsController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var viewModel = new PaymentsViewModel
            {
                Payments = context.Payments.ToList()
            };

            return View(viewModel);
        }

        public IActionResult PaymentSheets()
        {
            var viewModel = new PaymentSheetsViewModel
            {
                Payments = context.Payments.ToList()
            };

            return View(viewModel);
        }

        public IActionResult PaymentSheet(DateTime fromDate)
        {
            HtmlToPdf converter = new HtmlToPdf();
            converter.Options.PdfPageOrientation = PdfPageOrientation.Landscape;
            string url = this.Url.Action("ViewPaymentSheetPdf", "External", new { fromDate }, "https");


            HttpClient httpClient = new HttpClient();
            string html = httpClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;

            var apiToPdfClient = new Api2Pdf("");
            var apiResponse = apiToPdfClient.HeadlessChrome.FromHtml(html, inline: true, outputFileName: "PaymentSheet" + fromDate.ToString("dd/MM/yyyy") + ".pdf");
            return Redirect(apiResponse.Pdf);
        }

        public IActionResult Add(int AppointmentId, bool isDeposit = false)
        {
            var viewModel = new AddPaymentViewModel
            {
                Appointment = context.Appointments.Include(x => x.Payments).Single(x => x.Id == AppointmentId),
                IsDeposit = isDeposit
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Add(Payment payment)
        {
            payment.CreatedDate = DateTime.Now;
            context.Payments.Add(payment);
            context.SaveChanges();
            return RedirectToAction("View", "Appointments", new { AppointmentId = payment.AppointmentId });
        }

        public IActionResult ConfirmPayment(int id)
        {
            var payment = context.Payments.Single(x => x.Id == id);
            payment.Confirmed = true;
            payment.TakenBy = Environment.UserName;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

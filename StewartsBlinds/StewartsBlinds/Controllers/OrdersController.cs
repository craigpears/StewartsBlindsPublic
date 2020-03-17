using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StewartsBlinds.Data;
using Microsoft.AspNetCore.Authorization;
using StewartsBlinds.Models;
using Microsoft.EntityFrameworkCore;
using SelectPdf;
using System.IO;
using Api2PdfLibrary;
using System.Net;
using System.Net.Http;

namespace StewartsBlinds.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private ApplicationDbContext context;

        public OrdersController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index(OrdersFilter OrdersFilter)
        {
            var viewModel = new OrdersViewModel
            {
                Orders = context.Appointments.Include(x => x.Payments).Where(x => x.OrderPlaced != null && !x.IsDeleted).OrderByDescending(x => x.FinalisedDate).ToList(),
                OrdersFilter = OrdersFilter
            };
            return View(viewModel);
        }

        public IActionResult Pdf(int id)
        {
            string url = this.Url.Action("ViewOrderPdf", "External", new { id }, "https");
            HttpClient httpClient = new HttpClient();
            string html = httpClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;

            var apiToPdfClient = new Api2Pdf("");
            var options = new Dictionary<string, string>
            {
                { "landscape", "true" }
            };
            var apiResponse = apiToPdfClient.HeadlessChrome.FromHtml(html, inline:true, outputFileName: "Order" + id + ".pdf", options: options);
            return Redirect(apiResponse.Pdf);
        }

        public IActionResult MarkSeenByOffice(int id)
        {
            context.Appointments.Single(x => x.Id == id).SeenByOffice = true;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult MarkSeenByFactory(int id)
        {
            context.Appointments.Single(x => x.Id == id).SeenByFactory = true;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult MarkPartReady(int id)
        {
            context.Appointments.Single(x => x.Id == id).OrderStatus = OrderStatus.PartReady;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult MarkReady(int id)
        {
            context.Appointments.Single(x => x.Id == id).OrderStatus = OrderStatus.ReadyToBeFit;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
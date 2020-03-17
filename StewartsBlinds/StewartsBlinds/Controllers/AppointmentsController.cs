using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StewartsBlinds.Data;
using StewartsBlinds.Data.Entities;
using StewartsBlinds.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace StewartsBlinds.Controllers
{
    [Authorize]
    public class AppointmentsController : Controller
    {
        private ApplicationDbContext context;

        public AppointmentsController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult View(int AppointmentId)
        {
            var viewModel = new AppointmentViewModel
            {
                Appointment = context
                    .Appointments
                    .Include(x => x.SalesUser)
                    .Include(x => x.QuoteLines)
                    .Include(x => x.Payments)
                    .Single(x => x.Id == AppointmentId)
            };
            return View(viewModel);
        }

        public IActionResult Add(AddAppointmentViewModel viewModel)
        {
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Add(Appointment appointment)
        {
            context.Appointments.Add(appointment);
            context.SaveChanges();
            TempData["Success"] = $"Appointment successfully created <a href='/Appointments/View?AppointmentId={appointment.Id}'>View</a>";
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Edit(int AppointmentId)
        {
            var viewModel = new EditAppointmentViewModel
            {
                Appointment = context.Appointments.Single(x => x.Id == AppointmentId),
                SalesUsers = context.SalesUsers.ToList()
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(Appointment appointment)
        {
            var dbAppointment = context.Appointments.Single(x => x.Id == appointment.Id);

            dbAppointment.Title = appointment.Title;
            dbAppointment.Surname = appointment.Surname;
            dbAppointment.CompanyName = appointment.CompanyName;
            dbAppointment.CustomerType = appointment.CustomerType;
            dbAppointment.Address1 = appointment.Address1;
            dbAppointment.Address2 = appointment.Address2;
            dbAppointment.Town = appointment.Town;
            dbAppointment.County = appointment.County;
            dbAppointment.Postcode = appointment.Postcode;
            dbAppointment.Telephone = appointment.Telephone;
            dbAppointment.AlternativeTelephone = appointment.AlternativeTelephone;
            dbAppointment.Email = appointment.Email;

            dbAppointment.SameAsOrderAddress = appointment.SameAsOrderAddress;
            dbAppointment.DeliveryAddress1 = appointment.DeliveryAddress1;
            dbAppointment.DeliveryAddress2 = appointment.DeliveryAddress2;
            dbAppointment.DeliveryTown = appointment.DeliveryTown;
            dbAppointment.DeliveryCounty = appointment.DeliveryCounty;
            dbAppointment.DeliveryPostcode = appointment.DeliveryPostcode;

            dbAppointment.SalesUserId = appointment.SalesUserId;

            context.SaveChanges();
            
            return RedirectToAction("View", new { AppointmentID = appointment.Id });
        }

        public IActionResult DeleteAppointment(int id)
        {
            var appointment = context.Appointments.Single(x => x.Id == id);
            appointment.IsDeleted = true;
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
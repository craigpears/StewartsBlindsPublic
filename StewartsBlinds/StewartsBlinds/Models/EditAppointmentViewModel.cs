using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StewartsBlinds.Data.Entities;

namespace StewartsBlinds.Models
{
    public class EditAppointmentViewModel
    {
        public Appointment Appointment { get; internal set; }
        public List<SalesUser> SalesUsers { get; internal set; }
    }
}

using StewartsBlinds.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StewartsBlinds.Models
{
    public class CalendarViewModel
    {
        public List<Appointment> Appointments { get; set; }
        public List<SalesUser> SalesUsers { get; set; }
        public DateTime? FromDate { get; internal set; }
    }
}

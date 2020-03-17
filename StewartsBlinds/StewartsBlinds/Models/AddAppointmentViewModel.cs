using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StewartsBlinds.Models
{
    public class AddAppointmentViewModel
    {
        public int SalesUserId { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}

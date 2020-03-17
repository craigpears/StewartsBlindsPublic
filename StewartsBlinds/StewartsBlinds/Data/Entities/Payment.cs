using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StewartsBlinds.Data.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public PaymentType PaymentType { get; set; }
        public String TakenBy { get; set; }
        public bool Confirmed { get; set; }

        public Double AmountPaid { get; set; }
        public DateTime CreatedDate { get; set; }

        public Appointment Appointment { get; set; }
    }
}

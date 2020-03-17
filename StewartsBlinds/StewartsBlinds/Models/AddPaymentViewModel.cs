using StewartsBlinds.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StewartsBlinds.Models
{
    public class AddPaymentViewModel
    {
        public Appointment Appointment { get; set; }
        public bool IsDeposit { get; set; }
    }
}

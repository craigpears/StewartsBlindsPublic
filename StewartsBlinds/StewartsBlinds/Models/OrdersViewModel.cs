using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StewartsBlinds.Data;
using StewartsBlinds.Data.Entities;

namespace StewartsBlinds.Models
{
    public class OrdersViewModel
    {
        public List<Appointment> Orders { get; internal set; }
        public OrdersFilter OrdersFilter { get; internal set; }
    }
}

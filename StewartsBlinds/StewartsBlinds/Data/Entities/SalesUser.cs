using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StewartsBlinds.Data.Entities
{
    public class SalesUser
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}

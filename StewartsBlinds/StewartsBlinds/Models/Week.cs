using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StewartsBlinds.Models
{
    public class Week
    {
        public String Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate => StartDate.AddDays(7);
    }
}

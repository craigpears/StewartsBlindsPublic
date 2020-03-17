using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StewartsBlinds.Models
{
    public class DashboardViewModel
    {
        public OrdersFunnelViewModel OrdersFunnel { get; internal set; }
        public ProductTypeBarChartViewModel ProductTypeBarChart { get; internal set; }
    }
}

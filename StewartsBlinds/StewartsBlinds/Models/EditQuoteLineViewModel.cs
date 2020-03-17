using StewartsBlinds.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StewartsBlinds.Models
{
    public class EditQuoteLineViewModel
    {
        public Boolean EditAll { get; set; }
        public QuoteLine QuoteLine { get; set; }
        public List<ConfigurationOption> ConfigurationOptions { get; set; }
    }
}

using StewartsBlinds.Data;
using StewartsBlinds.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StewartsBlinds.Models
{
    public class ConfigurationViewModel
    {
        public ProductType SelectedProductType { get; set; }
        public List<ConfigurationOption> Options { get; internal set; }
        public string SelectedField { get; internal set; }
        public char? SelectedLetter { get; internal set; }
    }
}

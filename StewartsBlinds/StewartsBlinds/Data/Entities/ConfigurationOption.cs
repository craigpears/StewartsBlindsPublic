using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StewartsBlinds.Data.Entities
{
    public class ConfigurationOption
    {
        public int Id { get; set; }
        public ProductType ProductType { get; set; }
        public String FieldName { get; set; }
        public String Name { get; set; }
    }
}

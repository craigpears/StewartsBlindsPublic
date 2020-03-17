using StewartsBlinds.Data;
using System.Collections.Generic;

namespace StewartsBlinds.Models
{
    public class ProductTypeBarChartViewModel
    {
        public List<ProductTypeBarChartViewModelCount> Counts { get; set; }
    }

    public class ProductTypeBarChartViewModelCount
    {
        public ProductType ProductType { get; set; }
        public double Count { get; set; }
        public List<ProductTypeBarChartViewModelSubCount> SubCounts { get; set; }
    }

    public class ProductTypeBarChartViewModelSubCount
    {
        public string FieldName { get; set; }
        public double Count { get; set; }
    }
}
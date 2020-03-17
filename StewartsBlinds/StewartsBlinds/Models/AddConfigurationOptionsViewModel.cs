using StewartsBlinds.Data;

namespace StewartsBlinds.Models
{
    public class AddConfigurationOptionsViewModel
    {
        public AddConfigurationOptionsViewModel()
        {
        }

        public ProductType SelectedProductType { get; internal set; }
        public string SelectedField { get; internal set; }
    }
}
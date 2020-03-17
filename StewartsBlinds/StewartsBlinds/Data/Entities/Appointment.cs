using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StewartsBlinds.Data.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public int SalesUserId { get; set; }
        public CustomerType CustomerType { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public DateTime AppointmentDate { get; set; }
        public String Title { get; set; }
        public String Surname { get; set; }
        public String CompanyName { get; set; }
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String Town { get; set; }
        public String County { get; set; }
        public String Postcode { get; set; }
        public String Telephone { get; set; }
        public String AlternativeTelephone { get; set; }
        public String Email { get; set; }
        public bool SameAsOrderAddress { get; set; }
        public String DeliveryAddress1 { get; set; }
        public String DeliveryAddress2 { get; set; }
        public String DeliveryTown { get; set; }
        public String DeliveryCounty { get; set; }
        public String DeliveryPostcode { get; set; }
        public String SpecialInstructions { get; set; }
        public Double PriceQuoted { get; set; }
        public bool? OrderPlaced { get; set; }
        public bool SeenByOffice { get; set; }
        public bool SeenByFactory { get; set; }
        public DateTime FinalisedDate { get; set; }
        public bool TermsAndConditionsLeft { get; set; }
        public bool OrderSigned { get; set; }

        public SalesUser SalesUser { get; set; }
        public List<QuoteLine> QuoteLines { get; set; } = new List<QuoteLine>();
        public List<Payment> Payments { get; set; } = new List<Payment>();

        public bool IsDeleted { get; set; }

        [NotMapped]
        [BindNever]
        public bool FullyPaid => Payments.Sum(x => x.AmountPaid) == PriceQuoted;
    }
}

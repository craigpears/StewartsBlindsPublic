namespace StewartsBlinds.Models
{
    public class OrdersFunnelViewModel
    {
        public int NotOrdered { get; internal set; }
        public int Pending { get; internal set; }
        public int Ordered { get; internal set; }
        public int FullyPaid { get; internal set; }
        public int PaymentTaken { get; internal set; }
    }
}
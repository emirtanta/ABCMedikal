namespace ABCMedical.Models.Entities
{
    public class Cart
    {
        public int CartID { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }

        public Customer Customer { get; set; } = null!;
        public Product Product { get; set; } = null!;
    }
}

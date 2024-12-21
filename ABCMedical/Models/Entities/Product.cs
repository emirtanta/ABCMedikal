using System.ComponentModel.DataAnnotations;

namespace ABCMedical.Models.Entities
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [StringLength(100)]
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }

        public ICollection<Order>? Orders { get; set; }
    }
}

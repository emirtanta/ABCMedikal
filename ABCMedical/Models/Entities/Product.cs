using System.ComponentModel.DataAnnotations;

namespace ABCMedical.Models.Entities
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Display(Name = "Ürün Adı")]
        [StringLength(100)]
        public string ProductName { get; set; }

        [Display(Name = "Stok")]
        public int Stock { get; set; }

        [Display(Name = "Birim Fiyatı")]
        public decimal UnitPrice { get; set; }

        public ICollection<Order>? Orders { get; set; }
    }
}

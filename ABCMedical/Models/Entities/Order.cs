using System.ComponentModel.DataAnnotations;

namespace ABCMedical.Models.Entities
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [Display(Name ="Müşteri")]
        public int CustomerID { get; set; }

        [Display(Name ="Ürün")]
        public int ProductID { get; set; }

        [Display(Name ="Adet")]
        public int Quantity { get; set; }

        [Display(Name ="Toplam Fiyat")]
        public decimal TotalPrice { get; set; }

        [Display(Name ="Sipariş Tarihi")]
        public DateTime OrderDate { get; set; }

        [Display(Name ="Sipariş Durumu")]
        public EnumOrderStatus OrderStatus { get; set; }

        public Customer? Customer { get; set; }
        public Product? Product { get; set; }
        public ICollection<Log>? Logs { get; set; }
    }

    public enum EnumOrderStatus
    {
        [Display(Name = "Onay Bekliyor")]
        Waiting,
        [Display(Name = "Onaylandı")]
        Approved,
        [Display(Name = "Kargoya Verildi")]
        Shipped,
        [Display(Name = "Tamamlandı")]
        Completed,
        [Display(Name = "İptal Edildi")]
        Cancelled,
        [Display(Name = "İade Edildi")]
        Returned
    }
}

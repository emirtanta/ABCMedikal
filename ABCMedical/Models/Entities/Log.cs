using System.ComponentModel.DataAnnotations;

namespace ABCMedical.Models.Entities
{
    public class Log
    {
        [Key]
        public int LogID { get; set; }

        [Display(Name = "Müşteri No")]
        public int CustomerID { get; set; }

        [Display(Name = "Sipariş No")]
        public int OrderID { get; set; }

        [Display(Name = "Kayıt Türü")]
        public string LogType { get; set; }

        [Display(Name = "Müşteri Tipi")]
        public string CustomerType { get; set; }
        public int ProductID { get; set; }

        [Display(Name = "Satın Alınan Miktar")]
        public int PurchasedQuantity { get; set; } //SatinAlinanMiktar

        [Display(Name = "İşlem Zamanı")]
        public DateTime LogDate { get; set; } //IslemZamani

        [Display(Name ="İşlem Sonucu")]
        [StringLength(500)]
        public string TransactionResult { get; set; }//IslemSonucu

        public Customer? Customer { get; set; }
        public Order? Order { get; set; }
    }
}

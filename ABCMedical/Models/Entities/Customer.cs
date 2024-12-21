using System.ComponentModel.DataAnnotations;

namespace ABCMedical.Models.Entities
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Display(Name ="Ad")]
        public string CustomerName { get; set; }

        [Display(Name ="Soyad")]
        public string CustomerSurname { get; set; }

        [Display(Name ="Bütçe")]
        public decimal Budget { get; set; }

        [Display(Name ="Müşteri Tipi")]
        public EnumCustomerType CustomerType { get; set; }

        [Display(Name ="Toplam Harcama")]
        public decimal TotalSpent { get; set; }

        [Display(Name = "Ad Soyad"), ScaffoldColumn(false)]
        public string? NameSurname
        {
            get
            {
                return this.CustomerName + " " + this.CustomerSurname;
            }
        }

        public ICollection<Order>? Orders { get; set; }
        public ICollection<Log>? Logs { get; set; }
    }

    public enum EnumCustomerType
    {
        [Display(Name = "Premium Müşteri")]
        Standart,
        [Display(Name = "Stardat Müşteri")]
        Premium
    }
}

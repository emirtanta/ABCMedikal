using System.ComponentModel.DataAnnotations;

namespace ABCMedical.Models.Entities
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Display(Name ="Ad")]
        [StringLength(50)]
        public string CustomerName { get; set; }

        [Display(Name ="Soyad")]
        [StringLength(50)]
        public string CustomerSurname { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        [StringLength(50)]
        public string Username { get; set; }

        [Display(Name = "E-Posta")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Şifre")]
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

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

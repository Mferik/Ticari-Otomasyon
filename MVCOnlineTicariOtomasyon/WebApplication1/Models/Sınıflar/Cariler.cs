using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Sınıflar
{
    public class Cariler
    {
        [Key]
        public int CariId { get; set; }
        public string CariAd { get; set; }
        public string CariSoyad { get; set; }
        public string CariSehir { get; set; }
        public string CariMail { get; set; }
    }
}

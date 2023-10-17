using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Sınıflar
{
    public class Gider
    {
        [Key]
        public int GiderId { get; set; }
        public int Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Tutar { get; set; }
    }
}

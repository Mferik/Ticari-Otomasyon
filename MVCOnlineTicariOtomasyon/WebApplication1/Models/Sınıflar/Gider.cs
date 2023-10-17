using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.Sınıflar
{
    public class Gider
    {
        [Key]
        public int GiderId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public int Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Tutar { get; set; }
    }
}

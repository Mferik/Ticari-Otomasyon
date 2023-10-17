using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.Sınıflar
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string KategoriAd { get; set; }
        public ICollection<Ürün> Ürüns { get; set; }
    }
}

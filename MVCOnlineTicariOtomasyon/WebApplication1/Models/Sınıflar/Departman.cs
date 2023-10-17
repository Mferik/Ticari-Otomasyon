using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.Sınıflar
{
    public class Departman
    {
        [Key]
        public int DepartmanId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string DepartmanAdı { get; set; }
        public ICollection<Personel> Personels { get; set; }

    }
}

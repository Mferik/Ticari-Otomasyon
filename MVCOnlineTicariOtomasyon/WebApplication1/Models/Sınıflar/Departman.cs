using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Sınıflar
{
    public class Departman
    {
        [Key]
        public int DepartmanId { get; set; }
        public string DepartmanAdı { get; set; }

    }
}

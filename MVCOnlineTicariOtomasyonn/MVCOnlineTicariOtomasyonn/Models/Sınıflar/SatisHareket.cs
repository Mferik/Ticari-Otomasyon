using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Sınıflar
{
    public class SatisHareket
    {
        [Key]
        public int SatisId { get; set; }
        /* ürün
         * cari
         * personel
         */
        public DateTime Tarih { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal ToplamTutar { get; set; }

        public ICollection<Ürün> Ürüns { get; set; }
        public ICollection<Cariler> Carilers { get; set; }
        public ICollection<Personel> Personels { get; set; }
    }
}

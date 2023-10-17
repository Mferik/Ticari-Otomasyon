using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Sınıflar
{
    public class Personel
    {
        [Key]
        public int PersonelId { get; set; }
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public string PersonelGorsel { get; set; }

        public SatisHareket SatisHareket { get; set; }
    }
}

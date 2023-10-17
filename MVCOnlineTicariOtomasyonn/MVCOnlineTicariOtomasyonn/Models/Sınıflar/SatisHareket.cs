using System;
using System.Collections.Generic;
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

        public Ürün Ürün { get; set; }
        public Cariler Cariler { get; set; }
        public Personel Personel { get; set; }
    }
}

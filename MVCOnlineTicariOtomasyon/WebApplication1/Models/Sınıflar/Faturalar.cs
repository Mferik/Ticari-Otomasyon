namespace WebApplication1.Models.Sınıflar
{
    public class Faturalar
    {
        public int FaturaId { get; set; }
        public string FaturaSıraNo { get; set; }
        public string FaturaSeriNo { get; set; }
        public DateTime Tarih { get; set; }
        public string VergiDairesi { get; set; }
        public DateTime Saat { get; set; }
        public string TeslimEden { get; set; }
        public string TeslimAlan { get; set; }
        public ICollection<Faturalar> Faturalars { get; set; }
    }
}

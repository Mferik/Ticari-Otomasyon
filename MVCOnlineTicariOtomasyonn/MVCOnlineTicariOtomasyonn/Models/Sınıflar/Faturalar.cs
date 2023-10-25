﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace WebApplication1.Models.Sınıflar
{
    public class Faturalar
    {
        [Key]
        public int FaturaId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(6)]
        public string FaturaSıraNo { get; set; }
        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string FaturaSeriNo { get; set; }
        public DateTime Tarih { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(60)]
        public string VergiDairesi { get; set; }
        [Column(TypeName = "char")]
        [StringLength(5)]
        public string Saat { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string TeslimEden { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string TeslimAlan { get; set; }
        public decimal Toplam { get; set; }
        public ICollection<Faturalar> Faturalars { get; set; }
    }
}

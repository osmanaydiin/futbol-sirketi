using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace takim1.Models
{
    public class Takim
    {
        [Key]
        public int TakimId { get; set; }

        [Required(ErrorMessage ="lütfen bir takım adı giriniz...")]
        public string TakimAdi { get; set; }
        public int? TakimSampiyonluk { get; set; }
        public float? TakimDeger { get; set; }
        public int? TakimKurulus { get; set; }
        public string? TakimResimUrl { get; set; }

        public bool TakimDurum { get; set; }

        public List<Futbolcu> Futbolcular { get; set; }
        public List<TeknikDirektor> TeknikDirektorler { get; set; }
    }
}

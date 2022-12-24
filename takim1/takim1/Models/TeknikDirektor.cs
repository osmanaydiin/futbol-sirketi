namespace takim1.Models
{
    public class TeknikDirektor
    {
        public int TeknikDirektorId { get; set; }
        //REQUIRED EKLE
        public string TeknikDirektorAdi { get; set; }
        public string? TeknikDirektorSoyadi { get; set; }
        public string? TeknikDirektorResimUrl { get; set; }
        public int TeknikDirektorYas { get; set; }
        public float TeknikDirektorMaas { get; set; }
        public string? TeknikDirektorGecmis { get; set; }
        public int TakimId { get; set; }
        public virtual Takim Takim { get; set; }
    }
}

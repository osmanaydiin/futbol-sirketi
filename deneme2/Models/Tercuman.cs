using System.ComponentModel.DataAnnotations;

namespace Deneme2.Models
{
    public class Tercuman
    {
        [Key]
        public int TrcId { get; set; }
        public string TrcAdi { get; set; }
        public string TrcSoyadi { get; }
        //belki hayatini anlatabilirim.
        //tercumana ait yorumlar olabilir.
        List<Kitap> Kitaplar { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace deneme2.Models
{
    public class Tercuman
    {
        [Key]
        public int TrcId { get; set; }
        public string TrcAdi { get; set; }
        public string TrcSoyadi { get; set; }
        //belki hayatini anlatabilirim.
        //tercumana ait yorumlar olabilir.
        public List<Kitap_Tercuman> Kitap_Tercumanlar { get; set; }

    }
}

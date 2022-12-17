using System.ComponentModel.DataAnnotations;

namespace Deneme2.Models
{
    public class Yazar
    {
        [Key]
        public int YazarId { get; set; }
        public string YazarAdi {get;set; }
        public string YazarSoyadi { get;}
        //belki hayatini anlatabilirim.
        //yazara ait yorumlar olabilir.
        List<Kitap> Kitaplar { get; set; } 
    }
}

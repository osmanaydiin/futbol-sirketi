using System.ComponentModel.DataAnnotations;

namespace deneme2.Models
{
    public class Yazar
    {
        [Key]
        public int YazarId { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }
        public bool YazarDurum { get; set; }
        //belki hayatini anlatabilirim.
        //yazara ait yorumlar olabilir.
        public List<Kitap_Yazar> Kitap_Yazarlar { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace deneme2.Models
{
    public class Yorum
    {
        [Key]
        public int YorumId { get; set; }
        public string YorumBaslik { get; set; }
        public string YorumIcerik { get; set; }
        public int KitapId { get; set; }
        [ForeignKey("KitapId")]
        public Kitap Kitap { get; set; }
        public int KullaniciId { get; set; }
        [ForeignKey("KullaniciId")]
        public Kullanici Kullanici { get; set; }
    }
}

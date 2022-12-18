using System.ComponentModel.DataAnnotations;

namespace deneme2.Models
{
    public class Kullanici
    {
        [Key]
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSoyadi { get; set; }
        public string KullaniciMail { get; set; }
        public string KullaniciSifre { get; set; }

        public List<Yorum>? Yorumlar { get; set; }

    }
}

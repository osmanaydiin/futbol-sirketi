using System.ComponentModel.DataAnnotations;

namespace Deneme2.Models
{
    public class Kullanici
    {
        [Key]
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSoyadi { get; set; }
        public string  KullaniciMail { get; set; }
        public string  KullaniciSifre { get; set; }

        List<Yorum>? Yorumlar { get; set; }

    }
}

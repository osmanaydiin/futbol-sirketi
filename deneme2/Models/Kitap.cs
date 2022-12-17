using System.ComponentModel.DataAnnotations;

namespace Deneme2.Models
{
    public class Kitap
    {
        [Key]
        public int KitapId { get; set; }
        public int KitapSayfa { get; set; }
        public string KitapAdi { get; set; }
        public string KitapResimUrl { get; set; }
        public string KitapHakkinda { get; set; }
        List<Yazar> Yazarlar { get; set; }
        List<Tercuman> Tercumanlar { get; set; }
        List<Yorum> Yorumlar { get; set; }
    }
}

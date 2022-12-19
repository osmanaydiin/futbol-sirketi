using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace deneme2.Models
{
    public class Kitap
    {
        [Key]
        public int KitapId { get; set; }
        public int KitapSayfa { get; set; }
        public string KitapAdi { get; set; }
        public string KitapResimUrl { get; set; }
        public string KitapHakkinda { get; set; }


        public int KtgId { get; set; }
        [ForeignKey("KtgId")]
        public Kategori Kategori { get; set; }

       
        public List<Kitap_Yazar> Kitap_Yazarlar { get; set; }
        public List<Kitap_Tercuman>? Kitap_Tercumanlar { get; set; }
        public List<Yorum>? Yorumlar { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace deneme2.Models
{
    public class Kategori
    {
        [Key]
        public int KtgId { get; set; }
        public string KtgTuru { get; set; }
        public List<Kitap>? Kitaplar { get; set; }
    }
}

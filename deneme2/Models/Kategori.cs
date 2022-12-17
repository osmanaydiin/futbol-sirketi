using System.ComponentModel.DataAnnotations;

namespace Deneme2.Models
{
    public class Kategori
    {
        [Key]
        public int KtgId { get; set; }
        public string KtgTuru { get; set; }

        List<Kitap> Kitaplar { get; set; }
    }
}

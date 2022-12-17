using System.ComponentModel.DataAnnotations;

namespace Deneme2.Models
{
    public class Yorum
    {
        [Key]
        public int YorumId { get; set; }
        public string YorumBaslik { get; set;}
        public string YorumIcerik { get; set;}
        public int KullaniciID { get; set;}
        public int KitapId { get; set;}
    }
}

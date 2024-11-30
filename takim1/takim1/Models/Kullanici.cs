using System.ComponentModel.DataAnnotations;

namespace takim1.Models
{
	public class Kullanici
	{
		[Key]
		public int KullaniciId { get; set; }


		[Required(ErrorMessage = "lütfen adınızı giriniz...")]
		public string KullaniciAdi { get; set; }

		[Required(ErrorMessage = "lütfen soyadınızı giriniz...")]
		public string KullaniciSoyadi { get; set; }

		[EmailAddress]
		public string KullaniciMail { get; set; }
		[Required]
		[StringLength(20, ErrorMessage ="lutfen yirmi karakterden az karakter giriniz...")]
		public string KullaniciSifre { get; set; }
        [MaxLength(1)]
        public string KullaniciRol { get; set; }

    }
}
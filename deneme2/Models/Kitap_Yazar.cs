namespace deneme2.Models
{
    public class Kitap_Yazar
    {
        public int KitapId { get; set; }
        public Kitap Kitap { get; set; }    
        public int YazarId { get; set; }
        public Yazar Yazar { get; set;}
    }
}

namespace deneme2.Models
{
    public class Kitap_Tercuman
    {
        public int KitapId { get; set; }
        public Kitap Kitap { get; set; }
        public int TercumanId { get; set; }
        public Tercuman Tercuman { get; set;}

    }
}

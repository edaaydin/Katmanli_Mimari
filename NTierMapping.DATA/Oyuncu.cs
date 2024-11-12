namespace NTierMapping.DATA
{
    public class Oyuncu : BaseClass
    {
        public string OyuncuAdi { get; set; }

        public DateTime DogumTarihi { get; set; }
        public string Hayati { get; set; }

        // navigation prop

        public List<OyuncuFilm> OyuncununFilmleri { get; set; }

        
    }
}

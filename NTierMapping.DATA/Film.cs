namespace NTierMapping.DATA
{
    public class Film : BaseClass
    {
        public string FilmAdi { get; set; }
        public DateTime SonYayinlanmaTarihi { get; set; }
        public int IzlenmeSayisi { get; set; }
        public int KategoriId { get; set; } // FK

        // navigation prop
        public FilmKategori FilmKategorisi { get; set; }

        public FilmDetay FilminDetayi { get; set; }

        public List<OyuncuFilm> FilminOyunculari { get; set; }
    }
}

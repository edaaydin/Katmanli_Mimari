namespace NTierMapping.DATA
{
    public class OyuncuFilm : BaseClass
    {
        public int OyuncuID { get; set; }
        public int FilmID { get; set; }
        public int CalismaGunu { get; set; }

        // navigation prop coka cok iliski

        public Film OyuncununFilmi { get; set; }
        public Oyuncu FilminOyuncusu { get; set; }


    }
}

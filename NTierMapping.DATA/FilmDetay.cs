namespace NTierMapping.DATA
{
    public class FilmDetay : BaseClass
    {
        public string FilmDetayi { get; set; }
        public int FilmId { get; set; }

        // nav prop

        public Film DetayinFilmi { get; set; }
    }
}

namespace NTierMapping.DATA
{
    public class FilmKategori : BaseClass
    {
        public string KategoriAdi { get; set; }

        // navigation prop

        public List<Film> KategorininFilmleri { get; set; }
    }
}

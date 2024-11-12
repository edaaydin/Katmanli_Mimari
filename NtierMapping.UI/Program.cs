using NTİerMapping.DAL;
using NTierMapping.DATA;

AppDbContext context = new AppDbContext();

//db.FilmKategorileri.Add(new NTierMapping.DATA.FilmKategori() { KategoriAdi = "Animasyon", IsActive = true, AddedDate = DateTime.Now });

//db.SaveChanges();

//foreach (var item in context.FilmKategorileri.ToList())
//{
//    Console.WriteLine(item.KategoriAdi);
//}

//context.Filmler.Add(new Film()
//{
//    FilmAdi = "Starwars",
//    IsActive = false,
//    IzlenmeSayisi = 122222,
//    KategoriId = 1,
//    SonYayinlanmaTarihi = new DateTime(2000, 5, 5),
//    AddedDate = DateTime.Now,
//});

//context.SaveChanges();

context.Filmler.Add(new Film()
{
    AddedDate = DateTime.Now,
    FilmAdi = "Eskiya",
    FilminDetayi = new FilmDetay()
    {
        FilmDetayi = "Bir gun bir arı konacak.",
        AddedDate = DateTime.Now
    },
    FilmKategorisi = new FilmKategori()
    {
        KategoriAdi = "Turk Filmi",
        AddedDate = DateTime.Now
    },
    FilminOyunculari = new List<OyuncuFilm>
    {
        new OyuncuFilm
        {
            FilminOyuncusu = new Oyuncu()
            {
                OyuncuAdi = "Sener Sen",
                AddedDate = DateTime.Now,
                Hayati = "Babası Ali sen bir gun onu sahnelere cıkması icin zorladi"
            },
        }

    },
    IzlenmeSayisi = 5000,
    IsActive = false,
    SonYayinlanmaTarihi = DateTime.Now.AddYears(-10)
});
context.SaveChanges();

/* - sql de birlestirme sorgusu
 select * from filmler as f join filmKategorileri as k on k.ID = f.kategoriID
join filmdetaylari as fd on fd.filmID = f.ID
join oyuncufilm  as [of] on [of].filmID = f.ID
join oyuncular as o on o.ID = [of].oyuncuId
 */
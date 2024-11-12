using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTierMapping.DATA;

namespace NTİerMapping.DAL.Mappings
{
    public class FilmKategoriMapping : IEntityTypeConfiguration<FilmKategori>
    {
        public void Configure(EntityTypeBuilder<FilmKategori> builder)
        {
            builder.Property(c => c.KategoriAdi).IsRequired().HasMaxLength(20).HasColumnType("nvarchar(20)");
        }
    }
}

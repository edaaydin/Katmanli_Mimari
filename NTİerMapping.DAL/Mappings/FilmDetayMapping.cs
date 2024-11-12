using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTierMapping.DATA;

namespace NTİerMapping.DAL.Mappings
{
    public class FilmDetayMapping : IEntityTypeConfiguration<FilmDetay>
    {
        public void Configure(EntityTypeBuilder<FilmDetay> builder)
        {
            builder.Property(x => x.FilmDetayi).HasColumnType("nvarchar(500)");
        }
    }
}

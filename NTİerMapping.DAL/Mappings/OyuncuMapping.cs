using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTierMapping.DATA;

namespace NTİerMapping.DAL.Mappings
{
    public class OyuncuMapping : IEntityTypeConfiguration<Oyuncu>
    {
        public void Configure(EntityTypeBuilder<Oyuncu> builder)
        {
            builder.Property(x => x.OyuncuAdi).IsRequired().HasColumnType("nvarchar(50)");
        }
    }
}

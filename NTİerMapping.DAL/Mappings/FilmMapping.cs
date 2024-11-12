using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTierMapping.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTİerMapping.DAL.Mappings
{
    public class FilmMapping : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.Property(f => f.FilmAdi).IsRequired().HasColumnType("nvarchar(50)");

            builder.HasOne(x => x.FilmKategorisi)
                .WithMany(fk => fk.KategorininFilmleri)
                .HasForeignKey(x => x.KategoriId);
        }
    }
}

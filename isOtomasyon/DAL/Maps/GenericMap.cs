using EntityLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Maps
{
   public class GenericMap
    {

    }

    public class DepartmanMap : IEntityTypeConfiguration<Departman>
    {
        public void Configure(EntityTypeBuilder<Departman> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(c => c.Yoneticiler).WithOne(c => c.Departman).HasForeignKey(c => c.DepartmanId);
            builder.HasMany(c => c.Kullanicilar).WithOne(c => c.Departman).HasForeignKey(c => c.DepartmanId);
        }
    }

    public class YoneticiMap : IEntityTypeConfiguration<Yonetici>
    {
        public void Configure(EntityTypeBuilder<Yonetici> builder)
        {
            builder.HasKey(c => c.Id);
            
        }
    }

    public class KullaniciMap : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.HasKey(c => c.Id);
        
        }
    }

    public class MeslekMap : IEntityTypeConfiguration<Meslek>
    {
        public void Configure(EntityTypeBuilder<Meslek> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasMany(c => c.kullanicilar).WithOne(C => C.meslek).HasForeignKey(c => c.MeslekId);
        }
    }


}


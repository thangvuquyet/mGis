using mGISv3.FactHousing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mGISv3.EntityFrameworkCore.Mapping
{
    internal class FactHousingMapping : IEntityTypeConfiguration<FactHousings>
    {
        public void Configure(EntityTypeBuilder<FactHousings> builder)
        {
            builder.Property(x=> x.HouseID)
                .HasColumnName("HouseID")
                .HasConversion<long>();
            builder.Property(x => x.DateID)
                .HasColumnName("DateID")
                .HasConversion<long>();
            builder.Property(x => x.Address)
                .HasColumnName("Address")
                .HasMaxLength(256);
            builder.Property(x => x.WardID)
                .HasColumnName("WardID")
                .HasConversion<long>();
            builder.Property(x => x.HouseTypeID)
                .HasColumnName("HouseTypeID")
                .HasConversion<long>();
            builder.Property(x => x.CertID)
                .HasColumnName("CertID")
                .HasConversion<long>();
            builder.Property(x => x.Floor)
                .HasColumnName("Floor")
                .HasConversion<long>();
            builder.Property(x => x.No_Room)
                .HasColumnName("No.Room")
                .HasConversion<long>();
            builder.Property(x => x.Area)
                .HasColumnName("Area")
                .HasConversion<long>();
        }
    }
}

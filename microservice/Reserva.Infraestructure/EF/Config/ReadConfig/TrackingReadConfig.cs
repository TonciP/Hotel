using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reserva.Domain.Model.Trackings;
using Reserva.Infraestructure.EF.ReadModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infraestructure.EF.Config.ReadConfig
{
    internal class TrackingReadConfig : IEntityTypeConfiguration<TrackingReadModel>
    {
        public void Configure(EntityTypeBuilder<TrackingReadModel> builder)
        {
            builder.ToTable("Tracking");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("trackingId");

            builder.Property(x => x.Hash).HasColumnName("hash");
            builder.Property(x => x.Duracion).HasColumnName("duracion");


        }
    }
}

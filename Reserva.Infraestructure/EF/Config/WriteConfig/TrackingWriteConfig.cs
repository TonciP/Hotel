using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reserva.Domain.Model.Clientes;
using Reserva.Domain.Model.Trackings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infraestructure.EF.Config.WriteConfig
{
    internal class TrackingWriteConfig : IEntityTypeConfiguration<Tracking>
    {
        public void Configure(EntityTypeBuilder<Tracking> builder)
        {
            builder.ToTable("Tracking");

            builder.Property(x => x.Id).HasColumnName("trackingId");

            builder.Property(x => x.Hash).HasColumnName("hash");

            builder.Ignore(x => x.DomainEvents);
            builder.Ignore("_domainEvents");

        }
    }
}

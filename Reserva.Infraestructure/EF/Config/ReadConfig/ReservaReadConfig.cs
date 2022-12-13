using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reserva.Domain.Model.Reservas;
using Reserva.Infraestructure.EF.ReadModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infraestructure.EF.Config.ReadConfig
{
    internal class ReservaReadConfig : IEntityTypeConfiguration<ReservaReadModel>
    {
        public void Configure(EntityTypeBuilder<ReservaReadModel> builder)
        {
            builder.ToTable("Reservas");
            builder.HasKey(x => x.Id);
            builder.Property(preserva => preserva.Id).HasColumnName("reservaId");

            //builder.HasOne(preserva => preserva._tracking);
            builder.Property(preserva => preserva.TrackingId).HasColumnName("trackingId");


            builder.Property(preserva => preserva.ClienteId).HasColumnName("clienteId");
            builder.HasOne(preserva => preserva.Cliente).WithMany().HasForeignKey(preserva => preserva.ClienteId);

            builder.Property(preserva => preserva.TipoHabitacionId).HasColumnName("habitacionId");
            builder.HasOne(preserva => preserva.TipoHabitacion).WithMany().HasForeignKey(preserva => preserva.TipoHabitacionId);

            builder.Property(preserva => preserva.Estado).HasColumnName("estado");

            //builder.Property(preserva => preserva.Estadia).HasColumnName("estadia");
            //builder.HasMany(preserva => preserva.Estadia).WithOne(preserva => preserva.Reserva).HasForeignKey(preserva => preserva.ReservaId);
            builder.HasOne(preserva => preserva.Estadia).WithMany().HasForeignKey(preserva => preserva.EstadiaId).OnDelete(DeleteBehavior.NoAction);

        }
    }
}

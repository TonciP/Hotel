using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reserva.Infraestructure.EF.ReadModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infraestructure.EF.Config.ReadConfig
{
    internal class TipoHabitacionReadConfig : IEntityTypeConfiguration<TipoHabitacionReadModel>
    {

        public void Configure(EntityTypeBuilder<TipoHabitacionReadModel> builder)
        {
            builder.ToTable("TipoHabitacion");

            builder.HasKey(x => x.Id);

            builder.Property(phabitacion => phabitacion.Id)
                .HasColumnName("habitacionId");

            builder.Property(phabitacion => phabitacion.NombreHabitacion)
                .HasColumnName("nombreHabitacion");

            builder.Property(phabitacion => phabitacion.Descripcion)
                .HasColumnName("descripcion");

            builder.Property(phabitacion => phabitacion.CantidadDisponible)
                .HasColumnName("cantidadDisponible");

            builder.Property(phabitacion => phabitacion.Costo)
                .HasColumnName("costo")
                .HasPrecision(14,2);
        }
    }
}

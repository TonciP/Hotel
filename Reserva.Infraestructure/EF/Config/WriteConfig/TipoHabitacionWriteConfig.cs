using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Reserva.Domain.Model.Habitaciones;
using Reserva.Domain.Model.TipoHabitaciones;
using Reserva.Infraestructure.EF.ReadModel;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infraestructure.EF.Config.WriteConfig
{
    internal class TipoHabitacionWriteConfig : IEntityTypeConfiguration<TipoHabitacion>
    {
        public void Configure(EntityTypeBuilder<TipoHabitacion> builder)
        {
            builder.ToTable("TipoHabitacion");

            builder.Property(phabitacion => phabitacion.Id)
                .HasColumnName("habitacionId");

            builder.Property(phabitacion => phabitacion.NombreHabitacion)
                .HasColumnName("nombreHabitacion");

            builder.Property(phabitacion => phabitacion.Descripcion)
                .HasColumnName("descripcion");

            var cantidadConverter = new ValueConverter<CantidadValue, int>(
                cantidadDisponibleValue => cantidadDisponibleValue.Value,
                intValue => new CantidadValue(intValue)
            );

            builder.Property(phabitacion => phabitacion.CantidadDisponible)
                .HasConversion(cantidadConverter)
                .HasColumnName("cantidadDisponible");

            var precioConverter = new ValueConverter<PrecioValue, decimal>(
                precioDisponibleValue => precioDisponibleValue.Value,
                intValue => new PrecioValue(intValue)
            );

            builder.Property(phabitacion => phabitacion.Costo)
                .HasConversion(precioConverter)
                .HasColumnName("costo")
                .HasPrecision(14, 2);

            builder.Ignore(x => x.DomainEvents);
            builder.Ignore("_domainEvents");
        }
    }
}

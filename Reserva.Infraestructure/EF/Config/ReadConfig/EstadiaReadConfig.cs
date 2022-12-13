using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Reserva.Domain.Model.Estadias;
using Reserva.Domain.ValueObjects;
using Reserva.Infraestructure.EF.ReadModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infraestructure.EF.Config.ReadConfig
{
    internal class EstadiaReadConfig : IEntityTypeConfiguration<EstadiaReadModel>
    {
        public void Configure(EntityTypeBuilder<EstadiaReadModel> builder)
        {
            builder.ToTable("estadia");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("estadiaId");

            //var fecha = new ValueConverter<EstadiaFechaValue, DateTime>(
            //    estadiValue => estadiValue.Ingreso,
            //    stringValue => new EstadiaFechaValue(stringValue)
            //);

            builder.Property(x => x.FechaIngreso)
                //.HasConversion(fecha)
                .HasColumnName("fechaIngreso");

            builder.Property(x => x.FechaSalida)
                //.HasConversion(fecha)
                .HasColumnName("fechaSalida");


        }
    }
}

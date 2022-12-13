using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Reserva.Domain.Model.Clientes;
using Reserva.Domain.ValueObjects;
using Reserva.Infraestructure.EF.ReadModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infraestructure.EF.Config.ReadConfig
{
    internal class ClienteReadConfig : IEntityTypeConfiguration<ClienteReadModel>
    {
        public void Configure(EntityTypeBuilder<ClienteReadModel> builder)
        {
            builder.ToTable("cliente");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("clienteId");

            //var nombreConverter = new ValueConverter<PersonNameValue, string>(
            //    personNameValue => personNameValue.Name,
            //    stringValue => new PersonNameValue(stringValue)
            //);

            builder.Property(x => x.Nombres)
                //.HasConversion(nombreConverter)
                .HasColumnName("nombres");

            //var apellidoConverter = new ValueConverter<PersonNameValue, string>(
            //    personApellidoValue => personApellidoValue.Name,
            //    stringValue => new PersonNameValue(stringValue)
            //);

            builder.Property(x => x.Apellidos)
                //.HasConversion(apellidoConverter)
                .HasColumnName("apellidos");

            //var emailConverter = new ValueConverter<EmailValidValue, string>(
            //    emailApellidoValue => emailApellidoValue.Mail,
            //    stringValue => new EmailValidValue(stringValue)
            //);

            builder.Property(x => x.Email)
                //.HasConversion(emailConverter)
                .HasColumnName("email");


            builder.Property(x => x.Direccion)
                .HasColumnName("direccion");

            //var telefonoConverter = new ValueConverter<TelefonoValue, string>(
            //    telefonoNameValue => telefonoNameValue.Telefono,
            //    stringValue => new TelefonoValue(stringValue)
            //);

            builder.Property(x => x.Telefono)
                //.HasConversion(telefonoConverter)
                .HasColumnName("telefono");

        }
    }
}

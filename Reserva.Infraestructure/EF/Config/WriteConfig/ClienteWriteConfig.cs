using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Reserva.Domain.Model.Clientes;
using Reserva.Domain.ValueObjects;



namespace Reserva.Infraestructure.EF.Config.WriteConfig
{
    internal class ClienteWriteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("cliente");

            builder.Property(x => x.Id).HasColumnName("clienteId");

            var nombreConverter = new ValueConverter<PersonNameValue, string>(
                personNameValue => personNameValue.Name,
                stringValue => new PersonNameValue(stringValue)
            );

            builder.Property(x => x.Nombres)
                .HasConversion(nombreConverter)
                .HasColumnName("nombres");

            var apellidoConverter = new ValueConverter<PersonNameValue, string>(
                personApellidoValue => personApellidoValue.Name,
                stringValue => new PersonNameValue(stringValue)
            );

            builder.Property(x => x.Apellidos)
                .HasConversion(apellidoConverter)
                .HasColumnName("apellidos");

            var emailConverter = new ValueConverter<EmailValidValue, string>(
                emailApellidoValue => emailApellidoValue.Mail,
                stringValue => new EmailValidValue(stringValue)
            );

            builder.Property(x => x.Email)
                .HasConversion(emailConverter)
                .HasColumnName("email");


            builder.Property(x => x.Direccion)
                .HasColumnName("direccion");

            var telefonoConverter = new ValueConverter<TelefonoValue, string>(
                telefonoNameValue => telefonoNameValue.Telefono,
                stringValue => new TelefonoValue(stringValue)
            );

            builder.Property(x => x.Telefono)
                .HasConversion(telefonoConverter)
                .HasColumnName("telefono");

            builder.Ignore(x => x.DomainEvents);
            builder.Ignore("_domainEvents");

        }
    }
}

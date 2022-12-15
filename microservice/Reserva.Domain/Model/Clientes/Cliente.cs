using Reserva.Domain.ValueObjects;
using ShareKernel.Core;

namespace Reserva.Domain.Model.Clientes
{
    public class Cliente : AggregateRoot
    {
        //public Guid ClienteId { get; private set; }
        public PersonNameValue Nombres { get; private set; }
        public PersonNameValue Apellidos { get; private set; }
        public EmailValidValue Email { get; private set; }
        public string Direccion { get; private set; }
        public TelefonoValue Telefono { get; private set; }

        //public Cliente(PersonNameValue nombres, PersonNameValue apellidos, EmailValidValue email, string direccion, TelefonoValue telefono)
        //{
        //    Id = Guid.NewGuid();
        //    Nombres = nombres;
        //    Apellidos = apellidos;
        //    Email = email;
        //    Telefono = telefono;
        //    Direccion = direccion;
        //}

        public Cliente(string nombres, string apellidos, string email, string direccion, string telefono)
        {
            Id = Guid.NewGuid();
            Nombres = nombres;
            Apellidos = apellidos;
            Email = email;
            Telefono = telefono;
            Direccion = direccion;
        }

        public void EditCliente(string nombres, string apellidos, string email, string direccion, string telefono)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            Email = email;
            Telefono = telefono;
            Direccion = direccion;
        }

        // Only for Entity Framework
        public Cliente() { }

    }
}

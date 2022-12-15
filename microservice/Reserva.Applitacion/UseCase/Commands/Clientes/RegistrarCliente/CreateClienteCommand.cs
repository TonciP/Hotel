using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Applitacion.UseCase.Commands.Clientes.RegistrarCliente
{
    public class CreateClienteCommand : IRequest<Guid>
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

    }
}

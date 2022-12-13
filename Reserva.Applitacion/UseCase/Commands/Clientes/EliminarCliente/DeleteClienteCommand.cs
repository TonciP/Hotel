using MediatR;
using Reserva.Domain.Model.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Applitacion.UseCase.Commands.Clientes.EliminarCliente
{
    public class DeleteClienteCommand : IRequest<Guid>
    {
        //public ICollection<Cliente> clientes { get; set; }
        //public Cliente clientes { get; set; }
        public Guid clienteId { get; set; }


    }
}

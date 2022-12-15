using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Applitacion.UseCase.Commands.Reservars.EliminarReserva
{
    public class DeleteReservaCommand : IRequest<Guid>
    {
        //public ICollection<Cliente> clientes { get; set; }
        //public Cliente clientes { get; set; }
        public Guid reserva { get; set; }


    }
}

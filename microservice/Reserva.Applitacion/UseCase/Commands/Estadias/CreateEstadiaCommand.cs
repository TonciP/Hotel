using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Aplication.UseCase.Commands.Estadias
{
    public class CreateEstadiaCommand : IRequest<Guid>
    {
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
    }
}

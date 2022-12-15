using MediatR;
using Reserva.Applitacion.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Applitacion.UseCase.Queries.TipoHabitacion
{
    public class GetListaByIdHabitacionQuery : IRequest<TipoHabitacionDto>
    {
        public Guid tipoHabitacionId { get; set; }
    }
}

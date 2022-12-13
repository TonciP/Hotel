using MediatR;
using Reserva.Aplication.Dto;
using Reserva.Applitacion.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Applitacion.UseCase.Queries.TipoHabitacion
{
    public class GetListaHabitacionQuery : IRequest<ICollection<TipoHabitacionDto>>
    {
    }
}

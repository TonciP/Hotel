using MediatR;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Applitacion.UseCase.Commands.Habitaciones.RegistrarHabitacion
{
    public class CreateTipoHabitacionCommand : IRequest<Guid>
    {
        public string NombreHabitacion { get; set; }
        public string Descripcion { get; set; }
        public CantidadValue CantidadDisponible { get; set; }
        //public PrecioValue TipoHabitacionId { get; private set; }
        public PrecioValue Costo { get; set; }
    }
}

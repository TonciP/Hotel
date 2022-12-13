using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Event
{
    public record EstadiaAgregado : DomainEvent
    {
        public DateTime FechaIngreso { get; }
        public DateTime FechaSalida { get; }


        public EstadiaAgregado(DateTime fechaIngreso, DateTime fechaSalida) : base(DateTime.Now)
        {
            FechaIngreso = fechaIngreso;
            FechaSalida = fechaSalida;
        }
    }
}

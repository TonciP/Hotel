using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reserva.Domain.Model.Clientes;
using Reserva.Domain.Model.Estadias;
using Reserva.Domain.Model.Reservas;

namespace Reserva.Domain.Factories.reserva
{
    public interface IReservaFactory
    {
        Reservar CrearReserva(Guid trackingId, Guid habitacionId, Estadia estadiaId, Guid clienteId);

    }
}

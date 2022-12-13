using Microsoft.EntityFrameworkCore.Storage;
using Reserva.Domain.Model.Clientes;
using Reserva.Domain.Model.Estadias;
using Reserva.Domain.Model.Reservas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Factories.reserva
{
    public class ReservaFactory : IReservaFactory
    {

        public Reservar CrearReserva(Guid trackingId, Guid habitacionId, Estadia estadiaId, Guid clienteId)
        {
            if (trackingId == null || habitacionId == null || estadiaId == null || clienteId == null)
            {
                throw new ArgumentException("Los campos para la reserva estan vacios");
            }
            return new Reservar(trackingId, habitacionId, clienteId);
        }
    }
}

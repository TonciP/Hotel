using MediatR;
using Reserva.Aplication.Dto;
using Reserva.Domain.Model.Clientes;
using Reserva.Domain.Model.Estadias;
using Reserva.Domain.Model.Trackings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Applitacion.UseCase.Commands.Reservars.RegistrarReserva
{
    public class CreateReservarCommand : IRequest<Guid>
    {
        public Guid ClienteId { get; set; }
        public Guid TrackingId { get; set; }
        public Guid TipoHabitacionId { get; set; }
        public Estadia Estadia { get; set; }
        //public EstadiaDto Estadia { get; set; }

        /*public CreateReservarCommand(ClienteDto cliente, Tracking tracking, Guid habitacionId, Estadia estadia)
        {
            //Cliente = new Cliente(cliente.Nombres, cliente.Apellidos, cliente.Email, cliente.Direccion, cliente.Telefono);
            //Tracking = new Tracking(tracking.Hash);
            //Estadia = new Estadia(estadia.FechaIngreso, estadia.FechaSalida);
            //HabitacionId = habitacionId;
            Cliente = cliente;
            Tracking = tracking;
            Estadia = estadia;
            HabitacionId = habitacionId;

        }*/
    }
}

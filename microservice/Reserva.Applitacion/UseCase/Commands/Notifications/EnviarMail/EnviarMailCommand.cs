using MediatR;
using Microsoft.AspNetCore.Http;
using Reserva.Aplication.Dto;
using Reserva.Applitacion.Dto;
using Reserva.Domain.Model.Clientes;
using Reserva.Domain.Model.Estadias;
using Reserva.Domain.Model.Reservas;
using Reserva.Domain.Model.TipoHabitaciones;
using Reserva.Domain.Model.Trackings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Reserva.Applitacion.UseCase.Commands.Notifications.EnviarMail
{
    public class EnviarMailCommand : IRequest<Guid>
    {
        public TipoHabitacionDto TipoHabitacion { get; set; }
        public EstadiaDto Estadia { get; set; }
        public TrackingDto Tracking { get; set; }
        public ClienteDto Cliente { get; set; }

        public string qrpath { get; set; }
    }
}

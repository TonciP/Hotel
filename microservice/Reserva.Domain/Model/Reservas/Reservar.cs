using Reserva.Domain.Event;
using Reserva.Domain.Model.Clientes;
using Reserva.Domain.Model.Estadias;
using Reserva.Domain.Model.Trackings;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Model.Reservas
{

    public class Reservar : AggregateRoot
    {
        //public Tracking _tracking { get; private set; }
        public Guid? TrackingId { get; private set; }
        //public Guid? HabitacionId { get; private set; }
        public Guid? TipoHabitacionId { get; private set; }

        public string Estado { get; private set; }
        //public enum Estado { DISPONIBLE, NO_DISPONIBLE,RESERVADO }
        public Estadia Estadia { get; private set; }
        public Guid ClienteId{ get; private set; }

        public Reservar(Guid? trackingId, Guid? tipoHabitacionId, Guid clienteId)
        {
            if (trackingId == Guid.Empty || tipoHabitacionId == null)
            {
                throw new ArgumentException("El (tracking, habitacion, estadia, cliente) no puede ser vacio");
            }

            Id = Guid.NewGuid();
            TrackingId = trackingId;
            TipoHabitacionId = tipoHabitacionId;
            //_estadia = estadia;
            Estado = "Iniciado";
            ClienteId = clienteId;
        }

        public void agregarEstadia(DateTime fechaIngreso, DateTime fechaSalida)
        {
            Estadia = new Estadia(fechaIngreso, fechaSalida);
            //Estadia = new EstadiaDto(fechaIngreso, fechaSalida);
            Estado = "Reservado";
            //var evento = new EstadiaAgregado(fechaIngreso, fechaSalida);
            //AddDomainEvent(evento);
        }

        //public void enviarCorreo(Tracking trackingId,Cliente clienteId)
        //{
        //    var evento = new MailReservaAgregado(trackingId, clienteId);
        //    AddDomainEvent(evento);
        //}

    }
}

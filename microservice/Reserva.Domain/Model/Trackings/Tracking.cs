using Microsoft.EntityFrameworkCore;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Model.Trackings
{
    public class Tracking: AggregateRoot
    {
        //public Guid TrackingId { get; set; }
        //[Key]
        //public Guid Id { get; set; }
        public string Hash { get; private set; }
        //public string Estado { get; private set; }
        //public DateTime FechaInicio { get; private set; }
        //public DateTime FechaFinal { get; private set; }
        public DateTime Duracion { get; private set; }

        public Tracking(string hash, DateTime duracion)
        {
            Id = Guid.NewGuid();
            Hash = hash;
            Duracion = duracion;
        }
        //public Tracking() { }
    }
}

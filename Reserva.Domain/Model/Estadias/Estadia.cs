using Reserva.Domain.ValueObjects;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Model.Estadias
{
    public class Estadia : Entity
    {

        public EstadiaFechaValue FechaIngreso { get;  set; }
        public EstadiaFechaValue FechaSalida { get;  set; }

        public Estadia(DateTime fechaIngreso, DateTime fechaSalida)
        {
            Id = Guid.NewGuid();
            this.FechaIngreso = fechaIngreso;
            this.FechaSalida = fechaSalida;
        }

        public Estadia() { }
    }
}

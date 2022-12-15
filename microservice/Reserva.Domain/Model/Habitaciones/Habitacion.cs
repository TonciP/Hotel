using Reserva.Domain.ValueObjects;
using ShareKernel.Core;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Model.Habitaciones
{
    public class Habitacion : AggregateRoot
    {
        //public Guid HabitacionId { get; private set; } 
        public string CodigoHabitacion { get; private set; }
        public CantidadValue LimitePersona { get; private set; }
        public string TipoHabitacion { get; private set; }
        public PrecioValue PrecioHabitacion { get; private set; }
        public int NumeroHabitacion { get; private set; }
        public string CaracteristicaHabitacion { get; private set; }
        public string Disponibilidad { get; private set; }


        public Habitacion(string codigoHabitacion, int limitePersona, string tipoHabitacion, 
            decimal precioHabitacion, int numeroHabitacion, string caracteristicaHabitacion, string diponibilidad) 
        {
            Id = Guid.NewGuid();
            CodigoHabitacion = codigoHabitacion;
            LimitePersona = limitePersona;
            TipoHabitacion = tipoHabitacion;
            PrecioHabitacion = precioHabitacion;
            NumeroHabitacion = numeroHabitacion;
            CaracteristicaHabitacion = caracteristicaHabitacion;
            Disponibilidad = diponibilidad;
        }
        public Habitacion() { }
    }
}

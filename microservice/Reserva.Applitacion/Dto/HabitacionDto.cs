using Reserva.Domain.Model.Habitaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Aplication.Dto
{
    public class HabitacionDto
    {
        //public Guid HabitacionId { get;  set; }
        public string CodigoHabitacion { get;  set; }
        public int LimitePersona { get; private set; }
       // public TipoHabitacionEnum TipoHabitacion { get;  set; }
        public int TipoHabitacion { get;  set; }
        public decimal PrecioHabitacion { get;  set; }
        public int NumeroHabitacion { get;  set; }
        public string CaracteristicaHabitacion { get;  set; }
        //public DisponibilidadHabitacionEnum Disponibilidad { get;  set; }
        public string Disponibilidad { get;  set; }
    }
}

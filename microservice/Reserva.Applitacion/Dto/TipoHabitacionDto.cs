using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Applitacion.Dto
{
    public class TipoHabitacionDto
    {
        public Guid? HabitacionId { get; set; }
        public string NombreHabitacion { get; set; }
        public string Descripcion { get; set; }
        public int CantidadDisponible { get; set; }
        //public PrecioValue TipoHabitacionId { get; private set; }
        public decimal Costo { get; set; }
    }
}

using Reserva.Domain.Model.Habitaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Factories.habitacion
{
    public interface ITipoHabitacionFactory
    {
        Habitacion CrearHabitacion(string codigoHabitacion, int limitePersona, string tipoHabitacion,
            decimal precioHabitacion, int numeroHabitacion, string caracteristicaHabitacion, string diponibilidad);
        Habitacion CrearHabitacion();
    }
}

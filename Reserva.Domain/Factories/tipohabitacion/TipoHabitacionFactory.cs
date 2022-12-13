using Reserva.Domain.Factories.tipohabitacion;
using Reserva.Domain.Model.Clientes;

using Reserva.Domain.Model.TipoHabitaciones;
using Reserva.Domain.Model.Trackings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Factories.habitacion
{
    public class TipoHabitacionFactory : ITipoHabitacionFactory
    {
        public TipoHabitacion CrearHabitacion(string nombreHabitacion, string descripcion, int cantidadDiponible, decimal costo)
        {
            if (nombreHabitacion == null || descripcion == null || descripcion == null || cantidadDiponible == null || costo == null)
            {
                throw new ArgumentException("Los campos para la tipo habitacion estan vacios");
            }
            return new TipoHabitacion(nombreHabitacion, descripcion, cantidadDiponible, costo);
        }
    }
}

using Reserva.Domain.Model.TipoHabitaciones;


namespace Reserva.Domain.Factories.tipohabitacion
{
    public interface ITipoHabitacionFactory
    {
        TipoHabitacion CrearHabitacion(string nombreHabitacion, string descripcion, int cantidadDiponible,
            decimal costo);
    }
}

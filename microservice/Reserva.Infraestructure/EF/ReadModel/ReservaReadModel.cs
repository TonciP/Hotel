
namespace Reserva.Infraestructure.EF.ReadModel
{
    internal class ReservaReadModel
    {
        public Guid Id { get; set; }
        public TrackingReadModel Tracking { get;  set; }
        public Guid TrackingId { get;  set; }
        public TipoHabitacionReadModel TipoHabitacion { get;  set; }
        public Guid TipoHabitacionId { get;  set; }

        public string Estado { get;  set; }
        public EstadiaReadModel Estadia { get;  set; }
        public Guid EstadiaId { get; set; }
        public ClienteReadModel Cliente { get;  set; }
        public Guid ClienteId { get;  set; }
    }
}

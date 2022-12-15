using ShareKernel.Core;
using ShareKernel.Rules;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Reserva.Domain.Model.TipoHabitaciones
{
    public class TipoHabitacion : AggregateRoot
    {
        public string NombreHabitacion { get; private set; }
        public string Descripcion { get; private set; }
        public CantidadValue CantidadDisponible { get; private set; }
        //public PrecioValue TipoHabitacionId { get; private set; }
        public PrecioValue Costo { get; private set; }

        //public TipoHabitacion(string nombreHabitacion, string descripcion, CantidadValue cantidadDiponible, PrecioValue costo)
        //{
        //    Id = Guid.NewGuid();
        //    NombreHabitacion= nombreHabitacion;
        //    Descripcion= descripcion;
        //    CantidadDisponible = cantidadDiponible;
        //    Costo = costo;

        //}

        public TipoHabitacion(string nombreHabitacion, string descripcion, int cantidadDiponible, decimal costo)
        {
            if (nombreHabitacion is null || descripcion is null)
            {
                throw new ArgumentException("Los campos de nombre y descripcion no puden estar vacios");
            }
            Id = Guid.NewGuid();
            NombreHabitacion = nombreHabitacion;
            Descripcion = descripcion;
            CantidadDisponible = cantidadDiponible;
            Costo = costo;

        }

        public TipoHabitacion() { }
    }
}

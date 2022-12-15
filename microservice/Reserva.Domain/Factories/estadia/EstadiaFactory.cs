using Reserva.Domain.Model.Estadias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Factories.estadia
{
    public class EstadiaFactory : IEstadiaFactory
    {
        public Estadia CrearEstadia()
        {
            return new Estadia();
        }

        public Estadia CrearEstadia(DateTime FechaIngreso, DateTime FechaSalida)
        {
            return new Estadia(FechaIngreso, FechaSalida);
        }
    }
}

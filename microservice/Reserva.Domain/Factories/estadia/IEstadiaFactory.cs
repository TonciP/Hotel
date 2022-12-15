using Reserva.Domain.Model.Estadias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Factories.estadia
{
    public interface IEstadiaFactory
    {
        Estadia CrearEstadia();
        Estadia CrearEstadia(DateTime FechaIngreso, DateTime FechaSalida);
    }
}

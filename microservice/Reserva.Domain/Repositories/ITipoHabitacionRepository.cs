using Reserva.Domain.Model.TipoHabitaciones;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Repositories
{
    public interface ITipoHabitacionRepository : IRepository<TipoHabitacion, Guid>
    {
        Task UpdateAsync(TipoHabitacion obj);
        Task CreateAsync(TipoHabitacion obj);
    }
}

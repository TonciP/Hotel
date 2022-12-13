using Reserva.Domain.Model.Habitaciones;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Repositories
{
    public interface IHabitacionRepository : IRepository<Habitacion, Guid>
    {
        Task UpdateAsync(Habitacion obj);

    }
}

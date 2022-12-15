using Reserva.Domain.Model.Habitaciones;
using Reserva.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infraestructure.EF.Repository
{
    internal class HabitacionRepository : IHabitacionRepository
    {
        public Task CreateAsync(Habitacion obj)
        {
            throw new NotImplementedException();
        }

        public Task<Habitacion?> FindByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Habitacion obj)
        {
            throw new NotImplementedException();
        }
    }
}

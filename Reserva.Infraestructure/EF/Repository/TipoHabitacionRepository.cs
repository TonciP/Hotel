using Microsoft.EntityFrameworkCore;
using Reserva.Domain.Model.TipoHabitaciones;
using Reserva.Domain.Repositories;
using Reserva.Infraestructure.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infraestructure.EF.Repository
{
    internal class TipoHabitacionRepository : ITipoHabitacionRepository
    {
        private readonly WriteDbContext _context;

        public TipoHabitacionRepository(WriteDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(TipoHabitacion obj)
        {
            await _context.TipoHabitacion.AddAsync(obj);
        }

        public Task<TipoHabitacion?> FindByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TipoHabitacion obj)
        {
            throw new NotImplementedException();
        }
    }
}

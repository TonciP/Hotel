using Reserva.Domain.Model.Clientes;
using Reserva.Domain.Model.Reservas;
using Reserva.Domain.Repositories;
using Reserva.Infraestructure.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infraestructure.EF.Repository
{
    internal class ReservaRepository : IReservarRepository
    {
        private readonly WriteDbContext _context;
        public ReservaRepository(WriteDbContext context)
        {
            _context = context;
        }


        public async Task CreateAsync(Reservar obj)
        {
            await _context.Reservar.AddAsync(obj);
        }

        public async Task DeleteAsync(Guid reservaId)
        {
            var reserva = _context.Reservar.Find(reservaId);
            _context.Remove(reserva);
            await _context.SaveChangesAsync();
        }

        public Task<Reservar> FindByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Reservar obj)
        {
            throw new NotImplementedException();
        }
    }
}

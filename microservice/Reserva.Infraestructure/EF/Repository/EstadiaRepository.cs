using Reserva.Domain.Model.Estadias;
using Reserva.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infraestructure.EF.Repository
{
    internal class EstadiaRepository : IEstadiaRepository
    {
        public Task CreateAsync(Estadia obj)
        {
            throw new NotImplementedException();
        }

        public Task<Estadia> FindByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Estadia obj)
        {
            throw new NotImplementedException();
        }
    }
}

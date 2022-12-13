using Reserva.Domain.Model.Clientes;
using Reserva.Domain.Model.Reservas;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Repositories
{
    public interface IReservarRepository : IRepository<Reservar, Guid>
    {
        Task CreateAsync(Reservar obj);
        Task UpdateAsync(Reservar obj);
        Task DeleteAsync(Guid reservaId);
    }
}

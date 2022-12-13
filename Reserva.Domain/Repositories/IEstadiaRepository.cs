using Reserva.Domain.Model.Clientes;
using Reserva.Domain.Model.Estadias;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Repositories
{
    public interface IEstadiaRepository : IRepository<Estadia, Guid>
    {
        Task CreateAsync(Estadia obj);
        Task UpdateAsync(Estadia obj);
    }
}

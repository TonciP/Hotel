using Reserva.Domain.Model.Clientes;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Repositories
{
    public interface IClienteRepository
        : IRepository<Cliente, Guid>
    {
        Task CreateAsync(Cliente obj);
        Task UpdateAsync(Cliente obj);
        Task DeleteAsync(Guid clienteId);
    }
}

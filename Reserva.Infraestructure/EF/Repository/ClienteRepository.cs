using Microsoft.EntityFrameworkCore;
using Reserva.Domain.Model.Clientes;
using Reserva.Domain.Repositories;
using Reserva.Infraestructure.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infraestructure.EF.Repository
{
    internal class ClienteRepository : IClienteRepository
    {
        private readonly WriteDbContext _context;

        public ClienteRepository(WriteDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Cliente obj)
        {
            //throw new NotImplementedException();
            await _context.Clientes.AddAsync(obj);
        }

        public async Task DeleteAsync(Guid clienteId)
        {
            var cliente = _context.Clientes.Find(clienteId);
            _context.Remove(cliente);
            await _context.SaveChangesAsync();
        }

        public Task<Cliente> FindByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Cliente obj)
        {
            throw new NotImplementedException();
        }
    }
}

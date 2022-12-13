using MediatR;
using Microsoft.EntityFrameworkCore;
using Reserva.Aplication.Dto;
using Reserva.Aplication.UseCase.Queries.Cliente;
using Reserva.Domain.Model.Clientes;
using Reserva.Infraestructure.EF.Context;
using Reserva.Infraestructure.EF.ReadModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infraestructure.Queries
{
    internal class GetListaClientesHandler : IRequestHandler<GetListaCliente, IEnumerable<ClienteDto>>
    {
        private readonly DbSet<ClienteReadModel> clientes; 

        public GetListaClientesHandler(ReadDbContext dbContext)
        {
            clientes = dbContext.Clientes;
        }

        public async Task<IEnumerable<ClienteDto>> Handle(GetListaCliente request, CancellationToken cancellationToken)
        {
            var query = clientes.AsNoTracking().AsQueryable();
            if (!string.IsNullOrEmpty(request.nombreSearch))
            {
                query = query.Where(x => x.Nombres.ToLower().Contains(request.nombreSearch.ToLower()));
            }
            var lista = await query.Select(x => new ClienteDto
            {
                clienteId = x.Id,
                nombres = x.Nombres,
                apellidos = x.Apellidos,
                direccion =  x.Direccion,
                email = x.Email,
                telefono = x.Telefono
            }).ToListAsync();

            return lista;
        }
    }
}

using MediatR;
using Reserva.Aplication.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Aplication.UseCase.Queries.Cliente
{
    public class GetListaCliente : IRequest<IEnumerable<ClienteDto>>
    {
        public string nombreSearch { get; set; }
        public string? apellidoSearch { get; set; } 

    }
}

using MediatR;
using Reserva.Aplication.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Aplication.UseCase.Queries.Cliente
{
    public class FindCliente : IRequest<ClienteDto>
    {
        public Guid clienteIdSearch{ get; set; }

    }
}

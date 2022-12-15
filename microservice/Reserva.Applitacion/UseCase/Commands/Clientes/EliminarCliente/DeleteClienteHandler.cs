using MediatR;
using Reserva.Aplication.Dto;
using Reserva.Aplication.UseCase.Queries.Cliente;
using Reserva.Domain.Model.Clientes;
using Reserva.Domain.Repositories;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Applitacion.UseCase.Commands.Clientes.EliminarCliente
{
    internal class DeleteClienteHandler : IRequestHandler<DeleteClienteCommand, Guid>
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteClienteHandler(IClienteRepository clienteRepository, IUnitOfWork unitOfWork)
        {
            _clienteRepository = clienteRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(DeleteClienteCommand request, CancellationToken cancellationToken)
        {
            Guid cliente = request.clienteId;
            await _clienteRepository.DeleteAsync(cliente);

            await _unitOfWork.Commit();

            return cliente;
        }
    }
}

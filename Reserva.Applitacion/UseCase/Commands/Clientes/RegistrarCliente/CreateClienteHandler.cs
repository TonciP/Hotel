using MediatR;
using Reserva.Domain.Repositories;
using ShareKernel.Core;
using Reserva.Domain.Model.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Applitacion.UseCase.Commands.Clientes.RegistrarCliente
{
    internal class CreateClienteHandler : IRequestHandler<CreateClienteCommand, Guid>
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateClienteHandler(IClienteRepository clienteRepository, IUnitOfWork unitOfWork)
        {
            _clienteRepository = clienteRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreateClienteCommand request, CancellationToken cancellationToken)
        {
            Cliente obj = new Cliente(request.Nombres, request.Apellidos, request.Email, request.Direccion, request.Telefono);

            await _clienteRepository.CreateAsync(obj);

            await _unitOfWork.Commit();

            return obj.Id;
        }
    }
}

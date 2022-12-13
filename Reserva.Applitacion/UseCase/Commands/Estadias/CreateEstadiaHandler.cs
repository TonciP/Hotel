using MediatR;
using Reserva.Domain.Model.Estadias;
using Reserva.Domain.Repositories;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Aplication.UseCase.Commands.Estadias
{
    public class CreateEstadiaHandler : IRequestHandler<CreateEstadiaCommand, Guid>
    {
        public readonly IEstadiaRepository _estadiaRepository;
        public readonly IUnitOfWork _unitOfWork;

        public CreateEstadiaHandler(IEstadiaRepository estadiaRepository, IUnitOfWork unitOfWork)
        {
            _estadiaRepository = estadiaRepository;
            _unitOfWork =  unitOfWork;
        }
        public async Task<Guid> Handle(CreateEstadiaCommand request, CancellationToken cancellationToken)
        {
            Estadia obj = new Estadia(request.FechaIngreso, request.FechaSalida);
            await _estadiaRepository.CreateAsync(obj);

            await _unitOfWork.Commit();
            return obj.Id;
        }
    }
}

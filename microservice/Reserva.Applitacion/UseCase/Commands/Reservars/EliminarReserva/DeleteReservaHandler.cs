using MediatR;
using Reserva.Domain.Factories.reserva;
using Reserva.Domain.Model.Clientes;
using Reserva.Domain.Model.Estadias;
using Reserva.Domain.Model.Reservas;
using Reserva.Domain.Model.Trackings;
using Reserva.Domain.Repositories;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Applitacion.UseCase.Commands.Reservars.EliminarReserva
{
    internal class DeleteReservaHandler : IRequestHandler<DeleteReservaCommand, Guid>
    {
        private readonly IReservarRepository _reservapository;
        private readonly IReservaFactory _reservaFactory;
        private readonly IUnitOfWork _unitOfWor;

        public DeleteReservaHandler(IReservarRepository reservarRepository, IReservaFactory reservaFactory, IUnitOfWork unitOfWork)
        {
            _reservapository = reservarRepository;
            _reservaFactory = reservaFactory;
            _unitOfWor = unitOfWork;

        }
        public async Task<Guid> Handle(DeleteReservaCommand request, CancellationToken cancellationToken)
        {

            //var reserva = _reservaFactory.CrearReserva(request.HabitacionId);
            //reserva.agregar(request.Tracking,request.Estadia, request.Cliente);

            Guid reservaId = request.reserva;
            await _reservapository.DeleteAsync(reservaId);

            await _unitOfWor.Commit();

            return reservaId;
        }
    }
}

using MediatR;
using Reserva.Domain.Factories.habitacion;
using Reserva.Domain.Model.Habitaciones;
using Reserva.Domain.Model.TipoHabitaciones;
using Reserva.Domain.Repositories;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Applitacion.UseCase.Commands.Habitaciones.RegistrarHabitacion
{
    internal class CreateTipoHabitacionHandler : IRequestHandler<CreateTipoHabitacionCommand, Guid>
    {
        private readonly ITipoHabitacionRepository _habitacionRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateTipoHabitacionHandler(ITipoHabitacionRepository habitacionRepository, IUnitOfWork unitOfWork)
        {
            _habitacionRepository = habitacionRepository;
            _unitOfWork = unitOfWork;

        }
        public async Task<Guid> Handle(CreateTipoHabitacionCommand request, CancellationToken cancellationToken)
        {
            TipoHabitacion obj = new TipoHabitacion(request.NombreHabitacion, request.Descripcion,
                request.CantidadDisponible, request.Costo);

            await _habitacionRepository.CreateAsync(obj);

            await _unitOfWork.Commit();

            return obj.Id;
        }
    }
}

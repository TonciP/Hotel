using MediatR;
using Reserva.Aplication.Dto;
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

namespace Reserva.Applitacion.UseCase.Commands.Reservars.RegistrarReserva
{
    internal class CrearReservarHandler : IRequestHandler<CreateReservarCommand, Guid>
    {
        private readonly IReservarRepository _reservapository;
        private readonly IReservaFactory _reservaFactory;
        private readonly IUnitOfWork _unitOfWor;

        public CrearReservarHandler(IReservarRepository reservarRepository, IReservaFactory reservaFactory, IUnitOfWork unitOfWork)
        {
            _reservapository = reservarRepository;
            _reservaFactory = reservaFactory;
            _unitOfWor = unitOfWork;

        }
        public async Task<Guid> Handle(CreateReservarCommand request, CancellationToken cancellationToken)
        {
            Guid cliente = request.ClienteId;

            Guid tracking = request.TrackingId;

            //Estadia estadia = new Estadia(request.Estadia.FechaIngreso, request.Estadia.FechaSalida);
            EstadiaDto estadia = new EstadiaDto { FechaIngreso = request.Estadia.FechaIngreso, FechaSalida = request.Estadia.FechaSalida };

            Guid TipoHabitacionId = request.TipoHabitacionId;

            Reservar obj = new Reservar(tracking, TipoHabitacionId, cliente);

            obj.agregarEstadia(request.Estadia.FechaIngreso, request.Estadia.FechaSalida);

            //var obj = _reservaFactory.CrearReserva(tracking, TipoHabitacionId, estadia, cliente);
            obj.agregarEstadia(request.Estadia.FechaIngreso, request.Estadia.FechaSalida);
            await _reservapository.CreateAsync(obj);
            await _unitOfWor.Commit();

            //obj.enviarCorreo(tracking, cliente);

            return obj.Id;
        }
    }
}

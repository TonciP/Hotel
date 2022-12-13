using MediatR;
using Microsoft.EntityFrameworkCore;
using Reserva.Aplication.Dto;
using Reserva.Aplication.UseCase.Queries.Cliente;
using Reserva.Applitacion.Dto;
using Reserva.Applitacion.UseCase.Queries.TipoHabitacion;
using Reserva.Domain.Model.Clientes;
using Reserva.Infraestructure.EF.Context;
using Reserva.Infraestructure.EF.ReadModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infraestructure.Queries.TipoHabitacion
{
    internal class GetListaTipoHabitacionHandler : IRequestHandler<GetListaHabitacionQuery, ICollection<TipoHabitacionDto>>
    {
        private readonly DbSet<TipoHabitacionReadModel> habitaciones;

        public GetListaTipoHabitacionHandler(ReadDbContext dbContext)
        {
            habitaciones = dbContext.Habitacion;
        }

        public async Task<ICollection<TipoHabitacionDto>> Handle(GetListaHabitacionQuery request, CancellationToken cancellationToken)
        {
            var query = habitaciones.AsNoTracking().AsQueryable();
            var lista = await query.Select(x => new TipoHabitacionDto
            {
                HabitacionId = x.Id,
                NombreHabitacion = x.NombreHabitacion,
                CantidadDisponible = x.CantidadDisponible,
                Descripcion = x.Descripcion,
                Costo = x.Costo
            }).ToListAsync();



            return lista;
        }
    }
}

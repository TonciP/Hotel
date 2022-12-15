using MediatR;
using Microsoft.EntityFrameworkCore;
using Reserva.Aplication.Dto;
using Reserva.Aplication.UseCase.Queries.Cliente;
using Reserva.Applitacion.Dto;
using Reserva.Applitacion.UseCase.Queries.TipoHabitacion;
using Reserva.Infraestructure.EF.Context;
using Reserva.Infraestructure.EF.ReadModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infraestructure.Queries.TipoHabitacion
{
    internal class GetListaSearchTipoHabitacionHandler : IRequestHandler<GetListaByIdHabitacionQuery, TipoHabitacionDto>
    {
        private readonly DbSet<TipoHabitacionReadModel> tipoHabitacions;

        public GetListaSearchTipoHabitacionHandler(ReadDbContext dbContext)
        {
            tipoHabitacions = dbContext.Habitacion;
        }

        public async Task<TipoHabitacionDto> Handle(GetListaByIdHabitacionQuery request, CancellationToken cancellationToken)
        {
            var query = tipoHabitacions.AsNoTracking().AsQueryable();
            if (request.tipoHabitacionId != Guid.Empty)
            {
                query = query.Where(x => x.Id == request.tipoHabitacionId);
            }
            var lista = await query.Select(x => new TipoHabitacionDto
            {
                HabitacionId = x.Id,
                NombreHabitacion = x.NombreHabitacion,
                Descripcion = x.Descripcion,
                CantidadDisponible = x.CantidadDisponible,
                Costo = x.Costo
            }).SingleAsync();

            return lista;
        }
    }
}

using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reserva.Aplication.UseCase.Queries.Cliente;
using Reserva.Applitacion.UseCase.Commands.Clientes.EliminarCliente;
using Reserva.Applitacion.UseCase.Commands.Clientes.RegistrarCliente;
using Reserva.Applitacion.UseCase.Commands.Habitaciones.RegistrarHabitacion;
using Reserva.Applitacion.UseCase.Queries.TipoHabitacion;

namespace WebApp.Reserva.Controllers
{
    [Route("api/tipohabitacion")]
    [ApiController]
    public class TipoHabitacionController : ControllerBase
    {

        public readonly IMediator _mediator;
        public TipoHabitacionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var result = await _mediator.Send(new GetListaHabitacionQuery());
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet("GetById", Name = "buscarGuid")]
        public async Task<IActionResult> GetById(Guid tipoHabtiacionId)
        {

            var result = await _mediator.Send(new GetListaByIdHabitacionQuery{ tipoHabitacionId = tipoHabtiacionId });
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpPost]
        
        public async Task<IActionResult> CreateTipoHabitacion([FromBody] CreateTipoHabitacionCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        //[HttpDelete]
        //public async Task<IActionResult> DeleteHabitacion([FromBody] DeleteTipoHabitacionCommand command)
        //{
        //    var result = await _mediator.Send(command);
        //    return Ok(result);
        //}
    }
}

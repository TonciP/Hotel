using MediatR;
using Microsoft.AspNetCore.Mvc;
using Reserva.Aplication.UseCase.Queries.Cliente;
using Reserva.Applitacion.UseCase.Commands.Clientes.EliminarCliente;
using Reserva.Applitacion.UseCase.Commands.Clientes.RegistrarCliente;

namespace WebApp.Reserva.Controllers
{
    [Route("api/cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        public readonly IMediator _mediator;
        public ClienteController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [Route("search")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> SearchCliente([FromQuery] string? nombre = "")
        {
            var query = new GetListaCliente
            {
                nombreSearch = nombre
            };
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateCliente([FromBody] CreateClienteCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteCliente([FromBody] DeleteClienteCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}

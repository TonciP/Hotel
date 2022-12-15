//using iTextSharp.text;
//using iTextSharp.text.pdf;
//using iTextSharp.text.pdf.qrcode;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reserva.Applitacion.UseCase.Commands.Habitaciones.RegistrarHabitacion;

namespace WebApp.Reserva.Controllers
{
    [Route("api/tracking")]
    [ApiController]
    public class TrackingController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TrackingController(IMediator mediator)
        {
            _mediator = mediator;
        }
        


    }
}

using MediatR;

using Microsoft.AspNetCore.Mvc;

using WebApp.Reserva.action;

using Reserva.Applitacion.UseCase.Commands.Notifications.EnviarMail;
using Microsoft.AspNetCore.Hosting.Server;

namespace WebApp.Reserva.Controllers
{
    [Route("api/notificacion")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        public readonly IMediator _mediator;
        public NotificationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> EnviarMail([FromBody] EnviarMailCommand command)
        {
            //var result = await _mediator.Send(command);

            //return Ok(result);

            bool envio = await ReservaActionController.enviarCorreoAsync(command.Cliente, command.Tracking, command.TipoHabitacion, command.qrpath);

            if (envio)
            {
                return Ok("ok");
            }
            else
            {
                return Ok("No se envio correctamente") ;
            }
            

        }

        [HttpPost("guardarImagen", Name = "upload")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        //public async Task<IActionResult> GuardarImagen(IFormFile file)
        public async Task<IActionResult> GuardarImagen(Guid tipoHabitacionId)
        {
            //preparar imagen qr
            //BarcodeQRCode barcodeQR = new BarcodeQRCode("https://www.google.com/", 500, 500, null);
            //Image codeQrImage = barcodeQR.GetImage();
            //codeQrImage.ScaleAbsolute(200, 200);
            IFormFile file = Request.Form.Files[0];
            string[] splitfile = file.FileName.Split(".");

            string path = @"D:\\UNIVERSIDAD_SEMESTRES\\Ingeneer-2022-2\\Taller-Ingenieria-Web\\Proyecto\\Develop\\Hotel-Santa-Cruz\\image\\";
            bool fileExists = System.IO.File.Exists(path + tipoHabitacionId+ '.' + splitfile[1]);
            //foreach (var formFile in files)
            //{
            if (!fileExists)
            {
                if (file.Length > 0)
                {
                    //var filePath = "D:\\UNIVERSIDAD_SEMESTRES\\Ingeneer-2022-2\\Taller-Ingenieria-Web\\Proyecto\\Develop\\Hotel-Santa-Cruz\\image\\" + file.FileName;
                    var filePath = "D:\\UNIVERSIDAD_SEMESTRES\\Ingeneer-2022-2\\Taller-Ingenieria-Web\\Proyecto\\Develop\\Hotel-Santa-Cruz\\image\\" + tipoHabitacionId + '.' + splitfile[1];

                    path =  filePath;
                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                return Ok(new { success = "ok", path = path });
            }
            else
            {
                return Ok(new { success = "error", message = "No se pudo guardar la imagen por que ya se tiene una imagen con el mismo valor" });
            }

        }

        [HttpGet("getImagen", Name = "image")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> getImagen(Guid tipoHabitacionId)
        {
            string path = @"D:\\UNIVERSIDAD_SEMESTRES\\Ingeneer-2022-2\\Taller-Ingenieria-Web\\Proyecto\\Develop\\Hotel-Santa-Cruz\\image\\";
            string imageName = tipoHabitacionId + ".png";
            Byte[] b = System.IO.File.ReadAllBytes(path + imageName);   // You can use your own method over here.         
            return File(b, "image/jpeg");
        }
    }
}

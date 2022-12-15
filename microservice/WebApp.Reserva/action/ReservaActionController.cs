using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reserva.Domain.Model.Clientes;
using System.Net.Mail;
using System.Net;
using Reserva.Domain.Model.Trackings;
using Reserva.Domain.Model.TipoHabitaciones;
using Reserva.Applitacion.Dto;
using Reserva.Aplication.Dto;

namespace WebApp.Reserva.action
{
    //[Route("api/notificacion")]
    [ApiController]
    public class ReservaActionController
    {
        [NonAction]
        public static async Task<bool> enviarCorreoAsync(ClienteDto cliente, TrackingDto tracking, TipoHabitacionDto tipohabitacion, string qrpath)
        {
                
            try
            {
                var fromAddress = new MailAddress("tpinto@nur.edu", "Tonci Pinto");

                var toAddress = new MailAddress(cliente.email, cliente.nombres);
                const string fromPassword = "T7537p!!";
                const string subject = "Reserva Hotel Santa Cruz";
                const string body = @"Su reserva a sido con exito";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                //using (var message = new MailMessage(fromAddress, toAddress)
                var message = new MailMessage(fromAddress, toAddress);

                message.Subject = subject;
                message.Body = body;
                message.Attachments.Add(new Attachment("D:\\UNIVERSIDAD_SEMESTRES\\Ingeneer-2022-2\\Taller-Ingenieria-Web\\Proyecto\\Develop\\imagenesQR\\testing.png"));
                //message.Attachments.Add(new Attachment(qrpath));
                smtp.Send(message);

                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
    }
}

using Reserva.Domain.Model.Clientes;
using Reserva.Domain.Model.Trackings;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mime;

namespace Reserva.Domain.Event
{
    public record MailReservaAgregado : DomainEvent
    {
        public MailReservaAgregado(Tracking tracking, Cliente cliente) : base(DateTime.Now)
        {

            // preparar imagen qr

            //BarcodeQRCode barcodeQR = new BarcodeQRCode("https://www.google.com/", 500, 500, null);
            //Image codeQrImage = barcodeQR.GetImage();
            //codeQrImage.ScaleAbsolute(200, 200);
            
            // correo

            var fromAddress = new MailAddress("tpinto@nur.edu", "Tonci Pinto");

            var toAddress = new MailAddress(cliente.Email, cliente.Nombres);
            const string fromPassword = "T7537p!!";
            const string subject = "Reserva Hotel Santa Cruz";
            const string body = "Su reserva a sido con exito" ;

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
            smtp.Send(message);
        }

    }
}

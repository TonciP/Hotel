using Reserva.Domain.Model.Clientes;
using Reserva.Domain.Model.Estadias;
using Reserva.Domain.Model.Reservas;
using Reserva.Domain.Model.Trackings;
using Xunit;

namespace TestCliente
{
    public class TestReservas
    {
        [Fact]
        public void ReservasCreation_Should_Correct()
        {
            //Tracking tracking = new Tracking();
            //Guid habitacionid= Guid.NewGuid();
            //Estadia estadia = new Estadia();
            //Cliente cliente = new Cliente();

            //Reservar reservar = new Reservar(tracking, habitacionid, estadia, cliente);

            //Assert.NotNull(reservar._tracking);
            //Assert.Equal(tracking, reservar._tracking);

            ////Assert.NotNull(reservar.HabitacionId);
            //Assert.Equal(habitacionid, reservar.HabitacionId);

            //Assert.NotNull(reservar._estadia);
            //Assert.Equal(estadia, reservar._estadia);

            //Assert.NotNull(reservar._cliente);
            //Assert.Equal(cliente, reservar._cliente);

            


        }
        [Fact]
        public void ReservasSendEmail_Should_Correct()
        {
            string nombres = "Marcos Antonio";
            string apellidos = "Mercado Aguirre";
            string email = "56350a@nur.edu";
            string direccion = "B/ Navidad";
            string telefono = "77777777";


            //Tracking tracking = new Tracking();
            //Guid habitacionid = Guid.NewGuid();
            //Estadia estadia = new Estadia();
            //Cliente cliente = new Cliente(nombres, apellidos, email, direccion, telefono);


            //Reservar reservar = new Reservar(tracking, habitacionid, estadia, cliente);
            //reservar.enviarCorreo(tracking, cliente);

            //Assert.NotNull(reservar._tracking);
            //Assert.Equal(tracking, reservar._tracking);

            ////Assert.NotNull(reservar.HabitacionId);
            //Assert.Equal(habitacionid, reservar.HabitacionId);

            //Assert.NotNull(reservar._estadia);
            //Assert.Equal(estadia, reservar._estadia);

            //Assert.NotNull(reservar._cliente);
            //Assert.Equal(cliente, reservar._cliente);

        }

    }
}

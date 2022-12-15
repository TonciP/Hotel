
using Reserva.Domain.Model.Estadias;
using ShareKernel.Core;
using Xunit;

namespace TestCliente
{
    public class TestEstadia
    {
        [Fact]
        public void EstadiaCreation_Should_Correct()
        {
            //Guid clienteId = Guid.NewGuid();
            DateTime FechaIngreso = DateTime.Now;
            DateTime FechaSalida = DateTime.Now;

            Estadia estadia = new Estadia(FechaIngreso, FechaSalida);

            Assert.NotNull(estadia.FechaIngreso);
            Assert.Equal(FechaIngreso, (DateTime)estadia.FechaIngreso);

            Assert.NotNull(estadia.FechaSalida);
            Assert.Equal(FechaSalida, (DateTime)estadia.FechaSalida);

        }

        [Fact]
        public void EstadiaAtributte_Should_Correct()
        {
            //Guid clienteId = Guid.NewGuid();
            /// comparamos una fecha anterios a la actual
            DateTime FechaIngreso = DateTime.Parse("2022-12-12");
            DateTime FechaSalida = DateTime.Parse("2022-12-12");

            Assert.Throws<BussinessRuleValidationException>(() => new Estadia(FechaIngreso, FechaSalida));

        }

    }
}


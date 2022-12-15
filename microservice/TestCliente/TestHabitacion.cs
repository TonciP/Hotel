
using Reserva.Domain.Model.Estadias;
using Reserva.Domain.Model.TipoHabitaciones;
using ShareKernel.Core;
using Xunit;

namespace TestCliente
{
    public class TestHabitacion
    {
        [Fact]
        public void HabitacionCreation_Should_Correct()
        {
            //Guid clienteId = Guid.NewGuid();
            string nombreHabitacion = "asd";
            string descripcion = "asd";
            int cantidaDisponible = 10;
            decimal costo = 100;

            TipoHabitacion habitacion = new TipoHabitacion(nombreHabitacion, descripcion, cantidaDisponible, costo);

            //Assert.Throws<BussinessRuleValidationException>(() => new TipoHabitacion(nombreHabitacion, descripcion, cantidaDisponible, costo));

            Assert.NotNull(habitacion.NombreHabitacion);
            Assert.Equal(nombreHabitacion, habitacion.NombreHabitacion);

            Assert.NotNull(habitacion.Descripcion);
            Assert.Equal(descripcion, habitacion.Descripcion);

            Assert.NotNull(habitacion.CantidadDisponible);
            Assert.Equal(cantidaDisponible, (int)habitacion.CantidadDisponible);

            Assert.NotNull(habitacion.Costo);
            Assert.Equal(costo, (decimal)habitacion.Costo);
        }

        [Fact]
        public void HabitacionAtribute_Should_Correct()
        {
            //Guid clienteId = Guid.NewGuid();
            string nombreHabitacion = "asd";
            string descripcion = "asd";
            int cantidaDisponible = -1;
            decimal costo = 100;

            //TipoHabitacion habitacion = new TipoHabitacion(nombreHabitacion, descripcion, cantidaDisponible, costo);

            Assert.Throws<BussinessRuleValidationException>(() => new TipoHabitacion(nombreHabitacion, descripcion, cantidaDisponible, costo));
        }


    }
}


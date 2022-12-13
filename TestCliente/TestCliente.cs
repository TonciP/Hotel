using Reserva.Domain.Model.Clientes;
using ShareKernel.Core;
using Xunit;

namespace TestCliente
{
    public class TestCliente
    {
        [Fact]
        public void ClientCreation_Should_Correct()
        {
            //Guid clienteId = Guid.NewGuid();
            string nombres = "Marcos Antonio";
            string apellidos = "Mercado Aguirre";
            string email = "56350a@nur.edu";
            string direccion = "B/ Navidad";
            string telefono = "77777777";

            Cliente cliente = new Cliente(nombres, apellidos, email, direccion, telefono);

            Assert.NotNull(cliente.Nombres);
            Assert.Equal(nombres, cliente.Nombres);

            Assert.NotNull(cliente.Apellidos);
            Assert.Equal(apellidos, cliente.Apellidos);

            Assert.NotNull(cliente.Email);
            Assert.Equal(email, cliente.Email);

            Assert.NotNull(cliente.Direccion);
            Assert.Equal(direccion, cliente.Direccion);

            Assert.NotNull(cliente.Telefono);
            Assert.Equal(telefono, cliente.Telefono);


        }
        [Fact]
        public void ClientEdit_Should_Correct()
        {
            //Guid clienteId = Guid.NewGuid();
            string nombres = "Marcos Antonio";
            string apellidos = "Mercado Aguirre";
            string email = "56350a@nur.edu";
            string direccion = "B/ Navidad";
            string telefono = "77777777";

            Cliente cliente = new Cliente(nombres, apellidos, email, direccion, telefono);
            cliente.EditCliente("Luis", "Indio", "608245@nur.edu.bo", "C/Tarija", "62056948");

            var expectedNombre = "Luis";
            Assert.NotNull(cliente.Nombres);
            Assert.Equal(expectedNombre, cliente.Nombres);

            var expectedApellidos = "Indio";
            Assert.NotNull(cliente.Apellidos);
            Assert.Equal(expectedApellidos, cliente.Apellidos);

            var expectedEmail = "608245@nur.edu.bo";
            Assert.NotNull(cliente.Email);
            Assert.Equal(expectedEmail, cliente.Email);

            var expectedDireccion = "C/Tarija";
            Assert.NotNull(cliente.Direccion);
            Assert.Equal(expectedDireccion, cliente.Direccion);

            var expectedTelefono = "62056948";
            Assert.NotNull(cliente.Telefono);
            Assert.Equal(expectedTelefono, cliente.Telefono);

        }
        [Fact]
        public void ClientAttributeTelefono_Should_Correct()
        {
            //Guid clienteId = Guid.NewGuid();
            string nombres = "Marcos Antonio";
            string apellidos = "Mercado Aguirre";
            string email = "56350a@nur.edu";
            string direccion = "B/ Navidad";
            string telefono = "77777777";

            
            Cliente cliente = new Cliente(nombres, apellidos, email, direccion, telefono);
            Assert.Throws<BussinessRuleValidationException>(() => cliente.EditCliente("Luis", "Indio", "608245@nur.edu.bo", "C/Tarija", "620569484"));
            

            //var expectedNombre = "Luis";
            //Assert.NotNull(cliente.Nombres);
            //Assert.Equal(expectedNombre, cliente.Nombres);

            //var expectedApellidos = "Indio";
            //Assert.NotNull(cliente.Apellidos);
            //Assert.Equal(expectedApellidos, cliente.Apellidos);

            //var expectedEmail = "608245@nur.edu.bo";
            //Assert.NotNull(cliente.Email);
            //Assert.Equal(expectedEmail, cliente.Email);

            //var expectedDireccion = "C/Tarija";
            //Assert.NotNull(cliente.Direccion);
            //Assert.Equal(expectedDireccion, cliente.Direccion);

            //var expectedTelefono = "620569484";
            //Assert.NotNull(cliente.Telefono);
            //Assert.Equal(expectedTelefono, cliente.Telefono);

        }

        [Fact]
        public void ClientAttributeEmail_Should_Correct()
        {
            //Guid clienteId = Guid.NewGuid();
            string nombres = "Marcos Antonio";
            string apellidos = "Mercado Aguirre";
            string email = "608245@nur.edu.bo";
            string direccion = "B/ Navidad";
            string telefono = "77777777";


            Cliente cliente = new Cliente(nombres, apellidos, email, direccion, telefono);
            Assert.Throws<BussinessRuleValidationException>(() => cliente.EditCliente("Luis", "Indio", "608245", "C/Tarija", "620569484"));

        }
    }
}

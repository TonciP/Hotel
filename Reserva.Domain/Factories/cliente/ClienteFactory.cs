using Reserva.Domain.Model.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Factories.cliente
{
    public class ClienteFactory : IClienteFactory
    {
        public Cliente CrearCliente(string nombres, string apellidos, string email, string direccion, string telefono)
        {
            if (nombres == String.Empty || apellidos == String.Empty || email == String.Empty 
                || direccion == String.Empty || telefono == String.Empty)
            {
                throw new ArgumentException("Los campos para la reserva estan vacios");
            }
            return new Cliente(nombres,  apellidos,  email,  direccion,  telefono);
        }
    }
}

using ShareKernel.Core;
using ShareKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.ValueObjects
{
    public record class TelefonoValue : ValueObject
    {
        public string Telefono { get; }

        public TelefonoValue(string telefono)
        {
            CheckRule(new StringNotNullOrEmptyRule(telefono));
            int numero = 0;
            //if (telefono.Length != 8 || int.TryParse(telefono, out  numero) == false)
            if (telefono.Length != 8 )
            {
                //if (numero == 0)
                //    throw new BussinessRuleValidationException("Telefono debe contener solo numeros");
                //else
                    throw new BussinessRuleValidationException("Telefono debe contener 8 digitos");
            }
            Telefono = telefono;
        }

        public static implicit operator string(TelefonoValue value)
        {
            return value.Telefono;
        }

        public static implicit operator TelefonoValue(string telefono)
        {
            return new TelefonoValue(telefono);
        }
    }
}

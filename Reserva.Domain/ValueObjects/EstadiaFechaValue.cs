using ShareKernel.Core;
using ShareKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.ValueObjects
{
    public record class EstadiaFechaValue : ValueObject
    {
        public DateTime Ingreso { get; }

        public EstadiaFechaValue(DateTime ingreso)
        {
            CheckRule(new NotNullRule(ingreso));
            DateTime thisDay = DateTime.Today;
            bool ano = false;
            bool mes = false;
            bool dia = false;

            if (ingreso.Year < thisDay.Year)
            {
                throw new BussinessRuleValidationException("La Fecha de ingreso no puede ser menor a la fecha Actual");
            }
            if(ingreso.Month < thisDay.Month)
            {
                throw new BussinessRuleValidationException("La Fecha de ingreso no puede ser menor a la fecha Actual");
            }
            if(ingreso.Day < thisDay.Day)
            {
                throw new BussinessRuleValidationException("La Fecha de ingreso no puede ser menor a la fecha Actual");
            }

            Ingreso = ingreso;
        }

        public static implicit operator DateTime(EstadiaFechaValue value)
        {
            return value.Ingreso;
        }

        public static implicit operator EstadiaFechaValue(DateTime ingreso)
        {
            return new EstadiaFechaValue(ingreso);
        }
    }
}

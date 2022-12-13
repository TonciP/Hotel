using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Reserva.Domain.Factories.cliente;
using Reserva.Domain.Factories.habitacion;
using Reserva.Domain.Factories.reserva;
using Reserva.Domain.Factories.tipohabitacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Aplication.Utils
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddScoped<IClienteFactory, ClienteFactory>();
            services.AddScoped<IReservaFactory, ReservaFactory>();
            services.AddScoped<ITipoHabitacionFactory, TipoHabitacionFactory>();

            return services;
        }
    }
}

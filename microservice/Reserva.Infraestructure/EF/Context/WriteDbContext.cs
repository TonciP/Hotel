using Microsoft.EntityFrameworkCore;
using Reserva.Domain.Model.Clientes;
using Reserva.Domain.Model.Estadias;
using Reserva.Domain.Model.Reservas;
using Reserva.Domain.Model.TipoHabitaciones;
using Reserva.Domain.Model.Trackings;
using Reserva.Infraestructure.EF.Config.ReadConfig;
using Reserva.Infraestructure.EF.Config.WriteConfig;
using Reserva.Infraestructure.EF.ReadModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infraestructure.EF.Context
{
    internal class WriteDbContext : DbContext
    {
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Tracking> Tracking { get; set; }
        public virtual DbSet<Reservar> Reservar { get; set; }
        public virtual DbSet<TipoHabitacion> TipoHabitacion { get; set; }

        public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration<Cliente>(new ClienteWriteConfig());
            modelBuilder.ApplyConfiguration<Estadia>(new EstadiaWriteConfig());
            modelBuilder.ApplyConfiguration<TipoHabitacion>(new TipoHabitacionWriteConfig());
            modelBuilder.ApplyConfiguration<Tracking>(new TrackingWriteConfig());
            modelBuilder.ApplyConfiguration<Reservar>(new ReservaWriteConfig());


        }
    }
}

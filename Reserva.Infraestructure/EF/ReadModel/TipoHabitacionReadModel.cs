using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infraestructure.EF.ReadModel
{
    internal class TipoHabitacionReadModel
    {
        public Guid Id { get; set; }
        public string NombreHabitacion { get;  set; }
        public string Descripcion { get;  set; }
        public int CantidadDisponible { get;  set; }
        public decimal Costo { get;  set; }
    }
}

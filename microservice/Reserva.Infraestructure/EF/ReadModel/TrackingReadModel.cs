using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infraestructure.EF.ReadModel
{
    internal class TrackingReadModel
    {
        public Guid Id { get; set; }
        public string Hash { get; private set; }
        public DateTime Duracion { get; private set; }
    }
}

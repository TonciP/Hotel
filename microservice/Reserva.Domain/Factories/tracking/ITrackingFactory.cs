using Reserva.Domain.Model.Trackings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Factories.tracking
{
    public interface ITrackingFactory
    {
        Tracking CrearTracking();
    }
}

using Reserva.Domain.Model.Trackings;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Repositories
{
    public interface ITrackingRepository : IRepository<Tracking, Guid>
    {
        Task UpdateAsync(Tracking obj);
    }
}

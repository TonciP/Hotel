using Reserva.Domain.Model.Trackings;
using Reserva.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infraestructure.EF.Repository
{
    internal class TrackingRepository : ITrackingRepository
    {
        public Task CreateAsync(Tracking obj)
        {
            throw new NotImplementedException();
        }

        public Task<Tracking> FindByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Tracking obj)
        {
            throw new NotImplementedException();
        }
    }
}

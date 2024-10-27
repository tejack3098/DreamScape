using DreamScape.Application.Common.Interfaces;
using DreamScape.Domain.Entities;

namespace DreamScape.Application.Common.Interfaces
{
    public interface IBookingRepository : IRepository<Booking>
    {
        void Update(Amenity entity);
    }
}

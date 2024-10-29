using DreamScape.Application.Common.Interfaces;
using DreamScape.Domain.Entities;

namespace DreamScape.Application.Common.Interfaces
{
    public interface IBookingRepository : IRepository<Booking>
    {
        void Update(Amenity entity);

        void UpdateStatus(int bookingId, string bookingStatus, int villaNumber);

        void UpdateStripePaymentID(int bookingId, string sessionId, string paymentIntentId);
    }
}

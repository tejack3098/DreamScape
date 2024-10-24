using DreamScape.Application.Common.Interfaces;
using DreamScape.Domain.Entities;

namespace DreamScape.Application.Common.Interfaces
{
    public interface IAmenityRepository : IRepository<Amenity>
    {
        void Update(Amenity entity);
    }
}

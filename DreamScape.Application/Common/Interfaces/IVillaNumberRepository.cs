using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamScape.Domain.Entities;

namespace DreamScape.Application.Common.Interfaces
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        void Update(VillaNumber entity);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamScape.Application.Common.Interfaces;
using DreamScape.Domain.Entities;
using DreamScape.Infrastructure.Data;

namespace DreamScape.Infrastructure.Repository
{
    public class VillaNumberRepository : Repository<VillaNumber>, IVillaNumberRepository
    {
        private readonly ApplicationDbContext _db;

        public VillaNumberRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(VillaNumber entity)
        {
            _db.VillaNumbers.Update(entity);
        }
    }
}

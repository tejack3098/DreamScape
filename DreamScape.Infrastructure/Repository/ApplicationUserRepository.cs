using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamScape.Application.Common.Interfaces;
using DreamScape.Domain.Entities;
using DreamScape.Infrastructure.Data;
using DreamScape.Infrastructure.Repository;

namespace DreamScape.Infrastructure.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;

        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

    }
}

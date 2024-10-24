﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DreamScape.Application.Common.Interfaces;
using DreamScape.Domain.Entities;
using DreamScape.Infrastructure.Data;

namespace DreamScape.Infrastructure.Repository
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDbContext _db;

        public VillaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Villa entity)
        {
            _db.Update(entity);
        }
    }
}

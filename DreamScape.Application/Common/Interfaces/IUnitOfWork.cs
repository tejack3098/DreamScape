﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamScape.Application.Common.Interfaces;

namespace DreamScape.Application.Common.Interfaces
{
    public interface IUnitOfWork
    {
        IVillaRepository Villa {  get; }

        IVillaNumberRepository VillaNumber { get; }

        IAmenityRepository Amenity { get; }

        void Save();
    }
}
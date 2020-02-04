using Data;
using Data.Models;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Repository
{
    public class MotorcycleRepository : Repository<Motorcycle>, IMotorcycleRepository
    {
        public MotorcycleRepository(AutoniverseContext context) : base(context)
        {

        }
    }
}

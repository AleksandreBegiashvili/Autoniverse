using Data;
using Data.Models;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Repository
{
    public class MotorcycleCategoryRepository : Repository<MotorcycleCategory>, IMotorcycleCategoryRepository
    {
        public MotorcycleCategoryRepository(AutoniverseContext context) : base(context)
        {

        }
    }
}

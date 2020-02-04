using Data;
using Data.Models;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Repository
{
    public class CarCategoryRepository : Repository<CarCategory>, ICarCategoryRepository
    {
        public CarCategoryRepository(AutoniverseContext context) : base(context)
        {

        }
    }
}

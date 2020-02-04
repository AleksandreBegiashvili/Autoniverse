using Data;
using Data.Models;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Repository
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        public CarRepository(AutoniverseContext context) : base(context)
        {

        }
    }
}

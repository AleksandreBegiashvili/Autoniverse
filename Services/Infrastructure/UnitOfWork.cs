using Data;
using Services.Interface;
using Services.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AutoniverseContext context;

        public UnitOfWork(AutoniverseContext context)
        {
            this.context = context;
            Cars = new CarRepository(context);
            CarCategories = new CarCategoryRepository(context);

            Motorcycles = new MotorcycleRepository(context);
            MotorcycleCategories = new MotorcycleCategoryRepository(context);
        }

        public ICarRepository Cars { get; private set; }
        public ICarCategoryRepository CarCategories { get; private set; }

        public IMotorcycleRepository Motorcycles { get; private set; }
        public IMotorcycleCategoryRepository MotorcycleCategories { get; private set; }


        public bool Complete()
        {
            return context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            context.Dispose();
        }

    }
}

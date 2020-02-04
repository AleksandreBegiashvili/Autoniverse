using Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        ICarRepository Cars { get; }
        ICarCategoryRepository CarCategories { get; }

        IMotorcycleRepository Motorcycles { get; }
        IMotorcycleCategoryRepository MotorcycleCategories { get; }

        bool Complete();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradox.Data.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }
        IOperationClimeRepository OperationClimes { get; }
        IUserOperationClimesRepository UserOperationClimes { get; }
        IUserRepository Users { get; }
        Task<int> SaveAsync();
    }
}

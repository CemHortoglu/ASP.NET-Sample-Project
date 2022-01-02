using Paradox.Data.Abstract;
using Paradox.Data.Concrete.EntityFramework.Contexts;
using Paradox.Data.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradox.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ParadoxContext _context;
        private EfProductRepository _productRepository;
        private EfCategoryRepository _categoryRepository;
        private EfOperationClimeRepository _operationClimeRepository;
        private EfUserOperationClimesRepository _userOperationClimesRepository;
        private EfUserRepository _userRepository;
        public UnitOfWork(ParadoxContext context)
        {
            _context = context;
        }
        public IProductRepository Products => _productRepository ?? new EfProductRepository(_context);
        public ICategoryRepository Categories => _categoryRepository ?? new EfCategoryRepository(_context);
        public IOperationClimeRepository OperationClimes => _operationClimeRepository ?? new EfOperationClimeRepository(_context);
        public IUserOperationClimesRepository UserOperationClimes => _userOperationClimesRepository ?? new EfUserOperationClimesRepository(_context);
        public IUserRepository Users => _userRepository ?? new EfUserRepository(_context);

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Paradox.Data.Abstract;
using Paradox.Entities.Concrete;
using Paradox.Shared.Data.Concrete.EntityFramework;
using Paradox.Shared.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradox.Data.Concrete.EntityFramework.Repositories
{
    public class EfUserOperationClimesRepository : EfEntityRepositoryBase<UserOperationClimes>, IUserOperationClimesRepository
    {
        public EfUserOperationClimesRepository(DbContext context) : base(context)
        {
        }
    }
}
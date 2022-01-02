using Paradox.Entities.Concrete;
using Paradox.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradox.Data.Abstract
{
    public interface IProductRepository : IEntityRepository<Product>
    {
    }
}

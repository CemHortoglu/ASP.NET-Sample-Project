using Paradox.Entities.Concrete;
using Paradox.Shared.Entities.Concrete;
using Paradox.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradox.Services.Abstract
{
    public interface IUserService
    {
        Task<IDataResult<OperationClime>> GetClimeWithUserId(int Id);
    }
}

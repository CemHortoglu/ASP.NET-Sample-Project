using AutoMapper;
using Microsoft.Extensions.Localization;
using Paradox.Data.Abstract;
using Paradox.Entities.Concrete;
using Paradox.Services.Abstract;
using Paradox.Shared.Entities.Concrete;
using Paradox.Shared.Resources;
using Paradox.Shared.Utilities.Results.Abstract;
using Paradox.Shared.Utilities.Results.ComplexTypes;
using Paradox.Shared.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradox.Services.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<Localization> _localizer;
        public UserManager(IUnitOfWork unitOfWork, IMapper mapper, IStringLocalizer<Localization> localizer)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _localizer = localizer;
        }
        public async Task<IDataResult<OperationClime>> GetClimeWithUserId(int Id)
        {
            var data = await _unitOfWork.UserOperationClimes.GetAsync(x => x.UserId == Id, m => m.OperationClime);
            if (data != null && data.OperationClime != null)
            {
                return new DataResult<OperationClime>(ResultStatus.Success, data.OperationClime);
            }
            return new DataResult<OperationClime>(ResultStatus.Error, _localizer["NoRecordsFound"], null);
        }
    }
}

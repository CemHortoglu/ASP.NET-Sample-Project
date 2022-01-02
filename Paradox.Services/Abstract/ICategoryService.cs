using Paradox.Entities.Concrete;
using Paradox.Entities.Dtos;
using Paradox.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradox.Services.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<Category>> Get(int categoryId);
        Task<IDataResult<IList<Category>>> GetAll();
        Task<IDataResult<CategoryListDto>> GetAllByNonDeleted();
        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAndActive();
        Task<IResult> Add(CategoryAddDto categoryAddDto, string CreatedByName);
        Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string ModifiedByName);
        Task<IResult> Delete(int categoryId, string ModifiedByName);
        Task<IResult> HardDelete(int categoryId);
    }
}

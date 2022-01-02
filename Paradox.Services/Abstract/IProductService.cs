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
   public interface IProductService
    {
        Task<IDataResult<Product>> Get(int Id);
        Task<IDataResult<ProductListDto>> GetAll();
        Task<IDataResult<ProductListDto>> GetAllByNonDeletedAndActive();
        Task<IDataResult<ProductListDto>> GetAllByCategory(int categoryId);
        Task<IResult> Add(ProductAddDto articleAddDto, string createdByName);
        Task<IResult> Update(ProductUpdateDto articleUpdateDto, string modifiedByName);
        Task<IResult> Delete(int Id, string modifiedByName);
        Task<IResult> HardDelete(int Id);
        Task<IDataResult<IList<Product>>> GetLastProducts(int row, int page, int categoryId);
    }
}

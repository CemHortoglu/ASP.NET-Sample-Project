using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Localization;
using Paradox.Data.Abstract;
using Paradox.Entities.Concrete;
using Paradox.Entities.Dtos;
using Paradox.Services.Abstract;
using Paradox.Shared.Resources;
using Paradox.Shared.Utilities.Results.Abstract;
using Paradox.Shared.Utilities.Results.ComplexTypes;
using Paradox.Shared.Utilities.Results.Concrete;

namespace Paradox.Services.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<Localization> _localizer;
        public ProductManager(IUnitOfWork unitOfWork, IMapper mapper, IStringLocalizer<Localization> localizer)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _localizer = localizer;
        }

        public async Task<IDataResult<Product>> Get(int Id)
        {
            var data = await _unitOfWork.Products.GetAsync(x => x.Id == Id, x => x.Category);
            if (data != null)
            {
                return new DataResult<Product>(ResultStatus.Success, data);
            }
            return new DataResult<Product>(ResultStatus.Error, _localizer["NoRecordsFound"], null);
        }

        public async Task<IDataResult<ProductListDto>> GetAll()
        {
            var data = await _unitOfWork.Products.GetAllAsync(null, x => x.Category);
            if (data.Count > -1)
            {
                return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto()
                {
                    Products = data,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProductListDto>(ResultStatus.Error, _localizer["NoRecordsFound"], null);
        }

        public async Task<IDataResult<ProductListDto>> GetAllByNonDeletedAndActive()
        {
            var data = await _unitOfWork.Products.GetAllAsync(x => !x.IsDeleted && x.IsActive, x => x.Category);
            if (data.Count > -1)
            {
                return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto()
                {
                    Products = data,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProductListDto>(ResultStatus.Error, _localizer["NoRecordsFound"], null);
        }

        public async Task<IDataResult<ProductListDto>> GetAllByCategory(int categoryId)
        {
            var result = await _unitOfWork.Categories.AnyAsync(c => c.Id == categoryId);
            if (result)
            {
                var data = await _unitOfWork.Products.GetAllAsync(x => x.CategoryId == categoryId && !x.IsDeleted && x.IsActive, x => x.Category);

                if (data.Count > -1)
                {
                    return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto()
                    {
                        Products = data,
                        ResultStatus = ResultStatus.Success
                    });
                }
            }
            return new DataResult<ProductListDto>(ResultStatus.Error, _localizer["NoRecordsFound"], null);
        }

        public async Task<IResult> Add(ProductAddDto articleAddDto, string createdByName)
        {
            var data = _mapper.Map<Product>(articleAddDto);


            await _unitOfWork.Products.AddAsync(data).ContinueWith(t => _unitOfWork.SaveAsync());
            return new Result(ResultStatus.Success, _localizer["0AddedSuccessfully", data.Title]);
        }

        public async Task<IResult> Update(ProductUpdateDto articleUpdateDto, string modifiedByName)
        {
            var data = _mapper.Map<Product>(articleUpdateDto);


            await _unitOfWork.Products.UpdateAsync(data).ContinueWith(t => _unitOfWork.SaveAsync());
            return new Result(ResultStatus.Success, _localizer["0UpdatedSuccessfully", data.Title]);
        }

        public async Task<IResult> Delete(int Id, string modifiedByName)
        {
            var result = await _unitOfWork.Products.AnyAsync(c => c.Id == Id);
            if (result)
            {
                var data = await _unitOfWork.Products.GetAsync(c => c.Id == Id);
                data.ModifiedDate = DateTime.Now;
                data.IsDeleted = true;
                data.IsActive = false;

                await _unitOfWork.Products.UpdateAsync(data).ContinueWith(t => _unitOfWork.SaveAsync());
                return new Result(ResultStatus.Success, _localizer["0DeletedSuccessfully", data.Title]);
            }
            return new DataResult<ProductListDto>(ResultStatus.Error, _localizer["NoRecordsFound"], null);
        }

        public async Task<IResult> HardDelete(int Id)
        {
            var result = await _unitOfWork.Products.GetAsync(x => x.Id == Id);

            if (result != null)
            {
                var data = await _unitOfWork.Products.GetAsync(c => c.Id == Id);
                await _unitOfWork.Products.DeleteAsync(data).ContinueWith(x => _unitOfWork.SaveAsync());
                return new Result(ResultStatus.Success, _localizer["0DeletedSuccessfully", data.Title]);
            }

            return new DataResult<ProductListDto>(ResultStatus.Error, _localizer["NoRecordsFound"], null);
        }

        public async Task<IDataResult<IList<Product>>> GetLastProducts(int row, int page, int categoryId)
        {
            var count = 0;
            if (page > 0)
            {
                count = row * (page + 1);
            }

            var model = await _unitOfWork.Products.GetAllAsync(c => c.IsActive == true, x => x.Category);


            if (categoryId > 0)
            {
                model = model.Where(o => o.CategoryId == categoryId).ToList();
            }
            model = model.OrderByDescending(o => o.Id).Take(row).Skip(count).ToList();

            if (model != null)
            {
                return new DataResult<IList<Product>>(ResultStatus.Success, model);
            }
            return new DataResult<IList<Product>>(ResultStatus.Error, _localizer["NoRecordsFound"], null);
        }
    }
}

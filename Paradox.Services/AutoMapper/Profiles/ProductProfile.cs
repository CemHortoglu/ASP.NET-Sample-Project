using AutoMapper;
using Paradox.Entities.Concrete;
using Paradox.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradox.Services.AutoMapper.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductAddDto, Product>().ForMember(x => x.CreatedDate, o =>
                o.MapFrom(x => DateTime.Now));
            CreateMap<ProductUpdateDto, Product>().ForMember(x => x.ModifiedDate, o =>
                o.MapFrom(x => DateTime.Now));
        }
    }
}

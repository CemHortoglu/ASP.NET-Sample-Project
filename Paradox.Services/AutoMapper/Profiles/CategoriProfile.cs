using Paradox.Entities.Concrete;
using Paradox.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
namespace Paradox.Services.AutoMapper.Profiles
{
    public class CategoriProfile : Profile
    {
        public CategoriProfile()
        {
            CreateMap<CategoryAddDto, Category>().ForMember(x => x.CreatedDate, o =>
                o.MapFrom(x => DateTime.Now));
            CreateMap<CategoryUpdateDto, Category>().ForMember(x => x.ModifiedDate, o =>
                o.MapFrom(x => DateTime.Now));
        }
    }
}

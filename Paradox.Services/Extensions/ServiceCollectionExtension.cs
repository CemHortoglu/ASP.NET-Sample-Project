using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paradox.Data.Abstract;
using Paradox.Data.Concrete;
using Paradox.Data.Concrete.EntityFramework.Contexts;
using Paradox.Services.Abstract;
using Paradox.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace Paradox.Services.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ParadoxContext>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<ICategoryService, CategoryManager>();
            serviceCollection.AddScoped<IProductService, ProductManager>();
            serviceCollection.AddScoped<IUserService, UserManager>();

            return serviceCollection;
        }
    }
}

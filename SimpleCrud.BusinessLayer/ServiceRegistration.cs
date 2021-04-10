using Microsoft.Extensions.DependencyInjection;
using SimpleCrud.BusinessLayer.Services.Implement;
using SimpleCrud.BusinessLayer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.BusinessLayer
{
    public static class ServiceRegistration
    {
        public static void AddBusinessLayerInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
        }
    }
}

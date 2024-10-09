using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using SistemaGestionBussiness;
using SistemaGestionData;
using Microsoft.Extensions.DependencyInjection;


namespace SistemaGestionBussiness
{
    public static class ConfigureServices
    {
        public static IServiceCollection ConfigureBussinessLayer(this IServiceCollection services)
        {
            services.AddScoped<ProductoBussiness>();
            services.AddScoped<ProductoVendidoBussiness>();
            services.AddScoped<UsuarioBussiness>();
            services.AddScoped<VentaBussiness>();

            return services;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PicPaySimplificado.Infrastructure.DataAccess;

namespace PicPaySimplificado.Infrastructure
{
    public static class DependencyInjectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            AddDbContext_MySql(services, configuration);
        }

        private static void AddDbContext_MySql(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnectionMySql");

            services.AddDbContext<PicPaySimplificadoDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
        }
    }
}

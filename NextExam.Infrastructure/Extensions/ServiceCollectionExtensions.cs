using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NextExam.Infrastructure.Persistence;

namespace NextExam.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("NextExamDB");
            services.AddDbContext<NextExamDbContext>(options => options.UseSqlServer(connectionString));

      
        }
    }
}
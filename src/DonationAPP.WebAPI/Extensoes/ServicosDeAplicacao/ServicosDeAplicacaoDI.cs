using DonationAPP.Infraestrutura.SQLite;
using Microsoft.EntityFrameworkCore;

namespace DonationAPP.WebAPI.Extensoes.ServicosDeAplicacao
{
    public static class ServicosDeAplicacaoDI
    {
        public static void AddDataBase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DbContexto>(options 
                => options.UseSqlite(
                    configuration.GetConnectionString("donation-app-db")));
        }
    }
}

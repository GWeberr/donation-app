using DonationAPP.Aplicacao.Servicos;
using DonationAPP.Dominio.Modelos.Instituicoes;
using DonationAPP.Infraestrutura.SQLite;
using DonationAPP.Infraestrutura.SQLite.Modelos.Instituicoes.Repositorios;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace DonationAPP.WebAPI.Extensoes.ServicosDeAplicacao
{
    public static class ServicosDeAplicacaoDI
    {
        public static void AddDataBase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DbContexto>(options 
                => options.UseSqlite(
                    configuration.GetConnectionString("donation-app-db")));

            services.AddScoped<IUnidadeDeTrabalho, UnidadeDeTrabalho>();
        }

        public static void AddRepositorios(this IServiceCollection services)
        {
            services.AddScoped<IInstituicaoRepositorio, InstituicaoRepositorio>();
        }

        public static void AddServicos(this IServiceCollection services)
        {
            services.AddScoped<InstituicaoServico>();
        }
    }
}

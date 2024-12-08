using DonationAPP.Aplicacao.Servicos;
using DonationAPP.Dominio.Modelos.Instituicoes;
using DonationAPP.Dominio.Modelos.TiposDeDoacao;
using DonationAPP.Infraestrutura.SQLite;
using DonationAPP.Infraestrutura.SQLite.Modelos.Instituicoes.Repositorios;
using DonationAPP.Infraestrutura.SQLite.Modelos.TiposDeDoacao.Repositorios;
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

            services.AddScoped<IUnidadeDeTrabalho, UnidadeDeTrabalho>();
        }

        public static void AddRepositorios(this IServiceCollection services)
        {
            services.AddScoped<IInstituicaoRepositorio, InstituicaoRepositorio>();
            services.AddScoped<ITipoDeDoacaoRepositorio, TipoDeDoacaoRepositorio>();
        }

        public static void AddServicos(this IServiceCollection services)
        {
            services.AddScoped<InstituicaoServico>();
            services.AddScoped<TipoDeDoacaoServico>();
        }
    }
}

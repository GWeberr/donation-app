using DonationAPP.WebAPI.Extensoes.CasosDeUso;
using DonationAPP.WebAPI.Extensoes.ServicosDeAplicacao;

namespace DonationAPP
{
    public sealed class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen(options =>
            {
                options.CustomSchemaIds(type => type.FullName);
            });

            builder.Services.AddCasosDeUso();
            builder.Services.AddDataBase(builder.Configuration);
            builder.Services.AddRepositorios();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}


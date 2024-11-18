# Donation APP

Projeto de API para uma aplica��o de gest�o de doa��es.

### Comandos para a manipula��o das Migrations

```
> Cria��o de nova migration

dotnet-ef migrations add **__NomeDaMigration__** --project .\DonationAPP.Infraestrutura.SQLite\DonationAPP.Infraestrutura.SQLite.csproj --startup-project .\DonationAPP.WebAPI\DonationAPP.WebAPI.csproj

> Remo��o de uma migration

dotnet-ef migrations remove --project .\DonationAPP.Infraestrutura.SQLite\DonationAPP.Infraestrutura.SQLite.csproj --startup-project .\DonationAPP.WebAPI\DonationAPP.WebAPI.csproj

> Update da base

dotnet-ef database update --connection "Data Source=..\DonationAPP.Infraestrutura.SQLite\DB\DonationApp.db" --project .\DonationAPP.Infraestrutura.SQLite\DonationAPP.Infraestrutura.SQLite.csproj --startup-project .\DonationAPP.WebAPI\DonationAPP.WebAPI.csproj

```
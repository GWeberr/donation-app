# Donation APP

Projeto de API para uma aplicação de gestão de doações.

### Comandos para a manipulação das Migrations

```
> Criação de nova migration

dotnet-ef migrations add **__NomeDaMigration__** --project .\DonationAPP.Infraestrutura.SQLite\DonationAPP.Infraestrutura.SQLite.csproj --startup-project .\DonationAPP.WebAPI\DonationAPP.WebAPI.csproj

> Remoção de uma migration

dotnet-ef migrations remove --project .\DonationAPP.Infraestrutura.SQLite\DonationAPP.Infraestrutura.SQLite.csproj --startup-project .\DonationAPP.WebAPI\DonationAPP.WebAPI.csproj

> Update da base

dotnet-ef database update --connection "Data Source=..\DonationAPP.Infraestrutura.SQLite\DB\DonationApp.db" --project .\DonationAPP.Infraestrutura.SQLite\DonationAPP.Infraestrutura.SQLite.csproj --startup-project .\DonationAPP.WebAPI\DonationAPP.WebAPI.csproj

```
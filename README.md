# Donation APP

Projeto de API para uma aplicação de gestão de doações.

## Estrutura do projeto

**DonationAPP.Aplicacao**
Possui o objetivo de agrupar todos os casos de uso, colocando em prática as regras de negócio para cada endpoint do sistema de forma isolada para cada assunto.
Dessa forma nenhum endpoint é capaz de afetar a execução de outro, realizando apenas aquilo que deve fazer.
Também possui a abstração dos serviços externos ao domínio por meio de interfaces, fazendo com que nenhuma regra externa contamine a execução das regras de negócio, sabendo apenas quando realizá-las, e não como realizá-las.

**DonationAPP.Dominio**
Possui o objetivo de agrupar todas as entidades e regras de negócio do sistema, bem como seus repositórios e métodos de acesso.
Faz com que a manipulação dos dados seja totalmente blindada por meio de métodos internos de fábricas e serviços de domínio, garantindo a integridade dos dados.

**DonationAPP.Essentials**
Possui o objetivo de agrupar as abstrações gerais dos projetos, como interfaces e classes base de cada um.
Foi utilizado como um centralizador entre todos os projetos para economia de tempo.

**DonatioAPP.Infraestrutura.SQLite**
Representa a abstração do banco de daods escolhido para esse trabalho (SQLIte), bem como sua configuração com base no EntityFramework.
Possui o objetivo de isolar o banco de dados, fazendo com que as regras de negócio não dependam em nenhum aspecto do banco de dados que será usado.

**DonatioAPP.WebAPI**
Representa a camada de apresentação dos dados, onde neste trabalho foi escolhido utilizar o modelo de WebAPI com Swagger.
Possui o objetivo de estruturar os endpoints que serão utilizados para comunicação e execução das regras de negócio.
Realiza a entrada e apresentação dos dados de maneira isolada, não interferindo na execução dos casos de uso de nenhuma forma, fazendo com que seja completamente possível alterar a arquitetura de apresentação utilizada sem interferir no negócio.

### Comandos para a manipulação das Migrations

```
> Criação de nova migration

dotnet-ef migrations add NomeDaMigration --project .\DonationAPP.Infraestrutura.SQLite\DonationAPP.Infraestrutura.SQLite.csproj --startup-project .\DonationAPP.WebAPI\DonationAPP.WebAPI.csproj

> Remoção de uma migration

dotnet-ef migrations remove --project .\DonationAPP.Infraestrutura.SQLite\DonationAPP.Infraestrutura.SQLite.csproj --startup-project .\DonationAPP.WebAPI\DonationAPP.WebAPI.csproj

> Update da base

dotnet-ef database update --connection "Data Source=..\DonationAPP.Infraestrutura.SQLite\DB\DonationApp.db" --project .\DonationAPP.Infraestrutura.SQLite\DonationAPP.Infraestrutura.SQLite.csproj --startup-project .\DonationAPP.WebAPI\DonationAPP.WebAPI.csproj

```
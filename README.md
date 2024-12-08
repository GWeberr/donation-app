# Donation APP

Projeto de API para uma aplica��o de gest�o de doa��es.

## Estrutura do projeto

**DonationAPP.Aplicacao**
Possui o objetivo de agrupar todos os casos de uso, colocando em pr�tica as regras de neg�cio para cada endpoint do sistema de forma isolada para cada assunto.
Dessa forma nenhum endpoint � capaz de afetar a execu��o de outro, realizando apenas aquilo que deve fazer.
Tamb�m possui a abstra��o dos servi�os externos ao dom�nio por meio de interfaces, fazendo com que nenhuma regra externa contamine a execu��o das regras de neg�cio, sabendo apenas quando realiz�-las, e n�o como realiz�-las.

**DonationAPP.Dominio**
Possui o objetivo de agrupar todas as entidades e regras de neg�cio do sistema, bem como seus reposit�rios e m�todos de acesso.
Faz com que a manipula��o dos dados seja totalmente blindada por meio de m�todos internos de f�bricas e servi�os de dom�nio, garantindo a integridade dos dados.

**DonationAPP.Essentials**
Possui o objetivo de agrupar as abstra��es gerais dos projetos, como interfaces e classes base de cada um.
Foi utilizado como um centralizador entre todos os projetos para economia de tempo.

**DonatioAPP.Infraestrutura.SQLite**
Representa a abstra��o do banco de daods escolhido para esse trabalho (SQLIte), bem como sua configura��o com base no EntityFramework.
Possui o objetivo de isolar o banco de dados, fazendo com que as regras de neg�cio n�o dependam em nenhum aspecto do banco de dados que ser� usado.

**DonatioAPP.WebAPI**
Representa a camada de apresenta��o dos dados, onde neste trabalho foi escolhido utilizar o modelo de WebAPI com Swagger.
Possui o objetivo de estruturar os endpoints que ser�o utilizados para comunica��o e execu��o das regras de neg�cio.
Realiza a entrada e apresenta��o dos dados de maneira isolada, n�o interferindo na execu��o dos casos de uso de nenhuma forma, fazendo com que seja completamente poss�vel alterar a arquitetura de apresenta��o utilizada sem interferir no neg�cio.

### Comandos para a manipula��o das Migrations

```
> Cria��o de nova migration

dotnet-ef migrations add NomeDaMigration --project .\DonationAPP.Infraestrutura.SQLite\DonationAPP.Infraestrutura.SQLite.csproj --startup-project .\DonationAPP.WebAPI\DonationAPP.WebAPI.csproj

> Remo��o de uma migration

dotnet-ef migrations remove --project .\DonationAPP.Infraestrutura.SQLite\DonationAPP.Infraestrutura.SQLite.csproj --startup-project .\DonationAPP.WebAPI\DonationAPP.WebAPI.csproj

> Update da base

dotnet-ef database update --connection "Data Source=..\DonationAPP.Infraestrutura.SQLite\DB\DonationApp.db" --project .\DonationAPP.Infraestrutura.SQLite\DonationAPP.Infraestrutura.SQLite.csproj --startup-project .\DonationAPP.WebAPI\DonationAPP.WebAPI.csproj

```
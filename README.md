# GamaParking - Sistema de Estacionamento

O GamaParking é um programa de console em C# para gerenciamento de estacionamento, permitindo o cadastro e listagem de clientes, veículos e tickets.

## Funcionalidades

O programa oferece as seguintes funcionalidades:

- Cadastro de Cliente
- Listagem de Clientes
- Cadastro de Veículo
- Listagem de Veículos
- Cadastro de Ticket
- Listagem de Tickets
- Fechamento de Ticket
- Encerramento do Programa

## Requisitos

- [.NET Core SDK](https://dotnet.microsoft.com/download) (ou posterior)

## Pacotes Utilizados

O projeto utiliza os seguintes pacotes:

- [ConsoleTables](https://www.nuget.org/packages/ConsoleTables/) (versão 2.4.2): Pacote para exibição de tabelas no console.
- [Dapper](https://www.nuget.org/packages/Dapper/) (versão 2.0.123): Um micro ORM que simplifica o acesso a bancos de dados.
- [System.Data.SQLite](https://www.nuget.org/packages/System.Data.SQLite/) (versão 1.0.117): Pacote para integração com bancos de dados SQLite.

## Como Usar

1. Clone este repositório para o seu sistema local.
2. Abra o terminal e navegue até o diretório do projeto.
3. Execute o seguinte comando para compilar e executar o programa:

```bash
dotnet run
```
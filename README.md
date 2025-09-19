# Backend - Aplicação Seguro Viagem (.NET API)

Este repositório contém o código fonte da API de backend para a aplicação de seguro viagem, desenvolvida em C# com .NET e hospedada no Azure App Service.

## Sobre a Aplicação

Gerenciamento das operações CRUD (Create, Read, Update, Delete) para os dados de seguros.

## Funcionalidades Principais

* **Lógica de Negócio (C#):** Implementa as regras de negócio para a gestão de seguros.
* **Endpoints RESTful:** Oferece uma API REST para que o frontend possa interagir com os dados de seguros (GET, POST, PUT, DELETE).
* **Validações Server-Side:** Realiza validações nos dados recebidos, garantindo as informações enviadas.
* **Persistência de Dados:** Interage com o Azure SQL Database para armazenar e recuperar dados de seguros.
* **Aplica Migrations na Publicação:** Configurado para aplicar migrações de banco de dados automaticamente durante o processo de publicação.

## Tecnologias Utilizadas

* **.NET (C#):** Framework e linguagem de programação para o desenvolvimento da API.
* **ASP.NET Core:** Para construção de APIs web.
* **Entity Framework Core:** Para interação com o banco de dados.
* **Azure App Service:** Ambiente de hospedagem para a API.
* **Azure SQL Database:** Banco de dados relacional.

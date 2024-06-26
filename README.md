# Starti API

Bem-vindo ao repositório da API do projeto Starti! Esta API foi criada para prover um Aplicativo de artigos relacionados a TI para iniciantes. A API será consumida tanto pelo aplicativo quanto pelo CMS responsável por gerir o conteúdo.

## Descrição do Projeto

Este projeto é o início de uma API RESTful desenvolvida em .NET para gerenciar artigos focados em programação para iniciantes. A API permite carregar uma lista de artigos e fornece endpoints para autenticação de usuários. No momento, estamos utilizando dados mockados até definirmos a estrutura de banco de dados definitiva.

## Tecnologias Utilizadas

- .NET 8
- C#
- ASP.NET Core
- JSON Web Tokens (JWT) para autenticação
- Arquitetura em camadas (Controller, Service, Repository, Presenter)

## Estrutura do Projeto

- **Modelos:** Define os objetos de domínio.
- **Controllers:** Gerencia as requisições HTTP e as respostas.
- **Services:** Contém a lógica de negócios.
- **Repositories:** Gerencia o acesso aos dados.
- **Presenters:** Formata os dados antes de enviá-los como resposta.

## Endpoints Disponíveis

### Autenticação
- **POST /api/auth/login**
  - Autentica um usuário e retorna um token JWT.
  - **Exemplo de Requisição:**
    ```json
    {
      "username": "user@example.com",
      "password": "yourpassword"
    }
    ```
  - **Exemplo de Resposta:**
    ```json
    {
      "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
    }
    ```

### Artigos
- **GET /api/articles**
  - Retorna uma lista de artigos focados em programação para iniciantes.
  - **Exemplo de Resposta:**
    ```json
    [
      {
        "id": "1",
        "title": "Introduction to Programming",
        "content": "This article covers the basics of programming...",
        "author": "Jane Doe",
        "createdAt": "2023-06-24T10:00:00Z",
        "updatedAt": "2023-06-24T10:00:00Z"
      },
      {
        "id": "2",
        "title": "Getting Started with Python",
        "content": "Learn how to set up your development environment...",
        "author": "John Smith",
        "createdAt": "2023-06-24T10:00:00Z",
        "updatedAt": "2023-06-24T10:00:00Z"
      }
      // Outros artigos...
    ]
    ```

## Como Executar o Projeto

### Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio Code](https://code.visualstudio.com/) ou qualquer editor de texto de sua preferência
- [Postman](https://www.postman.com/) para testar os endpoints da API

### Passo a Passo

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/starti-api.git

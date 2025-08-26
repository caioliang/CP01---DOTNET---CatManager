🐱 CatManager
Projeto acadêmico em .NET 8 com arquitetura em camadas, múltiplas APIs, aplicação MVC e bibliotecas compartilhadas.
O objetivo é gerenciar informações de gatos e integrar com API externa de curiosidades (Cat Facts), além de persistir dados em banco Oracle.

📂 Estrutura da Solução
CatManager.sln ├── ApiCatFacts # WebAPI que consome e expõe fatos sobre gatos ├── ApiOracleCats # WebAPI principal com CRUD de gatos e Oracle DB ├── WebMvcCats # Aplicação ASP.NET MVC para interação com usuários ├── Application # Regras de negócio, DTOs e Services ├── Domain # Entidades e contratos do domínio ├── Infrastructure # Persistência de dados (EF Core + Oracle)

markdown Copiar Editar

🚀 Tecnologias Utilizadas
.NET 8
ASP.NET Core WebAPI
ASP.NET Core MVC
Entity Framework Core
Oracle EF Core Provider
Swagger / OpenAPI
Injeção de Dependência (DI)
(Opcional) JWT para autenticação
(Opcional) xUnit/NUnit para testes
⚙️ Configuração
1. Variáveis de ambiente
Defina a connection string do Oracle via variável de ambiente:

Windows (PowerShell):

setx ConnectionStrings__OracleConnection "User Id=usuario;Password=senha;Data Source=//oracle.fiap.com.br:1521/orcl"
Linux/macOS (bash/zsh):

bash
Copiar
Editar
export ConnectionStrings__OracleConnection="User Id=usuario;Password=senha;Data Source=//oracle.fiap.com.br:1521/orcl"
2. Banco de Dados
Execute as migrations para criar as tabelas:

bash
Copiar
Editar
dotnet ef database update --project Infrastructure --startup-project ApiOracleCats
3. Executando os Projetos
Para rodar individualmente:

bash
Copiar
Editar
# API com banco Oracle
dotnet run --project ApiOracleCats

# API que expõe fatos sobre gatos
dotnet run --project ApiCatFacts

# Aplicação MVC
dotnet run --project WebMvcCats
As APIs expõem documentação em Swagger em:

https://localhost:5001/swagger → ApiOracleCats

https://localhost:5002/swagger → ApiCatFacts

📌 Funcionalidades
ApiOracleCats

CRUD de gatos (Nome, Idade, Raça).

Persistência em banco Oracle.

Endpoints RESTful com retornos HTTP apropriados.

ApiCatFacts

Consome API pública de curiosidades sobre gatos.

Disponibiliza endpoints para a aplicação MVC.

WebMvcCats

Interface web em Razor Pages.

Listagem, cadastro, edição e exclusão de gatos.

Exibe curiosidades sobre gatos.

Application / Domain / Infrastructure

Aplicação dividida em camadas.

Entidades e regras no Domain.

Serviços e DTOs no Application.

Repositórios, DbContext e Migrations no Infrastructure.


---

👉 Quer que eu já adicione no README alguns exemplos de **endpoints da ApiOracleCats** (ex.: `GET /api/cats`, `POST /api/cats`) para documentar o CRUD?

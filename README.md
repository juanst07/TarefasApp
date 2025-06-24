# 📝 TarefasApp

Bem-vindo ao **TarefasApp**! 🚀

Um aplicativo web simples e eficiente para gerenciar suas tarefas diárias, desenvolvido com ASP.NET Core MVC e Entity Framework Core (SQLite). Organize, crie, edite e exclua tarefas de forma prática e rápida! 

## ✨ Funcionalidades

- 📋 Listagem de tarefas
- ➕ Criação de novas tarefas
- ✏️ Edição de tarefas existentes
- ✅ Marcação de tarefas como concluídas
- ❌ Exclusão de tarefas

## 🖥️ Tecnologias Utilizadas

- ASP.NET Core MVC
- Entity Framework Core
- SQLite
- Bootstrap (layout responsivo)

## 🚦 Como Executar o Projeto

1. **Pré-requisitos:**
   - [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

2. **Clone o repositório:**
   ```bash
   git clone <url-do-repositorio>
   ```

3. **Restaure os pacotes:**
   ```bash
   dotnet restore
   ```

4. **Aplique as migrações e crie o banco de dados:**
   ```bash
   dotnet ef database update
   ```

5. **Execute o projeto:**
   ```bash
   dotnet run
   ```

6. **Acesse no navegador:**
   [http://localhost:XXXX/Tarefas](http://localhost:XXXX/Tarefas)
   
   O número será criado ao utilizar o comando dotnet run, então substitua os valores de "XXXX"

## 📂 Estrutura Principal

- `Controllers/` - Lógica de controle das rotas e ações
- `Models/` - Modelos de dados (Tarefa)
- `Views/` - Páginas de interface (Razor)
- `Data/` - Contexto do banco de dados
- `wwwroot/` - Arquivos estáticos (CSS, JS, Bootstrap)

## 🖼️ Telas

- **Lista de Tarefas:** Visualize todas as tarefas cadastradas
- **Criar Tarefa:** Adicione uma nova tarefa
- **Editar Tarefa:** Altere informações de uma tarefa existente
- **Excluir Tarefa:** Remova tarefas que não são mais necessárias

## 💡 Sobre

Este projeto foi criado para fins de estudo e demonstração de um CRUD simples com ASP.NET Core MVC. Sinta-se à vontade para contribuir ou adaptar para suas necessidades!

---

Feito por @arthrs7

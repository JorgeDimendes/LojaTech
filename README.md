# 🖥️ Descrição do Projeto
Esta é uma Web API em C# com .NET, desenvolvida para uma loja de informática, onde é possível:

- Cadastrar funcionários com níveis de acesso e autorização;
- Cadastrar clientes;
- Cadastrar e gerenciar produtos;

O projeto foi criado com foco em praticar os conceitos de desenvolvimento back-end utilizando boas práticas com Web API.

## 🛠️ Tecnologias Utilizadas
- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- SqLite
- Visual Studio 2022

## 🚀 Como Executar o Projeto
1. Clone o repositório:
```
git clone https://github.com/JorgeDimendes/LojaTech.git
```
2. Abra o projeto no Visual Studio;
3. Verifique se o banco de dados está configurado corretamente no appsettings.json;
4. Execute as migrações (se estiver usando EF Core):
```
dotnet ef database update

//Ou
update-database
```
5. Execute o projeto e teste os endpoints no Swagger
```
https://localhost:xxxx/swagger
```

## 📷 Prints
Em breve

## 📘 Status do Projeto
Em andamento

## ✍️ Autor
- 👨🏾‍💻 Jorge Menezes
- 📧 jorgedimendes@hotmail.com
- 🐙 [github.com/jorgedimendes](https://github.com/JorgeDimendes)

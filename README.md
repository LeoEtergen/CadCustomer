# CadCustomer

Projeto de cadastro de clientes desenvolvido em **C#** como parte de uma atividade da disciplina de **Interação Humano-Computador (IHC)** na **Fatec Sorocaba**. O objetivo foi criar uma aplicação funcional e responsiva, utilizando boas práticas de design e interação para melhorar a experiência do usuário.

---

## 🛠️ Tecnologias Utilizadas

- **ASP.NET Core MVC**: Estrutura para construção do projeto em arquitetura MVC.
- **Entity Framework Core**: Para integração com o banco de dados.
- **Scaffold**: Gerador de código para CRUD (Create, Read, Update, Delete) baseado no modelo de dados.
- **HTML/CSS/JavaScript**: Para a interface do usuário.

---

## 📋 Funcionalidades

- **Cadastro de Clientes**: Permite criar novos registros no sistema.
- **Edição de Clientes**: Alteração de dados já existentes.
- **Listagem**: Exibe os clientes em uma tabela.
- **Exclusão de Clientes**: Remove registros do banco de dados.
- **Máscaras de Entrada**: Campos de CEP e RG possuem máscaras e validações para prevenir erros na digitação.
- **Validação de Dados**: Garantia de consistência e integridade no frontend e backend.

---

## ⚙️ Banco de Dados

Este projeto utiliza o **Entity Framework Core** para gerenciar o banco de dados. A base de dados é criada automaticamente utilizando migrations e o método scaffold.

### Como Excutar
Rodar o comando update-database no gerenciador de pacotes Nuget (Visual Studio)

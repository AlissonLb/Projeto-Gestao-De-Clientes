## Gestão de Clientes - Sistema de Gestão

Este projeto é um sistema de gestão de clientes desenvolvido em C#. O sistema permite adicionar, listar e remover clientes, salvando os dados em um arquivo binário.

### Funcionalidades

- **Listar Clientes**: Exibe uma lista de todos os clientes cadastrados.
- **Adicionar Cliente**: Permite adicionar um novo cliente ao sistema.
- **Remover Cliente**: Permite remover um cliente do sistema.
- **Sair**: Encerra o programa.

### Estrutura do Projeto

- **Cliente**: Estrutura que define um cliente com nome, email e cpf.
- **Menu**: Enumeração que define as opções do menu.
- **Program**: Classe principal que contém a lógica do programa.

### Requisitos

- .NET Core ou .NET Framework
- Sistema Operacional: Windows, Linux ou macOS

### Como Executar

1. Clone o repositório.
2. Abra o projeto em seu IDE preferido (Visual Studio, Visual Studio Code, etc.).
3. Compile e execute o projeto.

### Funcionamento

- O programa carrega a lista de clientes a partir de um arquivo binário (`Clientes.dat`) ao iniciar.
- O usuário pode escolher entre listar, adicionar ou remover clientes, ou sair do programa.
- As alterações feitas (adição ou remoção de clientes) são salvas automaticamente no arquivo binário.

## Documentação do Sistema de Vendas XPTO
Este repositório contém o código-fonte e a documentação para o Sistema de Vendas XPTO, uma aplicação web para gerenciamento de vendas, clientes e produtos. O sistema foi desenvolvido utilizando ASP.NET Core MVC e utiliza um banco de dados PostgreSQL para armazenar os dados.

## 🚀 Visão Geral
O Sistema de Vendas XPTO é uma aplicação web desenvolvida para auxiliar na gestão de vendas, permitindo o cadastro de clientes, produtos e a realização de pedidos. A aplicação é voltada para empresas que desejam ter um controle eficiente sobre suas operações de vendas.

## 🛠️ Tecnologias Utilizadas
-ASP.NET Core MVC
-PostgreSQL 
-HTML/CSS
-Bootstrap
-JavaScript
## 📋 Funcionalidades Principais
O Sistema de Vendas XPTO possui as seguintes funcionalidades principais:

 Cadastro de Clientes
Cadastro de Produtos
Realização de Pedidos
Gestão de Carrinho de Compras
Controle de Usuários
## 💻 Instalação e Configuração
Para configurar e executar o Sistema de Vendas XPTO localmente, siga estas etapas:

Clone o repositório em sua máquina local.
Certifique-se de ter o .NET Core SDK e o PostgreSQL instalados.
Crie um banco de dados PostgreSQL.
Configure a string de conexão no arquivo appsettings.json.
Execute as migrações do banco de dados utilizando o comando dotnet ef database update.
Execute a aplicação com o comando dotnet run.
Acesse a aplicação em seu navegador utilizando o endereço http://localhost:5000.
## 📄 Documentação das Páginas
A seguir está a documentação detalhada de algumas páginas principais do sistema:

Adição de Item ao Carrinho
Esta página permite adicionar um novo item ao carrinho de compras.

Rota: /Carrinho/Create
Descrição: Permite adicionar um novo item ao carrinho.
Campos:
Nome
Quantidade
Descrição
Preço
Operações:
Adicionar um novo item ao carrinho
Retorno: Retorna para a lista de itens no carrinho após a adição.
Edição de Item no Carrinho
Esta página permite editar um item existente no carrinho de compras.

Rota: /Carrinho/Edit
Descrição: Permite editar as informações de um item no carrinho.
Campos:
Nome
Quantidade
Descrição
Preço
Operações:
Atualizar as informações de um item no carrinho
Retorno: Retorna para a lista de itens no carrinho após a edição.
Detalhes do Item no Carrinho
Esta página exibe os detalhes de um item no carrinho de compras.

Rota: /Carrinho/Details
Descrição: Exibe informações detalhadas de um item no carrinho.
Campos:
Nome
Quantidade
Descrição
Preço
Operações:
Visualizar as informações de um item no carrinho
Retorno: Permite editar ou excluir o item, ou retornar para a lista de itens no carrinho.

Esta documentação fornece uma visão geral do Sistema de Vendas XPTO, suas funcionalidades principais e detalhes sobre a configuração e execução do sistema localmente. Para mais informações, consulte o código-fonte da aplicação e sua documentação interna.
## Telas do Sistema

## Aprendizados Adquiridos
Melhores Práticas de Programação: A experiência de desenvolvimento do sistema proporcionou uma compreensão mais profunda das melhores práticas de programação, incluindo organização de código, modularidade e reutilização de componentes.

Conhecimento Avançado do Framework: O desenvolvimento do sistema permitiu explorar recursos  do framework utilizado, como ASP.NET Core, Entity Framework, Bootstrap, entre outros, aprimorando as habilidades técnicas.

Compreensão do Processo de Desenvolvimento: Participar do desenvolvimento completo de um sistema, desde a concepção até a implementação, proporcionou uma visão abrangente do processo de desenvolvimento de software, incluindo planejamento, codificação, testes e implantação.


## Página Inicial (Index)
A tela inicial do sistema de vendas XPTO, onde os usuários são recebidos com uma mensagem de boas-vindas e são apresentadas opções para acessar o sistema.

![image](https://github.com/ERISVAN253031/PedidosWeb/assets/106634122/40e05f00-2d97-4226-8680-d536af0157d4)
## Cadastro de Cliente (Create Cliente)
Permite aos usuários cadastrar novos clientes no sistema, inserindo informações como nome, CPF, email, telefone, entre outros.
![image](https://github.com/ERISVAN253031/PedidosWeb/assets/106634122/25a82aa7-55ed-4fbe-8d84-e1fbd8ed0ce3)

![image](https://github.com/ERISVAN253031/PedidosWeb/assets/106634122/55da675e-0406-43ba-a58a-a92615528a98)
## Cadastro de Produto (Create Produto)
Permite aos usuários cadastrar novos produtos no sistema, inserindo informações como nome, descrição, preço, quantidade em estoque, entre outros
![image](https://github.com/ERISVAN253031/PedidosWeb/assets/106634122/095bf9f8-ff3d-42fb-b044-b5b0c241361d)

![image](https://github.com/ERISVAN253031/PedidosWeb/assets/106634122/dbd1d438-6b5a-447b-93ed-0f4a1c577cce)

## Carrinho de Compras (Carrinho)
Lista os produtos adicionados ao carrinho de compras pelo usuário, permitindo visualizar os itens selecionados e proceder para o processo de compra.
![image](https://github.com/ERISVAN253031/PedidosWeb/assets/106634122/8883b6a6-8fb0-4d2d-82f2-b1ec2641470c)
![image](https://github.com/ERISVAN253031/PedidosWeb/assets/106634122/fc815d09-654f-44b3-84e6-8f78022c7d24)
## Detalhes do Pedido (Details Pedido)
Exibe informações detalhadas sobre um pedido específico, incluindo os produtos selecionados, quantidade, preço total, entre outros detalhes relevantes.
![image](https://github.com/ERISVAN253031/PedidosWeb/assets/106634122/0dd1d41f-cfbc-44b5-873a-0ccbab1c0268)
![image](https://github.com/ERISVAN253031/PedidosWeb/assets/106634122/34753584-c070-4a35-8371-7c432aba6102)

## Detalhes do Produto (Details Produto)
Exibe informações detalhadas sobre um pedido específico, incluindo os produtos selecionados, quantidade, preço total, entre outros detalhes relevantes.
![image](https://github.com/ERISVAN253031/PedidosWeb/assets/106634122/a6869aaf-0f76-40a1-976e-fd27f8f58166)

## Editar Produto (Edit Produto)
Permite aos usuários editar as informações de um produto existente no sistema, como nome, descrição, preço, quantidade em estoque, entre outros detalhes.
![image](https://github.com/ERISVAN253031/PedidosWeb/assets/106634122/205ec334-6096-4e06-a64d-612405328cf2)

## Editar Cliente (Edit Cliente)
Permite aos usuários editar as informações de um cliente existente no sistema, como nome, CPF, email, telefone, entre outros dados cadastrais.
![image](https://github.com/ERISVAN253031/PedidosWeb/assets/106634122/0777ee9f-09d5-4193-8ffc-daab4efc5616)
Excluir Cliente (Delete Cliente)
Permite aos usuários excluir um cliente existente no sistema, removendo todas as informações associadas a ele do banco de dados.
![image](https://github.com/ERISVAN253031/PedidosWeb/assets/106634122/f254a1e6-1bfb-4b35-bb7a-6db0ba7c0a1b)
 Cliente excluido com sucesso 
 ![image](https://github.com/ERISVAN253031/PedidosWeb/assets/106634122/e0db5b4e-a645-407c-857e-7bdd876521e3)

## 📊 Banco de Dados PostgreSQL
O Sistema de Vendas XPTO utiliza o banco de dados PostgreSQL para armazenar informações sobre clientes, produtos, pedidos e outros dados relevantes para o funcionamento da aplicação. O PostgreSQL é um sistema de gerenciamento de banco de dados relacional de código aberto conhecido por sua confiabilidade, robustez e capacidade de suportar grandes volumes de dados.


## Estrutura do Banco de Dados
O banco de dados do sistema de vendas XPTO possui várias tabelas que armazenam informações essenciais para o funcionamento do sistema, incluindo dados de clientes, produtos, pedidos e usuários. Abaixo estão algumas das principais tabelas do banco de dados:

*Clientes: Armazena informações sobre os clientes cadastrados, como nome, CPF, e-mail, celular e endereço.

*Produtos: Contém detalhes sobre os produtos disponíveis para venda, como nome, descrição, preço e quantidade em estoque.

*Pedidos: Registra informações sobre os pedidos realizados pelos clientes, incluindo os produtos selecionados, quantidades, valores e status do pedido.

*Usuários: Mantém os dados dos usuários do sistema, como nome de usuário, senha e permissões de acesso.

![image](https://github.com/ERISVAN253031/PedidosWeb/assets/106634122/102b66ef-e24b-431a-997e-2da55ad35979)














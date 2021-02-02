# Venda Simples API

Venda Simples API é a API de dados do Venda Simples App

## Rotas

As seguintes rotas foram criadas:

```bash
Busca Todos os Produtos Cadastrados
GET /api/Produto/

Busca um produto especifico
GET /api/Produto/X

Cria um novo produto
POST /api/Produto/
BODY
{
  Nome: "Camiseta",
  Preco: "10.00",
  PrecoCusto:"2.00",
  Unidade: "PÇ"
}

Deleta um novo produto especifico
DELETE/api/Produto/X


```

## Tecnologias

```python
.Net Core 3.1
Dapper
AutoMapper
Sql Server
Swagger
```


## Dependências

```
Necessário criar a base de dados:

create database VendaSimples

create table Produto
(
	id int primary key identity(1,1),
	nome varchar(50) NOT NULL, 
	preco money NOT NULL,
	preco_custo money NOT NULL, 
	unidade varchar(3) NOT NULL,
	imagem varbinary(max)

)
```

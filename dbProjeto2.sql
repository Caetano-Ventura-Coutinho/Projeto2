create database dbProjeto2;
use dbProjeto2;

create table tbUsuario(
IdUser int auto_increment primary key,
Nome varchar(100),
Email varchar(100),
Senha varchar(100)
);

create table tbProduto(
IdProd int auto_increment primary key,
Nome varchar(100),
Descricao varchar(200),
Preco decimal(8,2),
Qtd int);


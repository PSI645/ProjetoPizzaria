-- CRIANDO BANDO DE DADOS

create database dbpizza;

-- USANDO O BANCO DE DADOS 

use dbpizza;

-- CRIANDO AS TABELA DO BANCO DE DADOS

create table tbpedido(
codpedido int primary key auto_increment,
tipoPizza varchar(50),
valorPizza Varchar(50),
valorOpcao varchar(50),
valortotal varchar(50)
);

-- CONSULTANDO AS TABELAS DO BANCO DE DADOS

select *from tbpedido;

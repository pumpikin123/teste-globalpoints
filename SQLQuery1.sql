create database globall
use globall

create table produtos(
cod_prod int primary key identity(1,1) not null,
valor float not null,
nome varchar(30) not null
)	

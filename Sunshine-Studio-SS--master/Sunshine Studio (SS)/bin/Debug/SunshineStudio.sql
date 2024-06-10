drop table if exists tb_cadastro;
/*criando tabela dentro do database agencia_foto*/
create table tb_cadastro (
    cpf varchar (14) not null primary key,--cpf chave primária, não pode ser editado
    nome varchar (60) not null, 
    email varchar (40) not null,
    data_nasc varchar (10) not null,
    celular varchar (20) not null,
	usuario varchar (20) not null,
	senha varchar (20) not null,
	status varchar (20) not null);
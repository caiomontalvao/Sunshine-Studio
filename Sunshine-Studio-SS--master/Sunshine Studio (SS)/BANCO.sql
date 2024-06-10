use agencia_foto;

drop table if exists tb_cadastro;

CREATE TABLE tb_cadastro (
    cpf VARCHAR(14) NOT NULL PRIMARY KEY,
    nome VARCHAR(60) NOT NULL, 
    email VARCHAR(40) NOT NULL,
    data_nasc DATE NOT NULL,
    celular VARCHAR(15) NOT NULL,
    usuario VARCHAR(20) NOT NULL,
    senha VARCHAR(20) NOT NULL,
    status VARCHAR(20) NOT NULL,
    cargo VARCHAR(20) NOT NULL
);

drop table if exists tb_clientes;


CREATE TABLE tb_clientes (
    cpf_clientes VARCHAR(14) NOT NULL primary key,
    id INT NOT NULL,
    nome VARCHAR(80) NOT NULL,
    email VARCHAR(60) NOT NULL,
    endereco VARCHAR(100) NOT NULL,
    data_nasc DATE NOT NULL,
    celular VARCHAR(15) NOT NULL,
    status VARCHAR(10) NOT NULL,
);

drop table if exists tb_sessoes;

CREATE TABLE tb_sessoes (
    id_sessao INT NOT NULL,
    cpf_clientes VARCHAR(14) NOT NULL,
    nome_cliente VARCHAR(80) NOT NULL,
    celular VARCHAR(15) NOT NULL,
    dia DATE NOT NULL,
    horario TIME NOT NULL,
    nome_fotografo VARCHAR(80) NOT NULL,
    valor DECIMAL(10, 2) NOT NULL,
    forma_pagamento VARCHAR(15) NOT NULL,
	PRIMARY KEY (id_sessao, cpf_clientes),  -- ordem alterada para seguir a ordem da declaração
	FOREIGN KEY (cpf_clientes) REFERENCES tb_clientes (cpf_clientes)
);
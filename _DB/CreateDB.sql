CREATE DATABASE AvivatecDb;

USE AvivatecDb;

CREATE TABLE Users (
	id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	nome VARCHAR(30) NOT NULL,
	email VARCHAR(30) NOT NULL,
	user_login VARCHAR(10) NOT NULL,
	user_password VARCHAR(10) NOT NULL
);

INSERT INTO Users (nome, email, user_login, user_password)
VALUES ('User Teste', 'teste@teste.com.br', 'user_teste', 'passteste')

SELECT * FROM Users
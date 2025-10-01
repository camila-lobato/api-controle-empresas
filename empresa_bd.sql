CREATE DATABASE empresa_db;

USE empresa_db;

CREATE TABLE empresa(
id_emp INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
razaoSocial_emp VARCHAR(100) NOT NULL,
nomeFantasia_emp VARCHAR(100) NOT NULL,
cnpj_emp VARCHAR(20) not null, 
inscricao_emp VARCHAR(20) NULL,
telefone_emp VARCHAR(20) NOT NULL,
email_emp VARCHAR(50) not null,
cidade_emp VARCHAR(50) NOT NULL,
estado_emp VARCHAR (2) NOT NULL,
cep_emp VARCHAR(10) NOT NULL,
dataCadastro_emp DATETIME NULL
);

INSERT INTO empresa (
    razaoSocial_emp, nomeFantasia_emp, cnpj_emp, inscricao_emp, telefone_emp,
    email_emp, cidade_emp, estado_emp, cep_emp, dataCadastro_emp
)
VALUES
(
    'Tech Solutions Ltda', 'TechSol', '12345678000195', '123456789', '11987654321',
    'contato@techsol.com', 'São Paulo', 'SP', '01000-000', NOW()
),
(
    'Alimentos Brasil S.A.', 'BrasilFoods', '98765432000187', '987654321', '21987654321',
    'sac@brasilfoods.com.br', 'Rio de Janeiro', 'RJ', '20000-000', NOW()
),
(
    'Construtora Ideal EIRELI', 'Ideal Construtora', '45678912000134', '564738291', '31986543210',
    'contato@idealconstrutora.com', 'Belo Horizonte', 'MG', '30100-000', NOW()
),
(
    'Logística Rápida Transportes ME', 'LogRápida', '32165498000122', '1122334455', '41999887766',
    'atendimento@lograpida.com', 'Curitiba', 'PR', '80000-000', NOW()
),
(
    'Farmácia Vida Bem Ltda', 'VidaBem', '15975368000109', '9988776655', '51988776655',
    'contato@vidabem.com.br', 'Porto Alegre', 'RS', '90000-000', NOW()
);

DROP DATABASE empresa_db;


CREATE TABLE Estado (
                EstadoID INT IDENTITY NOT NULL,
                Sigla CHAR(2) NOT NULL,
                Nome VARCHAR(100) NOT NULL,
                Usuario VARCHAR(255) NOT NULL,
                DataCriacao DATETIME NOT NULL,
                DataAtualizacao DATETIME NOT NULL,
                Status BIT NOT NULL,
                CONSTRAINT PK_Estado PRIMARY KEY (EstadoID)
)

CREATE TABLE Cidade (
                CidadeID INT IDENTITY NOT NULL,
                EstadoID INT NOT NULL,
                Nome VARCHAR(100) NOT NULL,
                Usuario VARCHAR(255) NOT NULL,
                DataCriacao DATETIME NOT NULL,
                DataAtualizacao DATETIME NOT NULL,
                Status BIT NOT NULL,
                CONSTRAINT PK_Cidade PRIMARY KEY (CidadeID)
)

CREATE TABLE Bairro (
                BairroID INT IDENTITY NOT NULL,
                CidadeID INT NOT NULL,
                Nome VARCHAR(100) NOT NULL,
                Usuario VARCHAR(255) NOT NULL,
                DataCriacao DATETIME NOT NULL,
                DataAtualizacao DATETIME NOT NULL,
                Status BIT NOT NULL,
                CONSTRAINT PK_Bairro PRIMARY KEY (BairroID)
)

CREATE TABLE Rua (
                RuaID INT IDENTITY NOT NULL,
                BairroID INT NOT NULL,
                Nome VARCHAR(100) NOT NULL,
                Usuario VARCHAR(255) NOT NULL,
                DataCriacao DATETIME NOT NULL,
                DataAtualizacao DATETIME NOT NULL,
                Status BIT NOT NULL,
                CONSTRAINT PK_Rua PRIMARY KEY (RuaID)
)

CREATE TABLE CEPS (
                CEP CHAR(8) NOT NULL,
                RuaID INT NOT NULL,
                CidadeID INT NOT NULL,
                EstadoID CHAR(2) NOT NULL,
                BairroID INT NOT NULL,
                Complemento VARCHAR(255),
                CONSTRAINT PK_CEPS PRIMARY KEY (CEP)
)

CREATE TABLE Endereco (
                EnderecoID INT IDENTITY NOT NULL,
                CEP CHAR(8) NOT NULL,
                Numero VARCHAR(10) NOT NULL,
                Complemento VARCHAR(100) NOT NULL,
                Usuario VARCHAR(255) NOT NULL,
                DataCriacao DATETIME NOT NULL,
                DataAtualizacao DATETIME NOT NULL,
                Status BIT NOT NULL,
                CONSTRAINT PK_Endereco PRIMARY KEY (EnderecoID)
)

ALTER TABLE Cidade ADD CONSTRAINT Estado_Cidade_fk
FOREIGN KEY (EstadoID)
REFERENCES Estado (EstadoID)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE Bairro ADD CONSTRAINT Cidade_Bairro_fk
FOREIGN KEY (CidadeID)
REFERENCES Cidade (CidadeID)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE Rua ADD CONSTRAINT Bairro_Rua_fk
FOREIGN KEY (BairroID)
REFERENCES Bairro (BairroID)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE CEPS ADD CONSTRAINT Rua_CEPS_fk
FOREIGN KEY (RuaID)
REFERENCES Rua (RuaID)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE Endereco ADD CONSTRAINT CEPS_Endereco_fk
FOREIGN KEY (CEP)
REFERENCES CEPS (CEP)
ON DELETE NO ACTION
ON UPDATE NO ACTION
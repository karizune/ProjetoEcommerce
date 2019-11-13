
CREATE TABLE Entrega.Estado (
                EstadoID INT IDENTITY NOT NULL,
                Sigla CHAR(2) NOT NULL,
                Nome VARCHAR(100) NOT NULL,
                Usuario VARCHAR(255) NOT NULL,
                DataCriacao DATETIME NOT NULL,
                DataAtualizacao DATETIME NOT NULL,
                Status BIT NOT NULL,
                CONSTRAINT PK_Estado PRIMARY KEY (EstadoID)
) 

CREATE TABLE Entrega.Cidade (
                CidadeID INT IDENTITY NOT NULL,
                EstadoID INT NOT NULL,
                Nome VARCHAR(100) NOT NULL,
                Usuario VARCHAR(255) NOT NULL,
                CriadoEm DATETIME NOT NULL,
                AtualizaEm DATETIME NOT NULL,
                Status BIT NOT NULL,
                CONSTRAINT PK_Cidade PRIMARY KEY (CidadeID)
)

CREATE TABLE Entrega.Bairro (
                BairroID INT IDENTITY NOT NULL,
                CidadeID INT NOT NULL,
                Nome VARCHAR(100) NOT NULL,
                Usuario VARCHAR(255) NOT NULL,
                CriadoEm DATETIME NOT NULL,
                AtualizaEm DATETIME NOT NULL,
                Status BIT NOT NULL,
                CONSTRAINT PK_Bairro PRIMARY KEY (BairroID)
)

CREATE TABLE Entrega.Rua (
                RuaID INT IDENTITY NOT NULL,
                BairroID INT NOT NULL,
                Nome VARCHAR(100) NOT NULL,
                Usuario VARCHAR(255) NOT NULL,
                CriadoEm DATETIME NOT NULL,
                AtualizaEm DATETIME NOT NULL,
                Status BIT NOT NULL,
                CONSTRAINT PK_Rua PRIMARY KEY (RuaID)
)

CREATE TABLE Entrega.CEPS (
                CEP CHAR(8) NOT NULL,
                RuaID INT NOT NULL,
                CidadeID INT NOT NULL,
                EstadoID CHAR(2) NOT NULL,
                BairroID INT NOT NULL,
                Complemento VARCHAR(255),
				Usuario VARCHAR(255) NOT NULL,
                CriadoEm DATETIME NOT NULL,
                AtualizaEm DATETIME NOT NULL,
                Status BIT NOT NULL,
                CONSTRAINT PK_CEPS PRIMARY KEY (CEP)
)

CREATE TABLE Entrega.Endereco (
                EnderecoID INT IDENTITY NOT NULL,
                CEP CHAR(8) NOT NULL,
                Numero VARCHAR(10) NOT NULL,
                Complemento VARCHAR(100) NOT NULL,
                Usuario VARCHAR(255) NOT NULL,
                CriadoEm DATETIME NOT NULL,
                AtualizaEm DATETIME NOT NULL,
                Status BIT NOT NULL,
                CONSTRAINT PK_Endereco PRIMARY KEY (EnderecoID)
)

ALTER TABLE Entrega.Cidade ADD CONSTRAINT Estado_Cidade_fk
FOREIGN KEY (EstadoID)
REFERENCES Estado (EstadoID)


ALTER TABLE Entrega.Bairro ADD CONSTRAINT Cidade_Bairro_fk
FOREIGN KEY (CidadeID)
REFERENCES Cidade (CidadeID)


ALTER TABLE Entrega.Rua ADD CONSTRAINT Bairro_Rua_fk
FOREIGN KEY (BairroID)
REFERENCES Bairro (BairroID)


ALTER TABLE Entrega.CEPS ADD CONSTRAINT Rua_CEPS_fk
FOREIGN KEY (RuaID)
REFERENCES Rua (RuaID)

ALTER TABLE Entrega.Endereco ADD CONSTRAINT CEPS_Endereco_fk
FOREIGN KEY (CEP)
REFERENCES CEPS (CEP)


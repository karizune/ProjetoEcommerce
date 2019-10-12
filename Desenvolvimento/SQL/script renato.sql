
CREATE TABLE TipoCampo (
                TipoCampoID INT NOT NULL,
                Descricao VARCHAR(100) NOT NULL,
                Usuario VARCHAR(50) NOT NULL,
                Status BIT NOT NULL,
                CriadoEm DATETIME NOT NULL,
                AtualizadoEm DATETIME NOT NULL,
                CONSTRAINT TipoCampo PRIMARY KEY (TipoCampoID)
)

CREATE TABLE Usuario (
                UsuarioID INT NOT NULL,
                Usuario VARCHAR(50) NOT NULL,
                Status BIT NOT NULL,
                CriadoEm DATETIME NOT NULL,
                AtualizadoEm DATETIME NOT NULL,
                CONSTRAINT Usuario PRIMARY KEY (UsuarioID)
)

CREATE TABLE Relatorio (
                RelatorioID INT NOT NULL,
                Nome VARCHAR(100) NOT NULL,
                Descricao VARCHAR(100) NOT NULL,
                Usiario VARCHAR(50) NOT NULL,
                Status BIT NOT NULL,
                CriadoEm DATETIME NOT NULL,
                AtualizadoEm DATETIME NOT NULL,
                CONSTRAINT Relatorio PRIMARY KEY (RelatorioID)
)

CREATE TABLE Registro (
                RelatorioID INT NOT NULL,
                UsuarioID INT NOT NULL,
                Nome VARCHAR(100) NOT NULL,
                Descricao VARCHAR(100) NOT NULL,
                Usuario VARCHAR(50) NOT NULL,
                Status BIT NOT NULL,
                CriadoEm DATETIME NOT NULL,
                AtualizadoEm DATETIME NOT NULL,
                CONSTRAINT Registro PRIMARY KEY (RelatorioID, UsuarioID)
)

CREATE TABLE Campo (
                CampoID INT NOT NULL,
                Nome VARCHAR(100) NOT NULL,
                Usuario VARCHAR(50) NOT NULL,
                Status BIT NOT NULL,
                CriadoEm DATETIME NOT NULL,
                AtualizadoEm DATETIME NOT NULL,
                TipoCampoID INT NOT NULL,
                CONSTRAINT Campo PRIMARY KEY (CampoID)
)

CREATE TABLE CampoRelatorio (
                RelatorioID INT NOT NULL,
                CampoID INT NOT NULL,
                Usuario VARCHAR(50) NOT NULL,
                Status BIT NOT NULL,
                CriadoEm DATETIME NOT NULL,
                AtualizadoEm DATETIME NOT NULL,
                CONSTRAINT CampoRelatorio PRIMARY KEY (RelatorioID, CampoID)
)

ALTER TABLE Campo ADD CONSTRAINT TipoCampo_Campo_fk
FOREIGN KEY (TipoCampoID)
REFERENCES TipoCampo (TipoCampoID)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE Registro ADD CONSTRAINT Usuario_Registro_fk
FOREIGN KEY (UsuarioID)
REFERENCES Usuario (UsuarioID)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE CampoRelatorio ADD CONSTRAINT Relatorio_CampoRelatorio_fk
FOREIGN KEY (RelatorioID)
REFERENCES Relatorio (RelatorioID)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE Registro ADD CONSTRAINT Relatorio_Registro_fk
FOREIGN KEY (RelatorioID)
REFERENCES Relatorio (RelatorioID)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE CampoRelatorio ADD CONSTRAINT Campo_CampoRelatorio_fk
FOREIGN KEY (CampoID)
REFERENCES Campo (CampoID)
ON DELETE NO ACTION
ON UPDATE NO ACTION


select * from grupo2.CarrinhoProduto


DELETE FROM GRUPO2.CARRINHOPRODUTO

ALTER TABLE GRUPO2.CARRINHOPRODUTO ADD CarrinhoProdutoID INT NOT NULL

CREATE TABLE GRUPO2.CARRINHOPRODUTO(
		Quantidade INT NOT NULL,
		PrecoTotal Decimal Not Nul


	CONSTRAINT [PK_CarrinhoProduto] PRIMARY KEY ([GRUPO2.CarrinhoID],[GRUPO2.ProdutoID]),
	CONSTRAINT [FK_01] FOREIGN KEY ([GRUPO2.CarrinhoID]) REFERENCES [Carrinho]([GRUPO2.CarrinhoID]),
	CONSTRAINT [FK_02] FOREIGN KEY ([GRUPO2.ProdutoID]) REFERENCES [GRUPO2.Produto]([GRUPO2.ProdutoID]),
	CONSTRAINT [FK_UsuarioID] FOREIGN KEY ([GRUPO2.UsuarioID]) REFERENCES [GRUPO2.Usuario]([UsuarioID])
)

DROP TABLE GRUPO2.CARRINHOPRODUTO
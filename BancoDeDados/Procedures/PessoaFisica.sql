--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE SP_PessoaFisica_Inserir
	@Nome VARCHAR(50),
	@CPF VARCHAR(14),
	@RG VARCHAR(12),
	@DataNascimento DATE,
	@Sexo INT
AS
BEGIN
--Execeção(TRY/CATCH)
--Transação
	BEGIN TRY
		BEGIN TRAN

			DECLARE @IDPessoa INT;

			--insert pessoa
			INSERT INTO Pessoa (TipoPessoa) VALUES (1);
			--retorno do id cadastrado com identity
			SET @IDPessoa = @@IDENTITY;

			--insert pessoaFisica
			INSERT INTO PessoaFisica 
			(
				IDPessoaFisica, 
				Nome, 
				CPF, 
				RG, 
				DataNascimento,
				IDSexo
			)
			VALUES 
			(
				@IDPessoa, 
				@Nome, 
				@CPF, 
				@RG, 
				@DataNascimento,
				@Sexo
			);

			SELECT @IDPessoa AS Retorno;

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno;
	END CATCH	
END
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
EXEC SP_PessoaFisica_Inserir 'testenome2', '42457532810', '782054123','22-10-1995', 2

--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE SP_PessoaFisica_Excluir
	@IDPessoa INT
AS
BEGIN
--Execeção(TRY/CATCH)
--Transação
	BEGIN TRY
		BEGIN TRAN
			DELETE FROM PessoaFisica
			WHERE
			IDPessoaFisica = @IDPessoa

			SELECT @IDPessoa as retorno

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno;
	END CATCH	
END
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------

EXEC SP_PessoaFisica_Excluir

--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------

CREATE	VIEW VW_PessoaFisica
AS
	SELECT 
		Pessoa.IDPessoa,
		PessoaTipo.Descricao,
		PessoaFisica.Nome,
		PessoaFisica.CPF,
		PessoaFisica.RG,
		PessoaFisica.DataNascimento,
		Sexo.Descricao AS Sexo
	FROM
		Pessoa
			INNER JOIN PessoaTipo ON Pessoa.TipoPessoa = PessoaTipo.IDPessoaTipo
			INNER JOIN PessoaFisica ON Pessoa.IDPessoa = PessoaFisica.IDPessoaFisica
			INNER JOIN Sexo ON PessoaFisica.IDSexo = Sexo.IDSexo
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE SP_PessoaFisica_ConsultarPorID
	@IDPessoa INT
AS
BEGIN
	SELECT
		*
	FROM
		VW_PessoaFisica
	WHERE
		IDPessoa = @IDPessoa
END
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
EXEC SP_PessoaFisica_ConsultarPorID 2

--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE SP_PessoaFisica_ConsultarPorNome
	@Nome	VARCHAR(50)
AS
BEGIN
	SELECT
		*
	FROM
		VW_PessoaFisica
	WHERE
		Nome LIKE '%'+@Nome+'%'
END
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
EXEC SP_PessoaFisica_ConsultarPorNome '2'
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE SP_PessoaFisica_ConsultarPorCPF
	@CPF VARCHAR(14)
AS
BEGIN
	SELECT
		*
	FROM
		VW_PessoaFisica
	WHERE
		Nome LIKE '%'+@CPF+'%'
END
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
EXEC SP_PessoaFisica_ConsultarPorCPF '42557335879'
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
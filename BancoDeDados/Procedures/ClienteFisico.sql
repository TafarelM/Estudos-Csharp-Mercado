--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE SP_ClienteFisico_Inserir
	@Nome VARCHAR(50),
	@CPF VARCHAR(14),--UNICO--
	@RG VARCHAR(12),
	@DataNascimento DATE,
	@Sexo INT,
	@Rua VARCHAR(10),
	@Numero VARCHAR(50),
	@Cidade VARCHAR(50),
	@Estado VARCHAR(20),
	@CEP VARCHAR(10),
	@Descricao VARCHAR(50)
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

			--insert pessoaFisica informações
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

			--insert endereço informações--
			INSERT INTO Endereco
			(
				IDPessoa,
				Rua,
				Numero,
				Cidade,
				Estado,
				CEP,
				Descricao
			)
			VALUES
			(
				@IDPessoa,
				@Rua,
				@Numero,
				@Cidade,
				@Estado,
				@CEP,
				@Descricao
			);

			--insert clienteFisico informaçoes--
			INSERT INTO Cliente (IDCliente) VALUES (@IDPessoa);

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
EXEC SP_ClienteFisico_Inserir 'Teste do teste', '45678915912', '8521479631', '10-10-2010', 1, 'ruateste', '589', 'cidadeteste', 'estado', '18160000', 'descricaoteste'

SELECT * FROM Cliente

--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE SP_ClienteFisico_Alterar
	@IDPessoa INT,
	@Nome VARCHAR(50),
	@CPF VARCHAR(14),--UNICO--
	@RG VARCHAR(12),
	@DataNascimento DATE,
	@Sexo INT,
	@Rua VARCHAR(10),
	@Numero VARCHAR(50),
	@Cidade VARCHAR(50),
	@Estado VARCHAR(20),
	@CEP VARCHAR(10),
	@Descricao VARCHAR(50)
AS
BEGIN
--Execeção(TRY/CATCH)
--Transação
	BEGIN TRY
		BEGIN TRAN

			--insert pessoaFisica informações
			UPDATE PessoaFisica 
			SET
				Nome = @Nome, 
				CPF = @CPF, 
				RG = @RG, 
				DataNascimento = @DataNascimento,
				IDSexo = @Sexo
			WHERE 
				IDPessoaFisica = @IDPessoa;

			--insert Endereço--
			UPDATE Endereco
			SET
				Rua = @Rua,
				Numero = @Numero,
				Cidade = @Cidade,
				Estado = @Estado,
				CEP = @CEP,
				Descricao = @CEP
			WHERE
				IDPessoa = @IDPessoa;

			--retorno
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
EXEC SP_ClienteFisico_Alterar 4, 'Teste cliente alterar', '572697185234', '4812693758', '22-10-2010', 2

SELECT * FROM VW_ClienteFisico

--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE SP_ClienteFisico_Excluir
	@IDPessoa INT
AS
BEGIN
--Execeção(TRY/CATCH)
--Transação
	BEGIN TRY
		BEGIN TRAN
			DELETE FROM Cliente
			WHERE
			IDCliente = @IDPessoa

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

ALTER VIEW VW_ClienteFisico
AS
	SELECT 
		Pessoa.IDPessoa,
		PessoaTipo.Descricao,
		PessoaFisica.Nome,
		PessoaFisica.CPF,
		PessoaFisica.RG,
		PessoaFisica.DataNascimento,
		Sexo.Descricao AS Sexo,
		Endereco.Rua,
		Endereco.Numero,
		Endereco.Cidade,
		Endereco.Estado,
		Endereco.CEP,
		Endereco.Descricao AS EnderecoDescricao,
		Cliente.IDCliente
	FROM
		Pessoa
			INNER JOIN PessoaTipo ON Pessoa.TipoPessoa = PessoaTipo.IDPessoaTipo
			INNER JOIN PessoaFisica ON Pessoa.IDPessoa = PessoaFisica.IDPessoaFisica
			INNER JOIN Sexo ON PessoaFisica.IDSexo = Sexo.IDSexo
			INNER JOIN Endereco ON Pessoa.IDPessoa = Endereco.IDPessoa
			INNER JOIN Cliente ON Pessoa.IDPessoa = Cliente.IDCliente;
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE SP_ClienteFisico_ConsultarPorID
	@IDPessoa INT
AS
BEGIN
	SELECT
		*
	FROM
		VW_ClienteFisico
	WHERE
		IDPessoa = @IDPessoa
END
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
EXEC SP_ClienteFisico_ConsultarPorID 5

--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE SP_ClienteFisico_ConsultarPorNome
	@Nome	VARCHAR(50)
AS
BEGIN
	SELECT
		*
	FROM
		VW_ClienteFisico
	WHERE
		Nome LIKE '%'+@Nome+'%'
END
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
EXEC SP_ClienteFisico_ConsultarPorNome ''
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE SP_ClienteFisico_ConsultarPorCPF
	@CPF VARCHAR(14)
AS
BEGIN
	SELECT
		*
	FROM
		VW_ClienteFisico
	WHERE
		Nome LIKE '%'+@CPF+'%'
END
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
EXEC SP_ClienteFisico_ConsultarPorCPF ''
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------
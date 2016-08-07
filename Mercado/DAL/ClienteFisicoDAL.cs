using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using DTO;
using System.Data;

namespace DAL
{
    class ClienteFisicoDAL
    {
            AcessoDados_SQLServer acessoDados = new AcessoDados_SQLServer();

            //INSERIR
            public String Inserir(ClienteFisico clienteFisico)
            {
                try
                {
                    acessoDados.LimparParametros();
                    acessoDados.AdicionarParametros("@Nome", clienteFisico.pessoaFisica.nome);
                    acessoDados.AdicionarParametros("@CPF", clienteFisico.pessoaFisica.cpf);
                    acessoDados.AdicionarParametros("@RG", clienteFisico.pessoaFisica.rg);
                    acessoDados.AdicionarParametros("@DataNascimento", clienteFisico.pessoaFisica.dataNascimento);
                    acessoDados.AdicionarParametros("@Sexo", clienteFisico.pessoaFisica.sexo);
                    acessoDados.AdicionarParametros("@Rua", clienteFisico.pessoaFisica.pessoa.endereco.rua);
                    acessoDados.AdicionarParametros("@Numero", clienteFisico.pessoaFisica.pessoa.endereco.numero);
                    acessoDados.AdicionarParametros("@Cidade", clienteFisico.pessoaFisica.pessoa.endereco.cidade);
                    acessoDados.AdicionarParametros("@Estado", clienteFisico.pessoaFisica.pessoa.endereco.estado);
                    acessoDados.AdicionarParametros("@CEP", clienteFisico.pessoaFisica.pessoa.endereco.cep);
                    acessoDados.AdicionarParametros("@Descricao", clienteFisico.pessoaFisica.pessoa.endereco.descricao);


                String idClienteFisico = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "SP_ClienteFisico_Inserir").ToString();

                    return idClienteFisico;
                }
                catch (Exception exception)
                {
                    return exception.Message;
                }
            }

            //ALTERAR
            public string Alterar(ClienteFisico clienteFisico)
            {
                try
                {
                    //limpar antes de usar
                    acessoDados.LimparParametros();
                    //adicionar parametros
                    acessoDados.AdicionarParametros("@IDPessoa", clienteFisico.pessoaFisica.pessoa.IDPessoa);
                    acessoDados.AdicionarParametros("@Nome", clienteFisico.pessoaFisica.nome);
                    //executa e manipula
                    string idClienteFisico = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "SP_ClienteFisico_Alterar").ToString();
                    return idClienteFisico;
                }
                catch (Exception exception)
                {
                    return exception.Message;
                }
            }

            //
            public string Excluir(Categoria categoria)
            {
                try
                {
                    //limpar antes de usar
                    acessoDados.LimparParametros();
                    //adicionar parametros
                    acessoDados.AdicionarParametros("idCategoria", categoria.idCategoria);
                    //chamar a procedure para manipulação
                    string idCategoria = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "SP_Categoria_Excluir").ToString();

                    return idCategoria;
                }
                catch (Exception exception)
                {
                    return exception.Message;
                }
            }

            //
            public CategoriaColecao ConsultarNome(string nome)
            {
                try
                {
                    //Cria uma coleção nova de Categoria(aqui ela está vazia)
                    CategoriaColecao categoriaColecao = new CategoriaColecao();
                    //limpar antes de usar
                    acessoDados.LimparParametros();
                    //adicionar parametros
                    acessoDados.AdicionarParametros("@Nome", nome);
                    //manipulando dados e coloca dentro de um DataTable
                    DataTable dataTableCategoria = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "SP_Categoria_ConsultarPorNome");

                    //percorrer o DataTable e transformar em uma coleção de Categorias
                    //cada linha do DataTable é uma Categoria
                    //o foreach vai percorrer cada linha(DataRow) pegando os dados que estiverem lá
                    foreach (DataRow linha in dataTableCategoria.Rows)
                    {
                        //criar um Categoria vazio e colocar os dados da linha nele e depois adiciona ele na colecao
                        Categoria categoria = new Categoria();
                        //
                        categoria.idCategoria = Convert.ToInt32(linha["IDCategoria"]);
                        categoria.nome = Convert.ToString(linha["Nome"]);

                        //adiciona os dados de Categoria na CategoriaColecao
                        categoriaColecao.Add(categoria);
                    }

                    //retorna a coleção de categoria que foi encotrada no banco
                    return categoriaColecao;
                }
                catch (Exception exception)
                {
                    //exibindo message caso de um erro na consuta(cria nova exeção)
                    throw new Exception("Não foi possivel consultar o Categoria por nome. \nDetalhes: " + exception.Message);
                }

            }

            //
            public CategoriaColecao ConsultaId(int idCategoria)
            {
                try
                {
                    //Cria uma coleção nova de Categoria(aqui ela está vazia)
                    CategoriaColecao categoriaColecao = new CategoriaColecao();
                    //limpar antes de usar
                    acessoDados.LimparParametros();
                    //adicionar parametros
                    acessoDados.AdicionarParametros("@IDCategoria", idCategoria);
                    //executar a consulta no banco e guarda o conteudo em um DataTable
                    DataTable dataTableCategoria = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "SP_Categoria_ConsultarPorId");
                    //
                    foreach (DataRow linha in dataTableCategoria.Rows)
                    {
                        //
                        Categoria categoria = new Categoria();

                        categoria.idCategoria = Convert.ToInt32(linha["IDCategoria"]);
                        categoria.nome = Convert.ToString(linha["Nome"]);

                        //adiciona a coleção
                        categoriaColecao.Add(categoria);
                    }

                    return categoriaColecao;
                }
                catch (Exception exception)
                {
                    //exibindo message caso de um erro na consuta(cria nova exeção)
                    throw new Exception("Não foi possivel consultar o Categoria por Código. \nDetalhes: " + exception.Message);
                }
            }

//end
        }
    }

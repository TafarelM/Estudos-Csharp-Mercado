using DTO;
using System;
//add
using System.Data;

namespace DAL
{
    public class CategoriaDAL
    {
        AcessoDados_SQLServer acessoDados = new AcessoDados_SQLServer();

        //INSERIR
        public String Inserir(Categoria categoria)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Nome", categoria.nome);

                String idCategoria = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "SP_Categoria_Inserir").ToString();

                return idCategoria;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        //ALTERAR
        public string Alterar(Categoria categoria)
        {
            try
            {
                //limpar antes de usar
                acessoDados.LimparParametros();
                //adicionar parametros
                acessoDados.AdicionarParametros("idCategoria", categoria.idCategoria);
                acessoDados.AdicionarParametros("@nome", categoria.nome);
                //executa e manipula
                string idCategoria = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "SP_Categoria_Alterar").ToString();
                return idCategoria;
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

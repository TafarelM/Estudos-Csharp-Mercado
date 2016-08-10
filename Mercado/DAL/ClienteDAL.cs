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
    public class ClienteDAL
    {
        AcessoDados_SQLServer acessoDados = new AcessoDados_SQLServer();

        public String inserir(Cliente cliente)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Nome", cliente.nome);
                acessoDados.AdicionarParametros("@CPF_CNPJ", cliente.cpf_cnpj);
                acessoDados.AdicionarParametros("@RG_IE", cliente.rg_ie);
                acessoDados.AdicionarParametros("@RazaoSocial", cliente.razaoSocial);
                acessoDados.AdicionarParametros("@DataNascimento_Abertura", cliente.dataNascimento_Abertura);
                acessoDados.AdicionarParametros("@sexo", cliente.sexo);
                acessoDados.AdicionarParametros("@tipoCliente", cliente.tipoCliente);
                acessoDados.AdicionarParametros("@CEP", cliente.cep);
                acessoDados.AdicionarParametros("@Rua", cliente.rua);
                acessoDados.AdicionarParametros("@Numero", cliente.numero);
                acessoDados.AdicionarParametros("@Bairro", cliente.bairro);
                acessoDados.AdicionarParametros("@Cidade", cliente.cidade);
                acessoDados.AdicionarParametros("@Estado", cliente.estado);
                acessoDados.AdicionarParametros("@Telefone", cliente.telefone);
                acessoDados.AdicionarParametros("@Celular", cliente.celular);
                acessoDados.AdicionarParametros("@Email", cliente.email);


                String idCliente = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "SP_Cliente_Inserir").ToString();

                return idCliente;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string alterar(Cliente cliente)
        {
            try
            {
                //limpar antes de usar
                acessoDados.LimparParametros();
                //adicionar parametros
                acessoDados.AdicionarParametros("@IDCliente", cliente.idCliente);
                acessoDados.AdicionarParametros("@Nome", cliente.nome);
                acessoDados.AdicionarParametros("@CPF_CNPJ", cliente.cpf_cnpj);
                acessoDados.AdicionarParametros("@RG_IE", cliente.rg_ie);
                acessoDados.AdicionarParametros("@RazaoSocial", cliente.razaoSocial);
                acessoDados.AdicionarParametros("@dataNascimento_Abertura", cliente.dataNascimento_Abertura);
                acessoDados.AdicionarParametros("@Sexo", cliente.sexo);
                acessoDados.AdicionarParametros("@TipoCliente", cliente.tipoCliente);
                acessoDados.AdicionarParametros("@CEP", cliente.cep);
                acessoDados.AdicionarParametros("@Rua", cliente.rua);
                acessoDados.AdicionarParametros("@Numero", cliente.numero);
                acessoDados.AdicionarParametros("@Bairro", cliente.bairro);
                acessoDados.AdicionarParametros("@Cidade", cliente.cidade);
                acessoDados.AdicionarParametros("@Estado", cliente.estado);
                acessoDados.AdicionarParametros("@Telefone", cliente.telefone);
                acessoDados.AdicionarParametros("@Celular", cliente.celular);
                acessoDados.AdicionarParametros("@Email", cliente.email);

                //executa e manipulação
                string idCliente = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "SP_Cliente_Alterar").ToString();
                return idCliente;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }


        public string excluir(int cliente)
        {
            try
            {
                //limpar antes de usar
                acessoDados.LimparParametros();
                //adicionar parametros
                acessoDados.AdicionarParametros("@idCliente", cliente);
                //chamar a procedure para manipulação
                string idCliente = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "SP_Cliente_Excluir").ToString();

                return idCliente;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }


        public ClienteColecao consultarNome(string nome)
        {
            try
            {
                ClienteColecao clienteColecao = new ClienteColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@nome", nome);

                DataTable dataTableCliente = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "SP_Cliente_ConsultarPorNome");

                foreach (DataRow linha in dataTableCliente.Rows)
                {
                    Cliente cliente = new Cliente();

                    cliente.idCliente = Convert.ToInt32(linha["IDCliente"]);
                    cliente.nome = Convert.ToString(linha["Nome"]);
                    cliente.cpf_cnpj = Convert.ToString(linha["CPF_CNPJ"]);
                    cliente.rg_ie = Convert.ToString(linha["RG_IE"]);
                    cliente.razaoSocial = Convert.ToString(linha["RazaoSocial"]);
                    cliente.dataNascimento_Abertura = Convert.ToDateTime(linha["DataNascimento_Abertura"]);
                    cliente.sexo = Convert.ToString(linha["Sexo"]);
                    cliente.tipoCliente = Convert.ToString(linha["TipoCliente"]);
                    cliente.cep = Convert.ToString(linha["CEP"]);
                    cliente.rua = Convert.ToString(linha["Rua"]);
                    cliente.numero = Convert.ToString(linha["Numero"]);
                    cliente.bairro = Convert.ToString(linha["Bairro"]);
                    cliente.cidade = Convert.ToString(linha["Cidade"]);
                    cliente.estado = Convert.ToString(linha["Estado"]);
                    cliente.telefone = Convert.ToString(linha["Telefone"]);
                    cliente.celular = Convert.ToString(linha["Celular"]);
                    cliente.email = Convert.ToString(linha["Email"]);

                    clienteColecao.Add(cliente);
                }

                return clienteColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel consultar o Cliente por nome. \nDetalhes: " + exception.Message);
            }

        }


        public ClienteColecao consultaId(int idCliente)
        {
            try
            {
                ClienteColecao clienteColecao = new ClienteColecao();
                acessoDados.LimparParametros();

                acessoDados.AdicionarParametros("@IDCliente", idCliente);
                DataTable dataTableCliente = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "SP_Cliente_ConsultarPorID");

                foreach (DataRow linha in dataTableCliente.Rows)
                {
                    Cliente cliente = new Cliente();

                    cliente.idCliente = Convert.ToInt32(linha["IDCliente"]);
                    cliente.nome = Convert.ToString(linha["Nome"]);
                    cliente.cpf_cnpj = Convert.ToString(linha["CPF_CNPJ"]);
                    cliente.rg_ie = Convert.ToString(linha["RG_IE"]);
                    cliente.razaoSocial = Convert.ToString(linha["RazaoSocial"]);
                    cliente.dataNascimento_Abertura = Convert.ToDateTime(linha["DataNascimento_Abertura"]);
                    cliente.sexo = Convert.ToString(linha["Sexo"]);
                    cliente.tipoCliente = Convert.ToString(linha["TipoCliente"]);
                    cliente.cep = Convert.ToString(linha["CEP"]);
                    cliente.rua = Convert.ToString(linha["Rua"]);
                    cliente.numero = Convert.ToString(linha["Numero"]);
                    cliente.bairro = Convert.ToString(linha["Bairro"]);
                    cliente.cidade = Convert.ToString(linha["Cidade"]);
                    cliente.estado = Convert.ToString(linha["Estado"]);
                    cliente.telefone = Convert.ToString(linha["Telefone"]);
                    cliente.celular = Convert.ToString(linha["Celular"]);
                    cliente.email = Convert.ToString(linha["Email"]);

                    clienteColecao.Add(cliente);
                }

                return clienteColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel consultar o Cliente por Código. \nDetalhes: " + exception.Message);
            }
        }
//end       
    }
}

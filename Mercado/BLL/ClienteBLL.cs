using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using DTO;
using DAL;

namespace BLL
{
    public class ClienteBLL
    {
        public string inserir(Cliente cliente)
        {
            ClienteDAL dal = new ClienteDAL();
            string idCliente = dal.inserir(cliente);

            return idCliente;
        }

        public string alterar(Cliente cliente)
        {
            ClienteDAL dal = new ClienteDAL();
            string idCliente = dal.alterar(cliente);

            return idCliente;
        }

        public string excluir(int id)
        {
            ClienteDAL dal = new ClienteDAL();
            string idCliente = dal.excluir(id);

            return idCliente;
        }

        public ClienteColecao consultarNome(string nome)
        {
            ClienteDAL dal = new ClienteDAL();
            ClienteColecao clienteColecao = new ClienteColecao();
            clienteColecao = dal.consultarNome(nome);

            return clienteColecao;
        }

        public ClienteColecao consultarId(int id)
        {
            ClienteDAL dal = new ClienteDAL();
            ClienteColecao clienteColecao = new ClienteColecao();
            clienteColecao = dal.consultaId(id);

            return clienteColecao;
        }
    }
}

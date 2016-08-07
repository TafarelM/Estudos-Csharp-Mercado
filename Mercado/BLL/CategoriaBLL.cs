using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ADD
using DTO;
using DAL;


namespace BLL
{
    public class CategoriaBLL
    {
        //INSERIR
        public string Inserir(Categoria categoria)
        {
            CategoriaDAL dal = new CategoriaDAL();
            string idCategoria = dal.Inserir(categoria);

            return idCategoria;
        }

        //
        public string Alterar(Categoria categoria)
        {
            CategoriaDAL dal = new CategoriaDAL();
            string idCategoria = dal.Alterar(categoria);

            return idCategoria;
        }

        //
        public string Excluir(Categoria categoria)
        {
            CategoriaDAL dal = new CategoriaDAL();
            string idCategoria = dal.Excluir(categoria);

            return idCategoria;
        }

        //
        public CategoriaColecao ConsultarNome(string nome)
        {
            CategoriaColecao categoriaColecao = new CategoriaColecao();
            CategoriaDAL dal = new CategoriaDAL();
            categoriaColecao = dal.ConsultarNome(nome);

            return categoriaColecao;
        }

        //
        public CategoriaColecao ConsultarID(int id)
        {
            CategoriaColecao categoriaColecao = new CategoriaColecao();
            CategoriaDAL dal = new CategoriaDAL();
            categoriaColecao = dal.ConsultaId(id);

            return categoriaColecao;
        }

    }
}

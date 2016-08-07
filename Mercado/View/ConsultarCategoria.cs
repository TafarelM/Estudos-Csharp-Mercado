using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//add
using DTO;
using BLL;

namespace View
{
    public partial class ConsultarCategoria : Form
    {
        public ConsultarCategoria()
        {
            InitializeComponent();
            //para não gerar colunas automaticas no dataGrid
            dataGridPrincipal.AutoGenerateColumns = false;
        }

        //METODO PARA ATUALIZAR O GRID
        private void AtualizarGrid()
        {
            //O METODO É O BOTÃO PESQUISAR
            //  PESQUISAR
            CategoriaBLL categoriaBLL = new CategoriaBLL();
            CategoriaColecao categoriaColecao = new CategoriaColecao();


            //PASSA COMO PARAMETRO OQUE FOR DIGITADO NO CAMPO TXTPESQUISAR PARA O METODO CONSULTARNOME E OQUE FOR ENCONTRADO ELE VAI JOGAR NA COLEÇÃO DE CLIENTES
            categoriaColecao = categoriaBLL.ConsultarNome(txtPesquisar.Text);

            //CONFIGURANDO O DATAGRID
            //limpando o dataGrid se caso ouver dados
            dataGridPrincipal.DataSource = null;
            //usando a coleção de Categoria como fonte de dados para o dataGrid
            dataGridPrincipal.DataSource = categoriaColecao;

            dataGridPrincipal.Update();
            dataGridPrincipal.Refresh();
        }

        //PESQUISAR
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        //INSERIR
        private void btnNovo_Click(object sender, EventArgs e)
        {            
            ManterCategoria manterCategoria = new ManterCategoria(AcaoNaTela.Inserir, null);
            //pegando o dialogResult
            DialogResult dialogResult = manterCategoria.ShowDialog();
            //
            if (dialogResult.Equals(DialogResult.Yes))
            {
                AtualizarGrid();
            }
        }

        //BOTÃO ALTERAR
        private void btnAlterar_Click(object sender, EventArgs e)
        {          
            //verificar se tem algum registro selecionado no grid
            if (dataGridPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleciona um registro");
                return;
            }

            //pegar o item selecionado do grid
            Categoria categoriaSelecionado = (dataGridPrincipal.SelectedRows[0].DataBoundItem as Categoria);

            ManterCategoria manterCategoria = new ManterCategoria(AcaoNaTela.Alterar, categoriaSelecionado);

            DialogResult dialogResult = manterCategoria.ShowDialog();
            if (dialogResult.Equals(DialogResult.Yes))
            {
                AtualizarGrid();
            }
        }

        //CONSULTAR
        private void btnConsultar_Click(object sender, EventArgs e)
        {         
            //verificar se tem algum registro selecionado no grid
            if (dataGridPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleciona um registro");
                return;
            }

            //pegar o cliente selecionado no grid
            Categoria categoriaSelecionado = (dataGridPrincipal.SelectedRows[0].DataBoundItem as Categoria);

            ManterCategoria manterCategoria = new ManterCategoria(AcaoNaTela.Consultar, categoriaSelecionado);
            manterCategoria.ShowDialog();
        }

        //FECHAR
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //EXCLUIR
        private void btnExcluir_Click(object sender, EventArgs e)
        {            
            //verificar se tem algum registro selecionado
            if (dataGridPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleciona um registro");
                return;
            }
            //perguntar se ele tem certeza que excluir o registro
            DialogResult resultado = MessageBox.Show("Tem Certeza que deseja excluir esse registro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }

            //pegar o Categoria selecionada
            Categoria categoriaSelecionado = (dataGridPrincipal.SelectedRows[0].DataBoundItem as Categoria);

            //Instanciar  a regra de negocioas
            CategoriaBLL categoriaBLL = new CategoriaBLL();
            //chamar o metodo excluir e guarda na variavel retorno
            string retorno = categoriaBLL.Excluir(categoriaSelecionado);

            //verificar se a exlcusão funciono
            //se o retorno for numero é porque deu certo, senão deu erro
            try
            {
                //excluido com sucesso
                int idCategoria = Convert.ToInt32(retorno);
                MessageBox.Show("Excluído com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
            }
            catch
            {
                //se der erro
                MessageBox.Show("Não foi possivel excluir. Detalhes: " + retorno, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

//end
    }
    
}

using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmConsultarCliente : FrmConsultar
    {
        public FrmConsultarCliente()
        {
            InitializeComponent();
            dataGridViewPrincipal.AutoGenerateColumns = false;
        }

        private void FrmConsultarCliente_Load(object sender, EventArgs e)
        {
        }

        private void atualizarGrid()
        {
            ClienteBLL cliente = new ClienteBLL();
            ClienteColecao clienteColecao = new ClienteColecao();

            clienteColecao = cliente.consultarNome(txtPesquisar.Text);

            //CONFIGURANDO O DATAGRID
            //limpando o dataGrid se caso ouver dados
            dataGridViewPrincipal.DataSource = null;
            //usando a coleção de cliente como fonte de dados para o dataGrid
            dataGridViewPrincipal.DataSource = clienteColecao;

            dataGridViewPrincipal.Update();
            dataGridViewPrincipal.Refresh();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //INSERIR
            FrmManterCliente manterCliente = new FrmManterCliente(AcaoNaTela.Inserir, null);
            //pegando o dialogResult
            DialogResult dialogResult = manterCliente.ShowDialog();
            //
            if (dialogResult.Equals(DialogResult.Yes))
            {
                atualizarGrid();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //BOTÃO ALTERAR

            //verificar se tem algum registro selecionado no grid
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleciona um registro");
                return;
            }

            //pegar o cliente selecionado no grid
            Cliente clienteSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Cliente);

            FrmManterCliente manterCliente = new FrmManterCliente(AcaoNaTela.Alterar, clienteSelecionado);

            DialogResult dialogResult = manterCliente.ShowDialog();
            if (dialogResult.Equals(DialogResult.Yes))
            {
                atualizarGrid();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //CONSULTAR

            //verificar se tem algum registro selecionado no grid
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleciona um registro");
                return;
            }

            //pegar o cliente selecionado no grid
            Cliente clienteSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Cliente);

            FrmManterCliente manterCliente = new FrmManterCliente(AcaoNaTela.Consultar, clienteSelecionado);
            manterCliente.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //EXCLUIR
            //verificar se tem algum registro selecionado
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
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

            //pegar o cliente selecionado
            Cliente clienteSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Cliente);

            //Instanciar  a regra de negocioas
            ClienteBLL clienteBLL = new ClienteBLL();
            //chamar o metodo excluir e guarda na variavel retorno
            string retorno = clienteBLL.excluir(clienteSelecionado.idCliente);

            //verificar se a exlcusão funciono
            //se o retorno for numero é porque deu certo, senão deu erro
            try
            {
                //excluido com sucesso
                int idCliente = Convert.ToInt32(retorno);
                MessageBox.Show("Excluído com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizarGrid();
            }
            catch
            {
                //se der erro
                MessageBox.Show("Não foi possivel excluir. Detalhes: " + retorno, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            atualizarGrid();
        }
    }
}

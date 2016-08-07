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
    public partial class ManterCategoria : Form
    {
        //parar poder usar o metodo do manter
        AcaoNaTela acaoNaTelaSelecionada;

        public ManterCategoria(AcaoNaTela acaoNaTela, Categoria categoria)
        {
            InitializeComponent();

            //guardando os dados para poder usar fora do frmClienteCadastrar
            this.acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                //INSERIR
                this.Text = "Inserir";

            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                //ALTERAR
                this.Text = "Alterar";

                //grava o conteudo no campo da tela
                txtId.Text = categoria.idCategoria.ToString();
                txtNome.Text = categoria.nome;
            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                //CONSULTAR
                this.Text = "Consultar";

                //grava o conteudo nos campos da tela
                txtId.Text = categoria.idCategoria.ToString();
                txtNome.Text = categoria.nome;

                //desabilitando os campos da tela
                txtId.Enabled = false;
                txtNome.Enabled = false;

                //mudando a text do botão e desabilitando ele
                btnSalvar.Visible = false;
                //btnFechar.Text = "Fechar";
                btnFechar.Focus();
            }
    }

        //INSERIR
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //verifica se é inserção ou alteração
            if (acaoNaTelaSelecionada.Equals(AcaoNaTela.Inserir))
            {
                //INSERIR
                Categoria categoria = new Categoria();

                categoria.nome = txtNome.Text;


                //envia para o metodo tudo q foi colocado na classe
                CategoriaBLL categoriaBLL = new CategoriaBLL();
                string retorno = categoriaBLL.Inserir(categoria);

                //Tenta converter para inteiro se der tudo certo é porque devolveu o id, se der errado tem a msg de erro
                try
                {
                    //salvo com sucessso
                    int idCategoria = Convert.ToInt32(retorno);
                    MessageBox.Show("Inserido com Sucesso!.  Código: " + idCategoria.ToString());

                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    //se der erro
                    MessageBox.Show("Não foi possivel Inserir. Detalhes: " + retorno, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.DialogResult = DialogResult.No;
                }

            }
            else if (acaoNaTelaSelecionada.Equals(AcaoNaTela.Alterar))
            {
                //ALTERAR
                Categoria categoria = new Categoria();

                categoria.idCategoria = Convert.ToInt32(txtId.Text);
                categoria.nome = txtNome.Text;

                //envia para o metodo tudo q foi colocado na classe cliente
                CategoriaBLL categoriaBLL = new CategoriaBLL();
                string retorno = categoriaBLL.Alterar(categoria);

                //Tenta converter para inteiro se der tudo certo é porque devolveu o id, se der errado tem a msg de erro
                try
                {
                    //salvo com sucessso
                    int idCategoria = Convert.ToInt32(retorno);
                    MessageBox.Show("Registro Alterado com Sucesso!. ");

                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    //se der erro
                    MessageBox.Show("Não foi possivel Alterar o registro. Detalhes: " + retorno, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.DialogResult = DialogResult.No;
                }

            }
        }

        //sair
        private void btnFechar_Click(object sender, EventArgs e)
        {            
            DialogResult = DialogResult.No;
        }
    }
}

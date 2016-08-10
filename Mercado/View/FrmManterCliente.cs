using DTO;
using BLL;
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
    public partial class FrmManterCliente : FrmManter
    {
        //parar poder usar o metodo do clienteCadastrar
        AcaoNaTela acaoNaTelaSelecionada;

        public FrmManterCliente(AcaoNaTela acaoNaTela, Cliente cliente)
        {
            InitializeComponent();

            //guardando os dados para poder usar fora do frmClienteCadastrar
            this.acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                //INSERIR
                this.Text = "Inserir Cliente";

            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                //ALTERAR
                this.Text = "Alterar Cliente";
                //grava o conteudo no campo da tela
                txtId.Text = cliente.idCliente.ToString();
                txtNome.Text = cliente.nome;
                mtxtCPF_CNPJ.Text = cliente.cpf_cnpj;
                mtxtRG_IE.Text = cliente.rg_ie;
                txtRazaoSocial.Text = cliente.razaoSocial;
                mtxtDataNascimento_Abertura.Text = Convert.ToString(cliente.dataNascimento_Abertura);
                if (cliente.sexo == "Masculino")
                {
                    rbtnMasculino.Checked = true;
                }
                else
                {
                    rbtnFeminino.Checked = true;
                }
                //
                if (cliente.tipoCliente == "Fisico")
                {
                    rbtnClienteFisico.Checked = true;
                }
                else
                {
                    rbtnClienteJuridico.Checked = true;
                };
                mtxtCEP.Text = cliente.cep;
                txtRua.Text = cliente.rua;
                txtNumero.Text = cliente.numero;
                txtBairro.Text = cliente.bairro;
                txtCidade.Text = cliente.cidade;
                txtEstado.Text = cliente.estado;
                mtxtTelefone.Text = cliente.telefone;
                mtxtCelular.Text = cliente.celular;
                txtEmail.Text = cliente.email;


            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                //CONSULTAR
                this.Text = "Consultar Cliente";

                //grava o conteudo nos campos da tela
                txtId.Text = cliente.idCliente.ToString();
                txtNome.Text = cliente.nome;
                mtxtCPF_CNPJ.Text = cliente.cpf_cnpj;
                mtxtRG_IE.Text = cliente.rg_ie;
                txtRazaoSocial.Text = cliente.razaoSocial;
                mtxtDataNascimento_Abertura.Text = Convert.ToString(cliente.dataNascimento_Abertura);
                if (cliente.sexo == "Masculino")
                {
                    rbtnMasculino.Checked = true;
                }
                else
                {
                    rbtnFeminino.Checked = true;
                };
                //
                if (cliente.tipoCliente == "Fisico")
                {
                    rbtnClienteFisico.Checked = true;
                }else
                {
                    rbtnClienteJuridico.Checked = true;
                };
                mtxtCEP.Text = cliente.cep;
                txtRua.Text = cliente.rua;
                txtNumero.Text = cliente.numero;
                txtBairro.Text = cliente.bairro;
                txtCidade.Text = cliente.cidade;
                txtEstado.Text = cliente.estado;
                mtxtTelefone.Text = cliente.telefone;
                mtxtCelular.Text = cliente.celular;
                txtEmail.Text = cliente.email;

                //desabilitando os campos da tela
                txtId.ReadOnly = true;
                txtNome.ReadOnly = true;
                mtxtCPF_CNPJ.ReadOnly = true;
                mtxtRG_IE.ReadOnly = true;
                txtRazaoSocial.ReadOnly = true;
                mtxtDataNascimento_Abertura.ReadOnly = true;
                //sexo
                rbtnMasculino.Enabled = false;
                rbtnFeminino.Enabled = false;
                //pessoa
                rbtnClienteFisico.Enabled = false;
                rbtnClienteJuridico.Enabled = false;
                mtxtCEP.ReadOnly = true;
                txtRua.ReadOnly = true;
                txtNumero.ReadOnly = true;
                txtBairro.ReadOnly = true;
                txtCidade.ReadOnly = true;
                txtEstado.ReadOnly = true;
                mtxtTelefone.ReadOnly = true;
                mtxtCelular.ReadOnly = true;
                txtEmail.ReadOnly = true;

                //mudando a text do botão e desabilitando ele
                btnSalvar.Visible = false;
                btnFechar.Focus();
            }
        }

        public void btnFunction(AcaoNaTela acaoNatela)
        {
            if (acaoNaTelaSelecionada.Equals(AcaoNaTela.Inserir))
            {
                //INSERIR
                Cliente cliente = new Cliente();

                cliente.nome = txtNome.Text;
                cliente.cpf_cnpj = mtxtCPF_CNPJ.Text;
                cliente.rg_ie = mtxtRG_IE.Text;
                cliente.razaoSocial = txtRazaoSocial.Text;
                cliente.dataNascimento_Abertura = Convert.ToDateTime(mtxtDataNascimento_Abertura.Text);
                if (rbtnMasculino.Checked == true)
                {
                    cliente.sexo = "Masculino";//masculino
                }
                else
                {
                    cliente.sexo = "Feminino";//feminino
                };
                //
                if (rbtnClienteFisico.Checked == true)
                {
                    cliente.tipoCliente = "Fisico";//fisico
                }
                else
                {
                    cliente.tipoCliente = "Juridico";//juridico
                };
                cliente.cep = mtxtCEP.Text;
                cliente.rua = txtRua.Text;
                cliente.numero = txtNumero.Text;
                cliente.bairro = txtBairro.Text;
                cliente.cidade = txtCidade.Text;
                cliente.estado = txtEstado.Text;
                cliente.telefone = mtxtTelefone.Text;
                cliente.celular = mtxtCelular.Text;
                cliente.email = txtEmail.Text;

                //envia para o metodo tudo q foi colocado na classe cliente
                ClienteBLL clienteBLL = new ClienteBLL();
                string retorno = clienteBLL.inserir(cliente);

                //Tenta converter para inteiro se der tudo certo é porque devolveu o códiggo do cliente se der errado tem a msg de erro
                try
                {
                    //salvo com sucessso
                    int idCliente = Convert.ToInt32(retorno);
                    MessageBox.Show("Inserido com Sucesso!.  Código: " + idCliente.ToString());
                    //
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
                Cliente cliente = new Cliente();

                cliente.idCliente = Convert.ToInt32(txtId.Text);
                cliente.nome = txtNome.Text;
                cliente.cpf_cnpj = mtxtCPF_CNPJ.Text;
                cliente.rg_ie = mtxtRG_IE.Text;
                cliente.razaoSocial = txtRazaoSocial.Text;
                cliente.dataNascimento_Abertura = Convert.ToDateTime(mtxtDataNascimento_Abertura.Text);
                if (rbtnMasculino.Checked == true)
                {
                    cliente.sexo = "Masculino";//masculino
                }
                else
                {
                    cliente.sexo = "Feminino";//feminino
                };
                //tipo pessoa
                if (rbtnClienteFisico.Checked == true)
                {
                    cliente.tipoCliente = "Fisico";//fisico
                }
                else
                {
                    cliente.tipoCliente = "Juridico";//juridico
                };
                cliente.cep = mtxtCEP.Text;
                cliente.rua = txtRua.Text;
                cliente.numero = txtNumero.Text;
                cliente.bairro = txtBairro.Text;
                cliente.cidade = txtCidade.Text;
                cliente.estado = txtEstado.Text;
                cliente.telefone = mtxtTelefone.Text;
                cliente.celular = mtxtCelular.Text;
                cliente.email = txtEmail.Text;

                //envia para o metodo tudo q foi colocado na classe cliente
                ClienteBLL clienteBLL = new ClienteBLL();
                string retorno = clienteBLL.alterar(cliente);

                //Tenta converter para inteiro se der tudo certo é porque devolveu o códiggo do cliente se der errado tem a msg de erro
                try
                {
                    //salvo com sucessso
                    int idCliente = Convert.ToInt32(retorno);
                    MessageBox.Show("Registro Alterado com Sucesso!. ");
                    //
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

        private void FrmManterCliente_Load(object sender, EventArgs e)
        {
            lblRazaoSocial.Visible = false;
            txtRazaoSocial.Visible = false;

            txtNome.Focus();
        }

        private void rbtnClienteFisico_CheckedChanged(object sender, EventArgs e)
        {
            //muda os itens do form dependendo se pessoa fisica ou juridica
            if (rbtnClienteFisico.Checked == true)
            {
                lblRazaoSocial.Visible = false;
                txtRazaoSocial.Visible = false;
                lblRG_IE.Text = "CPF";
                lblCPF_CNPJ.Text = "RG";
                lblDataNascimento_Abertura.Text = "Data de Nascimento";
                gbSexo.Visible = true;
            }
            else
            {
                lblRazaoSocial.Visible = true;
                txtRazaoSocial.Visible = true;
                lblRG_IE.Text = "Inscrição Estadual";
                lblCPF_CNPJ.Text = "CNPJ";
                lblDataNascimento_Abertura.Text = "Data de Abertura";
                gbSexo.Visible = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (acaoNaTelaSelecionada.Equals(AcaoNaTela.Inserir))
            {
                //INSERIR
                Cliente cliente = new Cliente();

                cliente.nome = txtNome.Text;
                cliente.cpf_cnpj = mtxtCPF_CNPJ.Text;
                cliente.rg_ie = mtxtRG_IE.Text;
                cliente.razaoSocial = txtRazaoSocial.Text;
                cliente.dataNascimento_Abertura = Convert.ToDateTime(mtxtDataNascimento_Abertura.Text);
                if (rbtnMasculino.Checked == true)
                {
                    cliente.sexo = "Masculino";//masculino
                }
                else
                {
                    cliente.sexo = "Feminino";//feminino
                };
                //
                if (rbtnClienteFisico.Checked == true)
                {
                    cliente.tipoCliente = "Fisico";//fisico
                }
                else
                {
                    cliente.tipoCliente = "Juridico";//juridico
                };
                cliente.cep = mtxtCEP.Text;
                cliente.rua = txtRua.Text;
                cliente.numero = txtNumero.Text;
                cliente.bairro = txtBairro.Text;
                cliente.cidade = txtCidade.Text;
                cliente.estado = txtEstado.Text;
                cliente.telefone = mtxtTelefone.Text;
                cliente.celular = mtxtCelular.Text;
                cliente.email = txtEmail.Text;

                //envia para o metodo tudo q foi colocado na classe cliente
                ClienteBLL clienteBLL = new ClienteBLL();
                string retorno = clienteBLL.inserir(cliente);

                //Tenta converter para inteiro se der tudo certo é porque devolveu o códiggo do cliente se der errado tem a msg de erro
                try
                {
                    //salvo com sucessso
                    int idCliente = Convert.ToInt32(retorno);
                    MessageBox.Show("Inserido com Sucesso!.  Código: " + idCliente.ToString());
                    //
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
                Cliente cliente = new Cliente();

                cliente.idCliente = Convert.ToInt32(txtId.Text);
                cliente.nome = txtNome.Text;
                cliente.cpf_cnpj = mtxtCPF_CNPJ.Text;
                cliente.rg_ie = mtxtRG_IE.Text;
                cliente.razaoSocial = txtRazaoSocial.Text;
                cliente.dataNascimento_Abertura = Convert.ToDateTime(mtxtDataNascimento_Abertura.Text);
                if (rbtnMasculino.Checked == true)
                {
                    cliente.sexo = "Masculino";//masculino
                }
                else
                {
                    cliente.sexo = "Feminino";//feminino
                };
                //tipo pessoa
                if (rbtnClienteFisico.Checked == true)
                {
                    cliente.tipoCliente = "Fisico";//fisico
                }
                else
                {
                    cliente.tipoCliente = "Juridico";//juridico
                };
                cliente.cep = mtxtCEP.Text;
                cliente.rua = txtRua.Text;
                cliente.numero = txtNumero.Text;
                cliente.bairro = txtBairro.Text;
                cliente.cidade = txtCidade.Text;
                cliente.estado = txtEstado.Text;
                cliente.telefone = mtxtTelefone.Text;
                cliente.celular = mtxtCelular.Text;
                cliente.email = txtEmail.Text;

                //envia para o metodo tudo q foi colocado na classe cliente
                ClienteBLL clienteBLL = new ClienteBLL();
                string retorno = clienteBLL.alterar(cliente);

                //Tenta converter para inteiro se der tudo certo é porque devolveu o códiggo do cliente se der errado tem a msg de erro
                try
                {
                    //salvo com sucessso
                    int idCliente = Convert.ToInt32(retorno);
                    MessageBox.Show("Registro Alterado com Sucesso!. ");
                    //
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}

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
    public partial class FrmManter : Form
    {


        public FrmManter()
        {
            InitializeComponent();     
        }

        public void alterarBotoes(int op)
        {
            btnSalvar.Enabled = false;
            btnLimpar.Enabled = false;
            btnFechar.Enabled = false;

            if (op == 1)//salvar
            {
                btnSalvar.Enabled = true;
                btnLimpar.Enabled = true;
                btnFechar.Enabled = true;
            }
            if (op == 2)//consultar
            {
                btnSalvar.Enabled = false;
                btnLimpar.Enabled = false;
                btnFechar.Enabled = true;
            }
            if (op == 3)//alterar
            {
                btnSalvar.Enabled = true;
                btnLimpar.Enabled = true;
                btnFechar.Enabled = true;
            }
        }

        private void FrmManter_Load(object sender, EventArgs e)
        {
            //ao carregar a tela chama a função
            this.alterarBotoes(1);
        }

        private void FrmManter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}

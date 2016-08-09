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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        //MENU ITEM CADASTRAR PRODUTO
        private void menuItemCadastrarProduto_Click(object sender, EventArgs e)
        {
        }

        //MENU ITEM CADASTRAR CATEGORIA
        private void menuItemCadastrarCategoria_Click(object sender, EventArgs e)
        {
        }



        //MENU ITEM CONSULTAR PRODUTO
        private void menuItemConsultarProduto_Click(object sender, EventArgs e)
        {
        }

        //
        private void menuItemConsultarCategoria_Click(object sender, EventArgs e)
        {

        }

        //
        private void menuItemConfiguracao_Click(object sender, EventArgs e)
        {

        }

        //
        private void menuItemLogout_Click(object sender, EventArgs e)
        {

        }

        //
        private void menuItemSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

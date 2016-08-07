namespace View
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.msHorario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConfiguracao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCadastrarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCadastrarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConsultarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConsultarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStatus.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStatus
            // 
            this.menuStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.msHorario});
            this.menuStatus.Location = new System.Drawing.Point(0, 302);
            this.menuStatus.Name = "menuStatus";
            this.menuStatus.Size = new System.Drawing.Size(706, 22);
            this.menuStatus.TabIndex = 0;
            this.menuStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel1.Text = "Versão 1.0";
            // 
            // msHorario
            // 
            this.msHorario.Name = "msHorario";
            this.msHorario.Size = new System.Drawing.Size(45, 17);
            this.msHorario.Text = "horario";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.cadastrarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.toolStripSeparator1,
            this.menuItemSair});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemConfiguracao,
            this.menuItemLogout});
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.logoutToolStripMenuItem.Text = "Usuário";
            // 
            // menuItemConfiguracao
            // 
            this.menuItemConfiguracao.Name = "menuItemConfiguracao";
            this.menuItemConfiguracao.Size = new System.Drawing.Size(151, 22);
            this.menuItemConfiguracao.Text = "Configurações";
            this.menuItemConfiguracao.Click += new System.EventHandler(this.menuItemConfiguracao_Click);
            // 
            // menuItemLogout
            // 
            this.menuItemLogout.Name = "menuItemLogout";
            this.menuItemLogout.Size = new System.Drawing.Size(151, 22);
            this.menuItemLogout.Text = "Logout";
            this.menuItemLogout.Click += new System.EventHandler(this.menuItemLogout_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // menuItemSair
            // 
            this.menuItemSair.Name = "menuItemSair";
            this.menuItemSair.Size = new System.Drawing.Size(114, 22);
            this.menuItemSair.Text = "Sair";
            this.menuItemSair.Click += new System.EventHandler(this.menuItemSair_Click);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCadastrarProduto,
            this.menuItemCadastrarCategoria});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // menuItemCadastrarProduto
            // 
            this.menuItemCadastrarProduto.Name = "menuItemCadastrarProduto";
            this.menuItemCadastrarProduto.Size = new System.Drawing.Size(152, 22);
            this.menuItemCadastrarProduto.Text = "Produto";
            this.menuItemCadastrarProduto.Click += new System.EventHandler(this.menuItemCadastrarProduto_Click);
            // 
            // menuItemCadastrarCategoria
            // 
            this.menuItemCadastrarCategoria.Name = "menuItemCadastrarCategoria";
            this.menuItemCadastrarCategoria.Size = new System.Drawing.Size(152, 22);
            this.menuItemCadastrarCategoria.Text = "Categoria";
            this.menuItemCadastrarCategoria.Click += new System.EventHandler(this.menuItemCadastrarCategoria_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemConsultarProduto,
            this.menuItemConsultarCategoria});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // menuItemConsultarProduto
            // 
            this.menuItemConsultarProduto.Name = "menuItemConsultarProduto";
            this.menuItemConsultarProduto.Size = new System.Drawing.Size(152, 22);
            this.menuItemConsultarProduto.Text = "Produto";
            this.menuItemConsultarProduto.Click += new System.EventHandler(this.menuItemConsultarProduto_Click);
            // 
            // menuItemConsultarCategoria
            // 
            this.menuItemConsultarCategoria.Name = "menuItemConsultarCategoria";
            this.menuItemConsultarCategoria.Size = new System.Drawing.Size(152, 22);
            this.menuItemConsultarCategoria.Text = "Categoria";
            this.menuItemConsultarCategoria.Click += new System.EventHandler(this.menuItemConsultarCategoria_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.helpToolStripMenuItem.Text = "Ajuda";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 324);
            this.Controls.Add(this.menuStatus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStatus.ResumeLayout(false);
            this.menuStatus.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip menuStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemCadastrarProduto;
        private System.Windows.Forms.ToolStripMenuItem menuItemCadastrarCategoria;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemConfiguracao;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemSair;
        private System.Windows.Forms.ToolStripMenuItem menuItemConsultarProduto;
        private System.Windows.Forms.ToolStripMenuItem menuItemConsultarCategoria;
        private System.Windows.Forms.ToolStripMenuItem menuItemLogout;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel msHorario;
    }
}
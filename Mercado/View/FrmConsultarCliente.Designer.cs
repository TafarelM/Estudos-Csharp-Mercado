namespace View
{
    partial class FrmConsultarCliente
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
            this.dataGridViewPrincipal = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpf_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRg_Ie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRazaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataNascimento_Abertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPrincipal.SuspendLayout();
            this.panelBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.dataGridViewPrincipal);
            this.panelPrincipal.TabIndex = 0;
            this.panelPrincipal.Controls.SetChildIndex(this.txtPesquisar, 0);
            this.panelPrincipal.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.panelPrincipal.Controls.SetChildIndex(this.dataGridViewPrincipal, 0);
            // 
            // panelBtn
            // 
            this.panelBtn.TabIndex = 1;
            // 
            // btnConsultar
            // 
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.TabIndex = 0;
            // 
            // dataGridViewPrincipal
            // 
            this.dataGridViewPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNome,
            this.colCpf_cnpj,
            this.colRg_Ie,
            this.colRazaoSocial,
            this.colDataNascimento_Abertura,
            this.colSexo,
            this.colTipoCliente,
            this.colCep,
            this.colRua,
            this.colNumero,
            this.colBairro,
            this.colCidade,
            this.colEstado,
            this.colTelefone,
            this.colCelular,
            this.colEmail});
            this.dataGridViewPrincipal.Location = new System.Drawing.Point(3, 41);
            this.dataGridViewPrincipal.MultiSelect = false;
            this.dataGridViewPrincipal.Name = "dataGridViewPrincipal";
            this.dataGridViewPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPrincipal.Size = new System.Drawing.Size(767, 348);
            this.dataGridViewPrincipal.TabIndex = 2;
            this.dataGridViewPrincipal.TabStop = false;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "IDCliente";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "Nome";
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colCpf_cnpj
            // 
            this.colCpf_cnpj.DataPropertyName = "CPF_CNPJ";
            this.colCpf_cnpj.HeaderText = "CPF/CNPJ";
            this.colCpf_cnpj.Name = "colCpf_cnpj";
            this.colCpf_cnpj.ReadOnly = true;
            // 
            // colRg_Ie
            // 
            this.colRg_Ie.DataPropertyName = "RG_IE";
            this.colRg_Ie.HeaderText = "RG/IE";
            this.colRg_Ie.Name = "colRg_Ie";
            this.colRg_Ie.ReadOnly = true;
            // 
            // colRazaoSocial
            // 
            this.colRazaoSocial.DataPropertyName = "RazaoSocial";
            this.colRazaoSocial.HeaderText = "Razão Social ";
            this.colRazaoSocial.Name = "colRazaoSocial";
            this.colRazaoSocial.ReadOnly = true;
            // 
            // colDataNascimento_Abertura
            // 
            this.colDataNascimento_Abertura.DataPropertyName = "DataNascimento_Abertura";
            this.colDataNascimento_Abertura.HeaderText = "Data de Nascimento/Data de Abertura";
            this.colDataNascimento_Abertura.Name = "colDataNascimento_Abertura";
            this.colDataNascimento_Abertura.ReadOnly = true;
            // 
            // colSexo
            // 
            this.colSexo.DataPropertyName = "Sexo";
            this.colSexo.HeaderText = "Sexo";
            this.colSexo.Name = "colSexo";
            this.colSexo.ReadOnly = true;
            // 
            // colTipoCliente
            // 
            this.colTipoCliente.DataPropertyName = "TipoCliente";
            this.colTipoCliente.HeaderText = "Tipo Cliente";
            this.colTipoCliente.Name = "colTipoCliente";
            this.colTipoCliente.ReadOnly = true;
            // 
            // colCep
            // 
            this.colCep.DataPropertyName = "CEP";
            this.colCep.HeaderText = "CEP";
            this.colCep.Name = "colCep";
            this.colCep.ReadOnly = true;
            // 
            // colRua
            // 
            this.colRua.DataPropertyName = "Rua";
            this.colRua.HeaderText = "Rua";
            this.colRua.Name = "colRua";
            this.colRua.ReadOnly = true;
            // 
            // colNumero
            // 
            this.colNumero.DataPropertyName = "Numero";
            this.colNumero.HeaderText = "Número";
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            // 
            // colBairro
            // 
            this.colBairro.DataPropertyName = "Bairro";
            this.colBairro.HeaderText = "Bairro";
            this.colBairro.Name = "colBairro";
            this.colBairro.ReadOnly = true;
            // 
            // colCidade
            // 
            this.colCidade.DataPropertyName = "Cidade";
            this.colCidade.HeaderText = "Cidade";
            this.colCidade.Name = "colCidade";
            this.colCidade.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "Estado";
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // colTelefone
            // 
            this.colTelefone.DataPropertyName = "Telefone";
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.ReadOnly = true;
            // 
            // colCelular
            // 
            this.colCelular.DataPropertyName = "Celular";
            this.colCelular.HeaderText = "Celular";
            this.colCelular.Name = "colCelular";
            this.colCelular.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "E-mail";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // FrmConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Name = "FrmConsultarCliente";
            this.Text = "FrmConsultarCliente";
            this.Load += new System.EventHandler(this.FrmConsultarCliente_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panelBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpf_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRg_Ie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRazaoSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataNascimento_Abertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
    }
}
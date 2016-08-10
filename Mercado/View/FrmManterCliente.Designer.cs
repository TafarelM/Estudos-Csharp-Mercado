namespace View
{
    partial class FrmManterCliente
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblCPF_CNPJ = new System.Windows.Forms.Label();
            this.mtxtCPF_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lblRG_IE = new System.Windows.Forms.Label();
            this.mtxtRG_IE = new System.Windows.Forms.MaskedTextBox();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.mtxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.mtxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnClienteJuridico = new System.Windows.Forms.RadioButton();
            this.rbtnClienteFisico = new System.Windows.Forms.RadioButton();
            this.lblDataNascimento_Abertura = new System.Windows.Forms.Label();
            this.mtxtDataNascimento_Abertura = new System.Windows.Forms.MaskedTextBox();
            this.panelBtn.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBtn
            // 
            this.panelBtn.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.mtxtDataNascimento_Abertura);
            this.panelPrincipal.Controls.Add(this.lblDataNascimento_Abertura);
            this.panelPrincipal.Controls.Add(this.groupBox3);
            this.panelPrincipal.Controls.Add(this.gbSexo);
            this.panelPrincipal.Controls.Add(this.gbEndereco);
            this.panelPrincipal.Controls.Add(this.mtxtRG_IE);
            this.panelPrincipal.Controls.Add(this.lblRG_IE);
            this.panelPrincipal.Controls.Add(this.mtxtCPF_CNPJ);
            this.panelPrincipal.Controls.Add(this.lblCPF_CNPJ);
            this.panelPrincipal.Controls.Add(this.txtRazaoSocial);
            this.panelPrincipal.Controls.Add(this.txtId);
            this.panelPrincipal.Controls.Add(this.lblID);
            this.panelPrincipal.Controls.Add(this.lblRazaoSocial);
            this.panelPrincipal.Controls.Add(this.txtNome);
            this.panelPrincipal.Controls.Add(this.lblNome);
            this.panelPrincipal.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(16, 47);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(372, 20);
            this.txtNome.TabIndex = 4;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Location = new System.Drawing.Point(16, 80);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(70, 13);
            this.lblRazaoSocial.TabIndex = 5;
            this.lblRazaoSocial.Text = "Razão Social";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(16, 14);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(16, 27);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(90, 20);
            this.txtId.TabIndex = 1;
            this.txtId.TabStop = false;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(16, 93);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(372, 20);
            this.txtRazaoSocial.TabIndex = 6;
            // 
            // lblCPF_CNPJ
            // 
            this.lblCPF_CNPJ.AutoSize = true;
            this.lblCPF_CNPJ.Location = new System.Drawing.Point(16, 113);
            this.lblCPF_CNPJ.Name = "lblCPF_CNPJ";
            this.lblCPF_CNPJ.Size = new System.Drawing.Size(27, 13);
            this.lblCPF_CNPJ.TabIndex = 7;
            this.lblCPF_CNPJ.Text = "CPF";
            // 
            // mtxtCPF_CNPJ
            // 
            this.mtxtCPF_CNPJ.Location = new System.Drawing.Point(16, 126);
            this.mtxtCPF_CNPJ.Name = "mtxtCPF_CNPJ";
            this.mtxtCPF_CNPJ.Size = new System.Drawing.Size(132, 20);
            this.mtxtCPF_CNPJ.TabIndex = 8;
            // 
            // lblRG_IE
            // 
            this.lblRG_IE.AutoSize = true;
            this.lblRG_IE.Location = new System.Drawing.Point(154, 113);
            this.lblRG_IE.Name = "lblRG_IE";
            this.lblRG_IE.Size = new System.Drawing.Size(23, 13);
            this.lblRG_IE.TabIndex = 9;
            this.lblRG_IE.Text = "RG";
            // 
            // mtxtRG_IE
            // 
            this.mtxtRG_IE.Location = new System.Drawing.Point(154, 126);
            this.mtxtRG_IE.Name = "mtxtRG_IE";
            this.mtxtRG_IE.Size = new System.Drawing.Size(134, 20);
            this.mtxtRG_IE.TabIndex = 10;
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.txtCidade);
            this.gbEndereco.Controls.Add(this.lblCidade);
            this.gbEndereco.Controls.Add(this.txtNumero);
            this.gbEndereco.Controls.Add(this.lblNumero);
            this.gbEndereco.Controls.Add(this.mtxtCelular);
            this.gbEndereco.Controls.Add(this.mtxtTelefone);
            this.gbEndereco.Controls.Add(this.txtEmail);
            this.gbEndereco.Controls.Add(this.txtBairro);
            this.gbEndereco.Controls.Add(this.lblTelefone);
            this.gbEndereco.Controls.Add(this.lblEmail);
            this.gbEndereco.Controls.Add(this.lblCelular);
            this.gbEndereco.Controls.Add(this.txtRua);
            this.gbEndereco.Controls.Add(this.lblBairro);
            this.gbEndereco.Controls.Add(this.lblRua);
            this.gbEndereco.Controls.Add(this.txtEstado);
            this.gbEndereco.Controls.Add(this.lblEstado);
            this.gbEndereco.Controls.Add(this.mtxtCEP);
            this.gbEndereco.Controls.Add(this.lblCEP);
            this.gbEndereco.Location = new System.Drawing.Point(3, 199);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(768, 190);
            this.gbEndereco.TabIndex = 14;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(295, 30);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(170, 20);
            this.txtCidade.TabIndex = 6;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(295, 17);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 5;
            this.lblCidade.Text = "Cidade";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(295, 96);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(83, 20);
            this.txtNumero.TabIndex = 12;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(295, 83);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 11;
            this.lblNumero.Text = "Numero";
            // 
            // mtxtCelular
            // 
            this.mtxtCelular.Location = new System.Drawing.Point(189, 162);
            this.mtxtCelular.Name = "mtxtCelular";
            this.mtxtCelular.Size = new System.Drawing.Size(175, 20);
            this.mtxtCelular.TabIndex = 0;
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.Location = new System.Drawing.Point(13, 162);
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(170, 20);
            this.mtxtTelefone.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(13, 129);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(362, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(13, 96);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(276, 20);
            this.txtBairro.TabIndex = 10;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(13, 149);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 15;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 116);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "E-mail";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(189, 149);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 17;
            this.lblCelular.Text = "Celular";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(13, 63);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(452, 20);
            this.txtRua.TabIndex = 8;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(13, 83);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 9;
            this.lblBairro.Text = "Bairro";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(13, 50);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(27, 13);
            this.lblRua.TabIndex = 7;
            this.lblRua.Text = "Rua";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(125, 30);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(164, 20);
            this.txtEstado.TabIndex = 4;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(125, 17);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "Estado";
            // 
            // mtxtCEP
            // 
            this.mtxtCEP.Location = new System.Drawing.Point(13, 30);
            this.mtxtCEP.Name = "mtxtCEP";
            this.mtxtCEP.Size = new System.Drawing.Size(106, 20);
            this.mtxtCEP.TabIndex = 2;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(13, 17);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(28, 13);
            this.lblCEP.TabIndex = 1;
            this.lblCEP.Text = "CEP";
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbtnFeminino);
            this.gbSexo.Controls.Add(this.rbtnMasculino);
            this.gbSexo.Location = new System.Drawing.Point(294, 113);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(172, 36);
            this.gbSexo.TabIndex = 11;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(98, 15);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbtnFeminino.TabIndex = 1;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Checked = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(7, 15);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtnMasculino.TabIndex = 0;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnClienteJuridico);
            this.groupBox3.Controls.Add(this.rbtnClienteFisico);
            this.groupBox3.Location = new System.Drawing.Point(174, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 44);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de Cliente";
            // 
            // rbtnClienteJuridico
            // 
            this.rbtnClienteJuridico.AutoSize = true;
            this.rbtnClienteJuridico.Location = new System.Drawing.Point(67, 19);
            this.rbtnClienteJuridico.Name = "rbtnClienteJuridico";
            this.rbtnClienteJuridico.Size = new System.Drawing.Size(63, 17);
            this.rbtnClienteJuridico.TabIndex = 1;
            this.rbtnClienteJuridico.Text = "Jurídico";
            this.rbtnClienteJuridico.UseVisualStyleBackColor = true;
            // 
            // rbtnClienteFisico
            // 
            this.rbtnClienteFisico.AutoSize = true;
            this.rbtnClienteFisico.Checked = true;
            this.rbtnClienteFisico.Location = new System.Drawing.Point(7, 20);
            this.rbtnClienteFisico.Name = "rbtnClienteFisico";
            this.rbtnClienteFisico.Size = new System.Drawing.Size(54, 17);
            this.rbtnClienteFisico.TabIndex = 0;
            this.rbtnClienteFisico.TabStop = true;
            this.rbtnClienteFisico.Text = "Fisíco";
            this.rbtnClienteFisico.UseVisualStyleBackColor = true;
            this.rbtnClienteFisico.CheckedChanged += new System.EventHandler(this.rbtnClienteFisico_CheckedChanged);
            // 
            // lblDataNascimento_Abertura
            // 
            this.lblDataNascimento_Abertura.AutoSize = true;
            this.lblDataNascimento_Abertura.Location = new System.Drawing.Point(16, 146);
            this.lblDataNascimento_Abertura.Name = "lblDataNascimento_Abertura";
            this.lblDataNascimento_Abertura.Size = new System.Drawing.Size(104, 13);
            this.lblDataNascimento_Abertura.TabIndex = 12;
            this.lblDataNascimento_Abertura.Text = "Data de Nascimento";
            // 
            // mtxtDataNascimento_Abertura
            // 
            this.mtxtDataNascimento_Abertura.Location = new System.Drawing.Point(16, 159);
            this.mtxtDataNascimento_Abertura.Mask = "00/00/0000";
            this.mtxtDataNascimento_Abertura.Name = "mtxtDataNascimento_Abertura";
            this.mtxtDataNascimento_Abertura.Size = new System.Drawing.Size(138, 20);
            this.mtxtDataNascimento_Abertura.TabIndex = 13;
            this.mtxtDataNascimento_Abertura.ValidatingType = typeof(System.DateTime);
            // 
            // FrmManterCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 490);
            this.Name = "FrmManterCliente";
            this.Text = "FrmManterCliente";
            this.Load += new System.EventHandler(this.FrmManterCliente_Load);
            this.panelBtn.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mtxtRG_IE;
        private System.Windows.Forms.Label lblRG_IE;
        private System.Windows.Forms.MaskedTextBox mtxtCPF_CNPJ;
        private System.Windows.Forms.Label lblCPF_CNPJ;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.MaskedTextBox mtxtCelular;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.MaskedTextBox mtxtCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtnClienteJuridico;
        private System.Windows.Forms.RadioButton rbtnClienteFisico;
        private System.Windows.Forms.MaskedTextBox mtxtDataNascimento_Abertura;
        private System.Windows.Forms.Label lblDataNascimento_Abertura;
    }
}
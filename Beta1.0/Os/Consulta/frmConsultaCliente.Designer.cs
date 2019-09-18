namespace Beta1._0.Os.Consulta
{
    partial class frmConsultaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCliente));
            this.dgCliente = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbRg = new System.Windows.Forms.RadioButton();
            this.cli_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_cpfcnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_rgie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_rsocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_fone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_cel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_endnumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_cadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCliente
            // 
            this.dgCliente.AllowUserToAddRows = false;
            this.dgCliente.AllowUserToDeleteRows = false;
            this.dgCliente.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cli_nome,
            this.cli_cod,
            this.cli_cpfcnpj,
            this.cli_rgie,
            this.cli_rsocial,
            this.cli_tipo,
            this.cli_cep,
            this.cli_endereco,
            this.cli_bairro,
            this.cli_fone,
            this.cli_cel,
            this.cli_email,
            this.cli_endnumero,
            this.cli_cidade,
            this.cli_estado,
            this.cli_observacao,
            this.cli_cadastro});
            this.dgCliente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgCliente.Location = new System.Drawing.Point(0, 76);
            this.dgCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgCliente.Name = "dgCliente";
            this.dgCliente.ReadOnly = true;
            this.dgCliente.RowHeadersVisible = false;
            this.dgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCliente.Size = new System.Drawing.Size(561, 246);
            this.dgCliente.TabIndex = 0;
            this.dgCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCliente_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(430, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(9, 44);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(413, 23);
            this.txtPesquisa.TabIndex = 2;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Location = new System.Drawing.Point(9, 16);
            this.rbNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(59, 20);
            this.rbNome.TabIndex = 0;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // rbRg
            // 
            this.rbRg.AutoSize = true;
            this.rbRg.Location = new System.Drawing.Point(78, 16);
            this.rbRg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbRg.Name = "rbRg";
            this.rbRg.Size = new System.Drawing.Size(42, 20);
            this.rbRg.TabIndex = 1;
            this.rbRg.TabStop = true;
            this.rbRg.Text = "RG";
            this.rbRg.UseVisualStyleBackColor = true;
            // 
            // cli_nome
            // 
            this.cli_nome.DataPropertyName = "cli_nome";
            this.cli_nome.HeaderText = "Cliente";
            this.cli_nome.Name = "cli_nome";
            this.cli_nome.ReadOnly = true;
            // 
            // cli_cod
            // 
            this.cli_cod.DataPropertyName = "cli_cod";
            this.cli_cod.HeaderText = "Cod";
            this.cli_cod.Name = "cli_cod";
            this.cli_cod.ReadOnly = true;
            // 
            // cli_cpfcnpj
            // 
            this.cli_cpfcnpj.DataPropertyName = "cli_cpfcnpj";
            this.cli_cpfcnpj.HeaderText = "Cpf/Cnpj";
            this.cli_cpfcnpj.Name = "cli_cpfcnpj";
            this.cli_cpfcnpj.ReadOnly = true;
            // 
            // cli_rgie
            // 
            this.cli_rgie.DataPropertyName = "cli_rgie";
            this.cli_rgie.HeaderText = "RG";
            this.cli_rgie.Name = "cli_rgie";
            this.cli_rgie.ReadOnly = true;
            // 
            // cli_rsocial
            // 
            this.cli_rsocial.DataPropertyName = "cli_rsocial";
            this.cli_rsocial.HeaderText = "R.Social";
            this.cli_rsocial.Name = "cli_rsocial";
            this.cli_rsocial.ReadOnly = true;
            this.cli_rsocial.Visible = false;
            // 
            // cli_tipo
            // 
            this.cli_tipo.DataPropertyName = "cli_tipo";
            this.cli_tipo.HeaderText = "Tipo";
            this.cli_tipo.Name = "cli_tipo";
            this.cli_tipo.ReadOnly = true;
            this.cli_tipo.Visible = false;
            // 
            // cli_cep
            // 
            this.cli_cep.DataPropertyName = "cli_cep";
            this.cli_cep.HeaderText = "CEP";
            this.cli_cep.Name = "cli_cep";
            this.cli_cep.ReadOnly = true;
            // 
            // cli_endereco
            // 
            this.cli_endereco.DataPropertyName = "cli_endereco";
            this.cli_endereco.HeaderText = "Endereço";
            this.cli_endereco.Name = "cli_endereco";
            this.cli_endereco.ReadOnly = true;
            // 
            // cli_bairro
            // 
            this.cli_bairro.DataPropertyName = "cli_bairro";
            this.cli_bairro.HeaderText = "Bairro";
            this.cli_bairro.Name = "cli_bairro";
            this.cli_bairro.ReadOnly = true;
            // 
            // cli_fone
            // 
            this.cli_fone.DataPropertyName = "cli_fone";
            this.cli_fone.HeaderText = "Telefone";
            this.cli_fone.Name = "cli_fone";
            this.cli_fone.ReadOnly = true;
            // 
            // cli_cel
            // 
            this.cli_cel.DataPropertyName = "cli_cel";
            this.cli_cel.HeaderText = "Celular";
            this.cli_cel.Name = "cli_cel";
            this.cli_cel.ReadOnly = true;
            // 
            // cli_email
            // 
            this.cli_email.DataPropertyName = "cli_email";
            this.cli_email.HeaderText = "Email";
            this.cli_email.Name = "cli_email";
            this.cli_email.ReadOnly = true;
            // 
            // cli_endnumero
            // 
            this.cli_endnumero.DataPropertyName = "cli_endnumero";
            this.cli_endnumero.HeaderText = "Nº";
            this.cli_endnumero.Name = "cli_endnumero";
            this.cli_endnumero.ReadOnly = true;
            // 
            // cli_cidade
            // 
            this.cli_cidade.DataPropertyName = "cli_cidade";
            this.cli_cidade.HeaderText = "Cidade";
            this.cli_cidade.Name = "cli_cidade";
            this.cli_cidade.ReadOnly = true;
            // 
            // cli_estado
            // 
            this.cli_estado.DataPropertyName = "cli_estado";
            this.cli_estado.HeaderText = "UF";
            this.cli_estado.Name = "cli_estado";
            this.cli_estado.ReadOnly = true;
            // 
            // cli_observacao
            // 
            this.cli_observacao.DataPropertyName = "cli_observacao";
            this.cli_observacao.HeaderText = "Obs";
            this.cli_observacao.Name = "cli_observacao";
            this.cli_observacao.ReadOnly = true;
            // 
            // cli_cadastro
            // 
            this.cli_cadastro.DataPropertyName = "cli_cadastro";
            this.cli_cadastro.HeaderText = "Cadastro";
            this.cli_cadastro.Name = "cli_cadastro";
            this.cli_cadastro.ReadOnly = true;
            // 
            // frmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(561, 322);
            this.Controls.Add(this.rbRg);
            this.Controls.Add(this.rbNome);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgCliente);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Cliente";
            this.Load += new System.EventHandler(this.frmConsultaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbRg;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_cpfcnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_rgie;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_rsocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_fone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_cel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_endnumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_observacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_cadastro;
    }
}
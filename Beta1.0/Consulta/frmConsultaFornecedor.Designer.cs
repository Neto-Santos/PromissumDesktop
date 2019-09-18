namespace Beta1._0.Consulta
{
    partial class frmConsultaFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaFornecedor));
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.for_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.for_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.for_rsocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.for_ie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.for_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.for_cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.for_endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.for_bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.for_fone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.for_cel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.for_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.for_endnumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.for_cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.for_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.for_cadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.for_cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbImpressora = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbCnpj = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.AllowUserToAddRows = false;
            this.dgvFornecedor.AllowUserToDeleteRows = false;
            this.dgvFornecedor.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.for_cod,
            this.for_nome,
            this.for_rsocial,
            this.for_ie,
            this.for_cnpj,
            this.for_cep,
            this.for_endereco,
            this.for_bairro,
            this.for_fone,
            this.for_cel,
            this.for_email,
            this.for_endnumero,
            this.for_cidade,
            this.for_estado,
            this.for_cadastro,
            this.for_cpf});
            this.dgvFornecedor.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvFornecedor.Location = new System.Drawing.Point(1, 1);
            this.dgvFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.ReadOnly = true;
            this.dgvFornecedor.RowHeadersVisible = false;
            this.dgvFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedor.Size = new System.Drawing.Size(607, 532);
            this.dgvFornecedor.TabIndex = 3;
            this.dgvFornecedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedor_CellClick);
            // 
            // for_cod
            // 
            this.for_cod.DataPropertyName = "for_cod";
            this.for_cod.HeaderText = "Codigo";
            this.for_cod.Name = "for_cod";
            this.for_cod.ReadOnly = true;
            // 
            // for_nome
            // 
            this.for_nome.DataPropertyName = "for_nome";
            this.for_nome.HeaderText = "Fornecedor";
            this.for_nome.Name = "for_nome";
            this.for_nome.ReadOnly = true;
            // 
            // for_rsocial
            // 
            this.for_rsocial.DataPropertyName = "for_rsocial";
            this.for_rsocial.HeaderText = "Razão Social";
            this.for_rsocial.Name = "for_rsocial";
            this.for_rsocial.ReadOnly = true;
            // 
            // for_ie
            // 
            this.for_ie.DataPropertyName = "for_ie";
            this.for_ie.HeaderText = "IE";
            this.for_ie.Name = "for_ie";
            this.for_ie.ReadOnly = true;
            // 
            // for_cnpj
            // 
            this.for_cnpj.DataPropertyName = "for_cnpj";
            this.for_cnpj.HeaderText = "Cnpj";
            this.for_cnpj.Name = "for_cnpj";
            this.for_cnpj.ReadOnly = true;
            // 
            // for_cep
            // 
            this.for_cep.DataPropertyName = "for_cep";
            this.for_cep.HeaderText = "CEP";
            this.for_cep.Name = "for_cep";
            this.for_cep.ReadOnly = true;
            // 
            // for_endereco
            // 
            this.for_endereco.DataPropertyName = "for_endereco";
            this.for_endereco.HeaderText = "Endereço";
            this.for_endereco.Name = "for_endereco";
            this.for_endereco.ReadOnly = true;
            // 
            // for_bairro
            // 
            this.for_bairro.DataPropertyName = "for_bairro";
            this.for_bairro.HeaderText = "Bairro";
            this.for_bairro.Name = "for_bairro";
            this.for_bairro.ReadOnly = true;
            // 
            // for_fone
            // 
            this.for_fone.DataPropertyName = "for_fone";
            this.for_fone.HeaderText = "Telefone";
            this.for_fone.Name = "for_fone";
            this.for_fone.ReadOnly = true;
            // 
            // for_cel
            // 
            this.for_cel.DataPropertyName = "for_cel";
            this.for_cel.HeaderText = "Celular";
            this.for_cel.Name = "for_cel";
            this.for_cel.ReadOnly = true;
            // 
            // for_email
            // 
            this.for_email.DataPropertyName = "for_email";
            this.for_email.HeaderText = "Email";
            this.for_email.Name = "for_email";
            this.for_email.ReadOnly = true;
            // 
            // for_endnumero
            // 
            this.for_endnumero.DataPropertyName = "for_endnumero";
            this.for_endnumero.HeaderText = "Nº";
            this.for_endnumero.Name = "for_endnumero";
            this.for_endnumero.ReadOnly = true;
            // 
            // for_cidade
            // 
            this.for_cidade.DataPropertyName = "for_cidade";
            this.for_cidade.HeaderText = "Cidade";
            this.for_cidade.Name = "for_cidade";
            this.for_cidade.ReadOnly = true;
            // 
            // for_estado
            // 
            this.for_estado.DataPropertyName = "for_estado";
            this.for_estado.HeaderText = "Estado";
            this.for_estado.Name = "for_estado";
            this.for_estado.ReadOnly = true;
            // 
            // for_cadastro
            // 
            this.for_cadastro.DataPropertyName = "for_cadastro";
            this.for_cadastro.HeaderText = "Cadastro";
            this.for_cadastro.Name = "for_cadastro";
            this.for_cadastro.ReadOnly = true;
            // 
            // for_cpf
            // 
            this.for_cpf.DataPropertyName = "for_cpf";
            this.for_cpf.HeaderText = "CPF";
            this.for_cpf.Name = "for_cpf";
            this.for_cpf.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbImpressora);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(614, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(233, 316);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Listagem";
            // 
            // cbImpressora
            // 
            this.cbImpressora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImpressora.FormattingEnabled = true;
            this.cbImpressora.Location = new System.Drawing.Point(99, 87);
            this.cbImpressora.Name = "cbImpressora";
            this.cbImpressora.Size = new System.Drawing.Size(127, 24);
            this.cbImpressora.TabIndex = 8;
            this.cbImpressora.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbCodigo);
            this.groupBox2.Controls.Add(this.rbCnpj);
            this.groupBox2.Controls.Add(this.rbNome);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Location = new System.Drawing.Point(8, 119);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(218, 186);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PESQUISA";
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Location = new System.Drawing.Point(7, 80);
            this.rbCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(65, 20);
            this.rbCodigo.TabIndex = 2;
            this.rbCodigo.Text = "Codigo";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // rbCnpj
            // 
            this.rbCnpj.AutoSize = true;
            this.rbCnpj.Location = new System.Drawing.Point(7, 52);
            this.rbCnpj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbCnpj.Name = "rbCnpj";
            this.rbCnpj.Size = new System.Drawing.Size(52, 20);
            this.rbCnpj.TabIndex = 1;
            this.rbCnpj.Text = "Cnpj";
            this.rbCnpj.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Checked = true;
            this.rbNome.Location = new System.Drawing.Point(7, 23);
            this.rbNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(59, 20);
            this.rbNome.TabIndex = 0;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 111);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 23);
            this.textBox1.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(7, 143);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 28);
            this.button5.TabIndex = 4;
            this.button5.Text = "FILTRAR";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::Promissum.Properties.Resources.print;
            this.button4.Location = new System.Drawing.Point(120, 17);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 52);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluir.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.Location = new System.Drawing.Point(7, 84);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(87, 28);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Yellow;
            this.btnAlterar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAlterar.Location = new System.Drawing.Point(7, 52);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(87, 28);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(7, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "INCLUIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmConsultaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 537);
            this.Controls.Add(this.dgvFornecedor);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Fornecedores";
            this.Activated += new System.EventHandler(this.frmConsultaFornecedor_Activated);
            this.Load += new System.EventHandler(this.frmConsultaFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbCnpj;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dgvFornecedor;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn for_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn for_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn for_rsocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn for_ie;
        private System.Windows.Forms.DataGridViewTextBoxColumn for_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn for_cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn for_endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn for_bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn for_fone;
        private System.Windows.Forms.DataGridViewTextBoxColumn for_cel;
        private System.Windows.Forms.DataGridViewTextBoxColumn for_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn for_endnumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn for_cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn for_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn for_cadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn for_cpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbImpressora;
    }
}
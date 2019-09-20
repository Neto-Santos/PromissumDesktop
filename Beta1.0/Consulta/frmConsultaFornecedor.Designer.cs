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
            this.pnCabecalho = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnCabecalho.SuspendLayout();
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
            this.dgvFornecedor.Location = new System.Drawing.Point(1, 163);
            this.dgvFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.ReadOnly = true;
            this.dgvFornecedor.RowHeadersVisible = false;
            this.dgvFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedor.Size = new System.Drawing.Size(829, 356);
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
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(1, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(829, 122);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // cbImpressora
            // 
            this.cbImpressora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImpressora.FormattingEnabled = true;
            this.cbImpressora.Location = new System.Drawing.Point(449, 16);
            this.cbImpressora.Name = "cbImpressora";
            this.cbImpressora.Size = new System.Drawing.Size(127, 24);
            this.cbImpressora.TabIndex = 8;
            this.cbImpressora.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbCodigo);
            this.groupBox2.Controls.Add(this.cbImpressora);
            this.groupBox2.Controls.Add(this.rbCnpj);
            this.groupBox2.Controls.Add(this.rbNome);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Location = new System.Drawing.Point(241, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(582, 109);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PESQUISA";
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Location = new System.Drawing.Point(134, 20);
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
            this.rbCnpj.Location = new System.Drawing.Point(75, 20);
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
            this.rbNome.Location = new System.Drawing.Point(9, 20);
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
            this.textBox1.Location = new System.Drawing.Point(9, 47);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(568, 23);
            this.textBox1.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.Image = global::Promissum.Properties.Resources.icone_lupa;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(9, 70);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 28);
            this.button5.TabIndex = 4;
            this.button5.Text = "FILTRAR";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::Promissum.Properties.Resources.print;
            this.button4.Location = new System.Drawing.Point(6, 80);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 38);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Image = global::Promissum.Properties.Resources.icone_delete;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(167, 9);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(77, 59);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAlterar.ForeColor = System.Drawing.Color.Black;
            this.btnAlterar.Image = global::Promissum.Properties.Resources.icone_alterar;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.Location = new System.Drawing.Point(82, 9);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(77, 62);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::Promissum.Properties.Resources.icon_add;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(6, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "INCLUIR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnCabecalho
            // 
            this.pnCabecalho.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnCabecalho.Controls.Add(this.label4);
            this.pnCabecalho.Controls.Add(this.btnFechar);
            this.pnCabecalho.Controls.Add(this.btnMinimizar);
            this.pnCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnCabecalho.Name = "pnCabecalho";
            this.pnCabecalho.Size = new System.Drawing.Size(831, 42);
            this.pnCabecalho.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fornecedor";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackgroundImage = global::Promissum.Properties.Resources.icone_fechar;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(767, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(62, 38);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.UseVisualStyleBackColor = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImage = global::Promissum.Properties.Resources.icone_minimizar;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(722, 8);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(39, 23);
            this.btnMinimizar.TabIndex = 5;
            this.btnMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // frmConsultaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 518);
            this.Controls.Add(this.pnCabecalho);
            this.Controls.Add(this.dgvFornecedor);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnCabecalho.ResumeLayout(false);
            this.pnCabecalho.PerformLayout();
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
        private System.Windows.Forms.ComboBox cbImpressora;
        private System.Windows.Forms.Panel pnCabecalho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimizar;
    }
}
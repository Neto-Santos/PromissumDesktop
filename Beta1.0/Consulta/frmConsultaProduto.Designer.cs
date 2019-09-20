namespace Beta1._0.Consulta
{
    partial class frmConsultaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaProduto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbProduto = new System.Windows.Forms.RadioButton();
            this.rbSubCategoria = new System.Windows.Forms.RadioButton();
            this.rbCategoria = new System.Windows.Forms.RadioButton();
            this.cbImpressora = new System.Windows.Forms.ComboBox();
            this.rbCod = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgProduto = new System.Windows.Forms.DataGridView();
            this.pro_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_valorpago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_valorvenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.umed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scat_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_ref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnCabecalho = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).BeginInit();
            this.pnCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(2, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(830, 129);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = global::Promissum.Properties.Resources.icone_delete;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(134, 15);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 56);
            this.button5.TabIndex = 10;
            this.button5.Text = "Mudar Status";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.button6.Image = global::Promissum.Properties.Resources.icone_alterar;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.Location = new System.Drawing.Point(72, 17);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(66, 53);
            this.button6.TabIndex = 9;
            this.button6.Text = "Alterar";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button2_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Image = global::Promissum.Properties.Resources.icon_add;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.Location = new System.Drawing.Point(6, 16);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(66, 55);
            this.button7.TabIndex = 8;
            this.button7.Text = "INCLUIR";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbProduto);
            this.groupBox2.Controls.Add(this.rbSubCategoria);
            this.groupBox2.Controls.Add(this.rbCategoria);
            this.groupBox2.Controls.Add(this.cbImpressora);
            this.groupBox2.Controls.Add(this.rbCod);
            this.groupBox2.Controls.Add(this.txtPesquisa);
            this.groupBox2.Controls.Add(this.btnFiltrar);
            this.groupBox2.Location = new System.Drawing.Point(344, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(480, 107);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PESQUISA";
            // 
            // rbProduto
            // 
            this.rbProduto.AutoSize = true;
            this.rbProduto.Checked = true;
            this.rbProduto.Location = new System.Drawing.Point(217, 18);
            this.rbProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbProduto.Name = "rbProduto";
            this.rbProduto.Size = new System.Drawing.Size(70, 20);
            this.rbProduto.TabIndex = 3;
            this.rbProduto.TabStop = true;
            this.rbProduto.Text = "Produto";
            this.rbProduto.UseVisualStyleBackColor = true;
            // 
            // rbSubCategoria
            // 
            this.rbSubCategoria.AutoSize = true;
            this.rbSubCategoria.Location = new System.Drawing.Point(141, 18);
            this.rbSubCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSubCategoria.Name = "rbSubCategoria";
            this.rbSubCategoria.Size = new System.Drawing.Size(67, 20);
            this.rbSubCategoria.TabIndex = 2;
            this.rbSubCategoria.TabStop = true;
            this.rbSubCategoria.Text = "Modelo";
            this.rbSubCategoria.UseVisualStyleBackColor = true;
            // 
            // rbCategoria
            // 
            this.rbCategoria.AutoSize = true;
            this.rbCategoria.Location = new System.Drawing.Point(81, 18);
            this.rbCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbCategoria.Name = "rbCategoria";
            this.rbCategoria.Size = new System.Drawing.Size(51, 20);
            this.rbCategoria.TabIndex = 1;
            this.rbCategoria.TabStop = true;
            this.rbCategoria.Text = "Tipo";
            this.rbCategoria.UseVisualStyleBackColor = true;
            // 
            // cbImpressora
            // 
            this.cbImpressora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImpressora.FormattingEnabled = true;
            this.cbImpressora.Location = new System.Drawing.Point(346, 74);
            this.cbImpressora.Name = "cbImpressora";
            this.cbImpressora.Size = new System.Drawing.Size(127, 24);
            this.cbImpressora.TabIndex = 6;
            this.cbImpressora.Visible = false;
            // 
            // rbCod
            // 
            this.rbCod.AutoSize = true;
            this.rbCod.Location = new System.Drawing.Point(7, 18);
            this.rbCod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbCod.Name = "rbCod";
            this.rbCod.Size = new System.Drawing.Size(65, 20);
            this.rbCod.TabIndex = 0;
            this.rbCod.TabStop = true;
            this.rbCod.Text = "Codigo";
            this.rbCod.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(7, 44);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(466, 23);
            this.txtPesquisa.TabIndex = 4;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFiltrar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFiltrar.Location = new System.Drawing.Point(6, 75);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(87, 28);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Promissum.Properties.Resources.print;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(266, 24);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 56);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgProduto
            // 
            this.dgProduto.AllowUserToAddRows = false;
            this.dgProduto.AllowUserToDeleteRows = false;
            this.dgProduto.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgProduto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pro_cod,
            this.pro_nome,
            this.pro_descricao,
            this.pro_valorpago,
            this.pro_valorvenda,
            this.pro_qtde,
            this.umed,
            this.cat_nome,
            this.scat_nome,
            this.pro_ref});
            this.dgProduto.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgProduto.Location = new System.Drawing.Point(2, 175);
            this.dgProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgProduto.Name = "dgProduto";
            this.dgProduto.ReadOnly = true;
            this.dgProduto.RowHeadersVisible = false;
            this.dgProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProduto.Size = new System.Drawing.Size(830, 345);
            this.dgProduto.TabIndex = 3;
            this.dgProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduto_CellClick);
            // 
            // pro_cod
            // 
            this.pro_cod.DataPropertyName = "pro_cod";
            this.pro_cod.HeaderText = "Codigo";
            this.pro_cod.Name = "pro_cod";
            this.pro_cod.ReadOnly = true;
            // 
            // pro_nome
            // 
            this.pro_nome.DataPropertyName = "pro_nome";
            this.pro_nome.HeaderText = "Produto";
            this.pro_nome.Name = "pro_nome";
            this.pro_nome.ReadOnly = true;
            // 
            // pro_descricao
            // 
            this.pro_descricao.DataPropertyName = "pro_descricao";
            this.pro_descricao.HeaderText = "Descrição";
            this.pro_descricao.Name = "pro_descricao";
            this.pro_descricao.ReadOnly = true;
            // 
            // pro_valorpago
            // 
            this.pro_valorpago.DataPropertyName = "pro_valorpago";
            this.pro_valorpago.HeaderText = "Custo";
            this.pro_valorpago.Name = "pro_valorpago";
            this.pro_valorpago.ReadOnly = true;
            // 
            // pro_valorvenda
            // 
            this.pro_valorvenda.DataPropertyName = "pro_valorvenda";
            this.pro_valorvenda.HeaderText = "Venda";
            this.pro_valorvenda.Name = "pro_valorvenda";
            this.pro_valorvenda.ReadOnly = true;
            // 
            // pro_qtde
            // 
            this.pro_qtde.DataPropertyName = "pro_qtde";
            this.pro_qtde.HeaderText = "Quantidade";
            this.pro_qtde.Name = "pro_qtde";
            this.pro_qtde.ReadOnly = true;
            this.pro_qtde.Visible = false;
            // 
            // umed
            // 
            this.umed.DataPropertyName = "umed";
            this.umed.HeaderText = "UND";
            this.umed.Name = "umed";
            this.umed.ReadOnly = true;
            // 
            // cat_nome
            // 
            this.cat_nome.DataPropertyName = "cat_nome";
            this.cat_nome.HeaderText = "Tipo";
            this.cat_nome.Name = "cat_nome";
            this.cat_nome.ReadOnly = true;
            // 
            // scat_nome
            // 
            this.scat_nome.DataPropertyName = "scat_nome";
            this.scat_nome.HeaderText = "Modelo";
            this.scat_nome.Name = "scat_nome";
            this.scat_nome.ReadOnly = true;
            // 
            // pro_ref
            // 
            this.pro_ref.DataPropertyName = "pro_ref";
            this.pro_ref.HeaderText = "Referencia";
            this.pro_ref.Name = "pro_ref";
            this.pro_ref.ReadOnly = true;
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
            this.pnCabecalho.Size = new System.Drawing.Size(835, 42);
            this.pnCabecalho.TabIndex = 7;
            this.pnCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnCabecalho_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Produto";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackgroundImage = global::Promissum.Properties.Resources.icone_fechar;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(771, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(62, 38);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImage = global::Promissum.Properties.Resources.icone_minimizar;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(726, 8);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(39, 23);
            this.btnMinimizar.TabIndex = 5;
            this.btnMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // frmConsultaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 522);
            this.Controls.Add(this.pnCabecalho);
            this.Controls.Add(this.dgProduto);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmConsultaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Produtos";
            this.Activated += new System.EventHandler(this.frmConsultaProduto_Activated);
            this.Load += new System.EventHandler(this.frmConsultaProduto_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).EndInit();
            this.pnCabecalho.ResumeLayout(false);
            this.pnCabecalho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.RadioButton rbSubCategoria;
        protected System.Windows.Forms.RadioButton rbCategoria;
        protected System.Windows.Forms.RadioButton rbCod;
        protected System.Windows.Forms.TextBox txtPesquisa;
        protected System.Windows.Forms.Button btnFiltrar;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.DataGridView dgProduto;
        protected System.Windows.Forms.RadioButton rbProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_valorpago;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_valorvenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn umed;
        private System.Windows.Forms.DataGridViewTextBoxColumn cat_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn scat_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_ref;
        private System.Windows.Forms.ComboBox cbImpressora;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel pnCabecalho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimizar;
    }
}
namespace Beta1._0.Consulta.ClienteProduto
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbReferencia = new System.Windows.Forms.RadioButton();
            this.rbProduto = new System.Windows.Forms.RadioButton();
            this.rbCod = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(717, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 314);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbReferencia);
            this.groupBox2.Controls.Add(this.rbProduto);
            this.groupBox2.Controls.Add(this.rbCod);
            this.groupBox2.Controls.Add(this.txtPesquisa);
            this.groupBox2.Controls.Add(this.btnFiltrar);
            this.groupBox2.Location = new System.Drawing.Point(9, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(249, 186);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PESQUISA";
            // 
            // rbReferencia
            // 
            this.rbReferencia.AutoSize = true;
            this.rbReferencia.Location = new System.Drawing.Point(8, 82);
            this.rbReferencia.Margin = new System.Windows.Forms.Padding(4);
            this.rbReferencia.Name = "rbReferencia";
            this.rbReferencia.Size = new System.Drawing.Size(112, 20);
            this.rbReferencia.TabIndex = 4;
            this.rbReferencia.TabStop = true;
            this.rbReferencia.Text = "REFERENCIA";
            this.rbReferencia.UseVisualStyleBackColor = true;
            // 
            // rbProduto
            // 
            this.rbProduto.AutoSize = true;
            this.rbProduto.Checked = true;
            this.rbProduto.Location = new System.Drawing.Point(8, 52);
            this.rbProduto.Margin = new System.Windows.Forms.Padding(4);
            this.rbProduto.Name = "rbProduto";
            this.rbProduto.Size = new System.Drawing.Size(66, 20);
            this.rbProduto.TabIndex = 1;
            this.rbProduto.TabStop = true;
            this.rbProduto.Text = "NOME";
            this.rbProduto.UseVisualStyleBackColor = true;
            // 
            // rbCod
            // 
            this.rbCod.AutoSize = true;
            this.rbCod.Location = new System.Drawing.Point(8, 23);
            this.rbCod.Margin = new System.Windows.Forms.Padding(4);
            this.rbCod.Name = "rbCod";
            this.rbCod.Size = new System.Drawing.Size(55, 20);
            this.rbCod.TabIndex = 0;
            this.rbCod.TabStop = true;
            this.rbCod.Text = "COD";
            this.rbCod.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(8, 111);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(231, 22);
            this.txtPesquisa.TabIndex = 2;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFiltrar.Location = new System.Drawing.Point(8, 143);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 28);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProduto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvProduto.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvProduto.Location = new System.Drawing.Point(16, 15);
            this.dgvProduto.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.RowHeadersVisible = false;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(693, 314);
            this.dgvProduto.TabIndex = 6;
            this.dgvProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduto_CellClick);
            this.dgvProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduto_CellDoubleClick);
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
            this.cat_nome.HeaderText = "Categoria";
            this.cat_nome.Name = "cat_nome";
            this.cat_nome.ReadOnly = true;
            // 
            // scat_nome
            // 
            this.scat_nome.DataPropertyName = "scat_nome";
            this.scat_nome.HeaderText = "SubCategoria";
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
            // frmConsultaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(987, 335);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Produto";
            this.Load += new System.EventHandler(this.frmConsultaProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.RadioButton rbProduto;
        protected System.Windows.Forms.RadioButton rbCod;
        protected System.Windows.Forms.TextBox txtPesquisa;
        protected System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.RadioButton rbReferencia;
        public System.Windows.Forms.DataGridView dgvProduto;
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
    }
}